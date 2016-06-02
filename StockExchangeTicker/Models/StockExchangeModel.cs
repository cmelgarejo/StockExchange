using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockExchangeModel
{
    [Serializable]
    public class StockPriceHistory
    {
        [Key]
        [Required]
        public int HistoryId { get; set; }

        /// <summary>
        /// This will be indexed to search prices faster.
        /// </summary>
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Index]
        public string Symbol { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public DateTime Created_at { get; set; }

        public StockPriceHistory()
        {
            Created_at = DateTime.Now;
        }
    }

    /// <summary>
    /// this will hold the Id's of the tables StockSymbol and AspNetUser to have a linked list of Stock prices for each user
    /// </summary>
    [Serializable]
    public class StockUserSymbol
    {
        [Key]
        [Required]
        [Column(TypeName = "VARCHAR", Order = 2)]
        [StringLength(255)]
        [Index]
        public string UserIdentityName { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "VARCHAR", Order = 1)]
        [StringLength(50)]
        [Index]
        public string Symbol { get; set; }
    }

    /// <summary>
    /// Holds the stock symbols for reference
    /// </summary>
    [Serializable]
    public class StockSymbol
    {
        [Required]
        [Key]
        public string Symbol { get; set; }
        [Required]
        public string Name { get; set; }
        public string MarketCap { get; set; }
        public string IPOYear { get; set; }
        public string Sector { get; set; }
        public string Industry { get; set; }

        [Required]
        public DateTime Created_at { get; set; }

        public StockSymbol()
        {
            Created_at = DateTime.Now;
        }
    }
}