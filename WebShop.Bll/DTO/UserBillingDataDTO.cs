using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WebShop.Dal.Models;

namespace WebShop.Bll.DTO
{
    public class UserBillingDataDTO
    {
        [Required]
        [Display(Name = "Név")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Irányítószám")]
        public string ZipCode { get; set; }

        [Required]
        [Display(Name = "Ország")]
        public string Country { get; set; }

        [Required]
        [Display(Name = "Város")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Utca")]
        public string Street { get; set; }

        [Required]
        [Display(Name = "Házszám/Ajtó")]
        public string HouseNumberAndDoor { get; set; }

        public UserBillingDataDTO(WebShopUser user)
        {
            this.Name = user.NickName;

            if (user.BillingAddress != null)
            {
                this.ZipCode = user.BillingAddress.ZipCode;
                this.Country = user.BillingAddress.Country;
                this.City = user.BillingAddress.City;
                this.Street = user.BillingAddress.Street;
                this.HouseNumberAndDoor = user.BillingAddress.HouseNumberAndDoor;
            }
       }
    }

   
}
