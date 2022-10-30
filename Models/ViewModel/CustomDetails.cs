using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20676736_HW06.Models.ViewModel
{
    public class CustomDetails
    {
        internal short model_year;

        public string product_name { get; set; }
        public short modal_year { get; set; }
        public decimal list_price { get; set; }
        public string brand_name { get; set; }
        public string category_name { get; set; }

        public List<CustomStoreQuantity> storeQuantities { get; set; }


    }
}