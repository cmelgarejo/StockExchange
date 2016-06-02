using StockExchangeTicker.Models;
using StockExchangeTicker.StockExchangeService;
using System.Web.Mvc;

namespace StockExchangeTicker.Controllers
{
    /// <summary>
    /// A base controller that exposes access to the StockService and the StockDBContext using EF6
    /// </summary>
    public class BaseController : Controller
    {
        private StockExchangeDbContext _StockDataContext = null;
        public StockExchangeDbContext StockDataContext
        {
            get
            {
                if (_StockDataContext == null)
                    _StockDataContext = new StockExchangeDbContext();
                return _StockDataContext;
            }
        }

        private StockQuoteServiceSoapClient _StockServiceClient = null;
        protected StockQuoteServiceSoapClient StockServiceClient
        {
            get
            {
                if (_StockServiceClient == null)
                {
                    _StockServiceClient = new StockQuoteServiceSoapClient();
                    _StockServiceClient.ClientCredentials.UserName.UserName = Properties.Settings.Default.wsStockExchange_UserName;
                    _StockServiceClient.ClientCredentials.UserName.Password = Properties.Settings.Default.wsStockExchange_Password;
                }
                return _StockServiceClient;
            }
        }
    }
}