using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using WebShop.Bll.DTO;
using WebShop.Dal.Models;

namespace WebShop.Models
{
    public class FinalizeOrderViewModel
    {
        [BindProperty]
        public UserBillingDataDTO BillingData { get; set; }

        public List<string> PaymentMethods { get; set; }

        public int PriceSum { get; set; }

        public CreateOrderDTO OrderDto { get; set; }

        public FinalizeOrderViewModel()
        {

        }

        public FinalizeOrderViewModel(FinalizeOrderDTO dto)
        {
            this.BillingData = dto.BillingData;
            this.PaymentMethods = dto.PaymentMethods;
            this.PriceSum = dto.PriceSum;
        }
    }
}
