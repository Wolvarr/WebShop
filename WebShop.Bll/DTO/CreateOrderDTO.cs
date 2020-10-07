using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WebShop.Dal.Models;

namespace WebShop.Bll.DTO
{
    public class CreateOrderDTO
    {
        [Required]
        [Display(Name = "Név")]
        public string DeliveryName { get; set; }

        [Required]
        [Display(Name = "Név")]
        public string TaxName { get; set; }

        public Guid UserId { get; set; }

        public string PaymentMethod { get; set; }

        public Address BillingAddres { get; set; }
        public Address ShippingAddres { get; set; }

        [Required]
        [Display(Name = "Adószám")]
        public string TaxNumber { get; set; }

        [Required]
        [Display(Name = "Megjegyzés")]
        public string Comment { get; set; }
    }
}
