using StockExchangeModel;
using StockExchangeTicker.StockExchangeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace StockExchangeTicker.Controllers
{
    /// <summary>
    /// Using BaseController this Controller has access to the webservice and 
    /// the database, respectively, in a couple of properties named:
    /// StockServiceClient and StockDataContext
    /// </summary>
    public class StockController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StockSymbols()
        {
            try
            {
                List<StockExchangeService.StockSymbol> SymbolList = new List<StockExchangeService.StockSymbol>();
                SymbolList = StockServiceClient.GetStockList().ToList();
                return PartialView(SymbolList);
            }
            catch (Exception e)
            {
                Elmah.ErrorSignal.FromCurrentContext().Raise(e);
                return View("Error");
            }
        }

        [Authorize]
        public ActionResult StockUserSymbols()
        {
            List<StockPriceHistory> stockUserSymbols =
                (from sl in StockDataContext.StockUserSymbols
                 where sl.UserIdentityName == User.Identity.Name
                 select sl.Symbol).AsEnumerable().Select(s => new StockPriceHistory { Symbol = s, Price = StockServiceClient.GetActualStockPrice(s) }).ToList();

            StockDataContext.StockPriceHistory.AddRange(stockUserSymbols);
            StockDataContext.SaveChanges();
            return PartialView(stockUserSymbols);
        }
        
        [Authorize]
        public ActionResult StockUserSymbolPriceHistoryChart()
        {
            var dataSet = (from sl in StockDataContext.StockUserSymbols
                                    join ph in StockDataContext.StockPriceHistory on sl.Symbol equals ph.Symbol
                                    where sl.UserIdentityName == User.Identity.Name
                                    orderby ph.Created_at descending
                                    select ph);
            //I want to see the last 6 prices of all my selected stocks, so I gorup by symbol and multiply that count by 6 
            //(since we are updating every 10 seconds, that should give us a minute of the timeline)
            var priceHistoryList = dataSet.Take(dataSet.GroupBy(h => h.Symbol).Count() * 5).ToList(); 
            return PartialView(priceHistoryList);
        }

        /// <summary>
        /// This is a secure way to add symbols to user stock list
        /// </summary>
        /// <param name="symbol">Stock symbol</param>
        /// <returns>Redirects to the home page if everything's ok, or a View on error</returns>
        [ValidateAntiForgeryToken]
        [Authorize]
        [HttpPost]
        public ActionResult RegisterSymbol(string symbol)
        {
            try
            {
                StockExchangeModel.StockUserSymbol userSymbol = new StockExchangeModel.StockUserSymbol()
                {
                    UserIdentityName = User.Identity.Name,
                    Symbol = symbol
                };
                StockDataContext.StockUserSymbols.Add(userSymbol);
                if (StockDataContext.SaveChanges() > 0)
                    return RedirectToAction("");
                else
                    return View("Error");
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException e)
            {
                //the symbol has been added already, let's ignore this error.
                Elmah.ErrorSignal.FromCurrentContext().Raise(e); //Just in case it's another error and it will log it for future audit
                return RedirectToAction("");
            }
            catch (Exception e)
            {
                Elmah.ErrorSignal.FromCurrentContext().Raise(e);
                return View("Error");
            }
        }
        /// <summary>
        /// Secure way to remove symbols to user stock list
        /// </summary>
        /// <param name="symbol">Stock symbol</param>
        /// <returns>Redirects to the home page if everything's ok, or a View on error</returns>
        [ValidateAntiForgeryToken]
        [Authorize]
        [HttpPost]
        public ActionResult UnRegisterSymbol(string symbol)
        {
            try
            {
                var itemToRemove = 
                    StockDataContext.StockUserSymbols.SingleOrDefault(
                        x => x.UserIdentityName == User.Identity.Name && x.Symbol == symbol); //returns the selected symbol

                if (itemToRemove != null)
                {
                    StockDataContext.StockUserSymbols.Remove(itemToRemove);
                    if (StockDataContext.SaveChanges() > 0)
                        return RedirectToAction("");
                    else
                        return View("Error");
                }
                else // the record doesn't exist.
                    return RedirectToAction("");
            }
            catch (Exception e)
            {
                Elmah.ErrorSignal.FromCurrentContext().Raise(e);
                return View("Error");
            }
        }
    }
}