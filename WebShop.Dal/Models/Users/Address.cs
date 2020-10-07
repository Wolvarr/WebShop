using System.ComponentModel.DataAnnotations;

namespace WebShop.Dal.Models
{
    public class Address
    {
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
        [Display(Name = "Házszám/ajtó")]
        public string HouseNumberAndDoor { get; set; }
    }
}
