using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Mvc.Services
{
    public class EmailSettings
    {
        public string Server { get; set; }
        public string Port { get; set; }
        public string FromAddres { get; set; }
        public string Password { get; set; }
    }
}
