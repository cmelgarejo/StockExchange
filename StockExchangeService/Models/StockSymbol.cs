using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StockExchangeService.Models
{
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