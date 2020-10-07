using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebShop.Dal.Context;
using WebShop.Dal.Models;

namespace WebShop.Mvc.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<WebShopUser> _userManager;
        private readonly SignInManager<WebShopUser> _signInManager;
        private readonly WebShopDbContext context;

        public IndexModel(
            UserManager<WebShopUser> userManager,
            SignInManager<WebShopUser> signInManager,
            WebShopDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this.context = context;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Display(Name = "Felhasználónév")]
            public string NickName { get; set; }

            [Display(Name = "Ország")]
            public string Country { get; set; }

            [Display(Name = "Település")]
            public string City { get; set; }

            [Display(Name = "Irányítószám")]
            public string ZipCode { get; set; }

            [Display(Name = "Utca")]
            public string Street { get; set; }

            [Display(Name = "Házszám, emelet/ajtó")]
            public string HouseNumberAndDoor { get; set; }

            [Phone]
            [Display(Name = "Telefonszám")]
            public string PhoneNumber { get; set; }
        }

        private async Task LoadAsync(WebShopUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var nickName = user.NickName;
            var country = "";
            var city = "";
            var zipCode = "";
            var street = "";
            var houseNumberAndDoor = "";
            if (user.BillingAddress != null)
            {
                country = user.BillingAddress.Country;
                city = user.BillingAddress.City;
                zipCode = user.BillingAddress.ZipCode;
                street = user.BillingAddress.Street;
                houseNumberAndDoor = user.BillingAddress.HouseNumberAndDoor;
            }


            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                NickName = nickName,
                Country = country,
                City = city,
                ZipCode = zipCode,
                Street = street,
                HouseNumberAndDoor = houseNumberAndDoor
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            if (user.BillingAddress == null)
            {
                user.BillingAddress = new Address();
            }
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var nickName = user.NickName;
            var country = user.BillingAddress.Country;
            var city = user.BillingAddress.City;
            var zipCode = user.BillingAddress.ZipCode;
            var street = user.BillingAddress.Street;
            var houseNumberAndDoor = user.BillingAddress.HouseNumberAndDoor;

            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    var userId = await _userManager.GetUserIdAsync(user);
                    throw new InvalidOperationException($"Unexpected error occurred setting phone number for user with ID '{userId}'.");
                }
            }
            if (Input.NickName != nickName)
                user.NickName = Input.NickName;

            if (Input.Country != country)
                user.BillingAddress.Country = Input.Country;

            if (Input.City != city)
                user.BillingAddress.City = Input.City;

            if (Input.ZipCode != zipCode)
                user.BillingAddress.ZipCode = Input.ZipCode;

            if (Input.Street != street)
                user.BillingAddress.Street = Input.Street;

            if (Input.HouseNumberAndDoor != houseNumberAndDoor)
                user.BillingAddress.HouseNumberAndDoor = Input.HouseNumberAndDoor;

            await _signInManager.RefreshSignInAsync(user);
            await this.context.SaveChangesAsync();
            StatusMessage = "Adatok sikeresen módosítva";
            return RedirectToPage();
        }
    }
}
