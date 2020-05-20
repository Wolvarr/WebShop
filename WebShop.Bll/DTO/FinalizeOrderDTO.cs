using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Bll.DTO
{
    public class FinalizeOrderDTO
    {
        public UserBillingDataDTO BillingData { get; set; }

        public List<string> PaymentMethods { get; set; }

        public int PriceSum { get; set; }
    }
}
