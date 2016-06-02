using StockExchangeService.Models;
using System;
using System.Linq;
using System.Web.Services;

namespace StockExchangeService
{
    /// <summary>
    /// Service that simulates a Staock Exchange Service
    /// </summary>
    [WebService(Namespace = "https://www.centralgps.net/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    [System.Web.Script.Services.ScriptService]
    public class StockQuoteService : WebService
    {
        //Let's define an exception to throw when the symbol does not exists in the database
        static ArgumentException argException = new ArgumentException("The provided symbol does not exist.");

        [WebMethod]
        public double GetActualStockPrice(string symbol)
        {
            //Generate a random price for our stock symbol
            double actualPrice = 0;
            StockExchangeDbContext db = new StockExchangeDbContext();
            var stockSymbol = (from s in db.StockSymbols
                               where s.Symbol == symbol
                               select s).FirstOrDefault();
            if (stockSymbol != null) // Check if the symbol exists
                actualPrice = new Random((int)DateTime.Now.Ticks).Next(1, 1000);
            return actualPrice;           
        }

        [WebMethod]
        public StockSymbol[] GetStockList()
        {
            StockExchangeDbContext db = new StockExchangeDbContext();
            return (from b in db.StockSymbols
                    orderby b.Symbol
                    select b).ToArray();
        }
    }
}
