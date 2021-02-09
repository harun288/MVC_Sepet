using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Sepet.Models
{
    public class CardItem
    {
        public CardItem()
        {
            Quantity = 1;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public short Quantity { get; set; }
        public decimal? UnitPrice { get; set; }

        public decimal? SubTotal
        {
            get
            {
                return Quantity * UnitPrice;
            }
        }
    }
}
    