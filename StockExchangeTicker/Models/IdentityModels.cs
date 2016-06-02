using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using StockExchangeModel;

namespace StockExchangeTicker.Models
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class StockExchangeDbContext : IdentityDbContext<ApplicationUser>
    {
        public StockExchangeDbContext()
            : base("StockExchange", throwIfV1Schema: false)
        {
            Database.CreateIfNotExists();
            Users.Create();
        }

        public static StockExchangeDbContext Create()
        {
            return new StockExchangeDbContext();
        }
        public virtual DbSet<StockPriceHistory> StockPriceHistory { get; set; }
        public virtual DbSet<StockUserSymbol> StockUserSymbols { get; set; }
        public virtual DbSet<StockSymbol> StockSymbols { get; set; }
    }
}