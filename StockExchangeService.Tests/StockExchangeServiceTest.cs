using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockExchangeService.Tests.TestingService;

namespace StockExchangeService.Tests
{
    [TestClass]
    public class StockExchangeServiceTest
    {
        [TestMethod]
        public void GetActualStockPrice_SymbolExists()
        {
            StockQuoteServiceSoapClient client = new StockQuoteServiceSoapClient();
            client.ClientCredentials.UserName.UserName = "test";
            client.ClientCredentials.UserName.Password = "test";
            double result = client.GetActualStockPrice("APPL");
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetActualStockPrice_SymbolDoesNotExist()
        {
            StockQuoteServiceSoapClient client = new StockQuoteServiceSoapClient();
            client.ClientCredentials.UserName.UserName = "test";
            client.ClientCredentials.UserName.Password = "test";
            double result = client.GetActualStockPrice("FOOBARGOOG"); ;
            Assert.AreEqual(result, 0); //returns 0 in case there is no symbol
        }
    }
}
