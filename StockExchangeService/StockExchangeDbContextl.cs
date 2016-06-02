namespace StockExchangeService
{
    using Models;
    using System.Data.Entity;

    public class StockExchangeDbContext : DbContext
    {
        public StockExchangeDbContext()
            : base("name=StockExchange")
        {
            
        }

        public static StockExchangeDbContext Create()
        {
            return new StockExchangeDbContext();
        }

        public virtual DbSet<StockSymbol> StockSymbols { get; set; }
    }
    
}