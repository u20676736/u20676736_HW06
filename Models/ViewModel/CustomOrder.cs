using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20676736_HW06.Models.ViewModel
{
    public class CustomOrder
    {        
        public string product_name { get; set; }
        public decimal list_price { get; set; }
        public int quantity { get; set; }
        public int category_id { get; set; }
        public short model_year { get; set; }
        
    }
}