using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WebShop.Dal.Enums
{
    public enum MotherboardType
    {
        [Description("ATX")]
        ATX,

        [Description("EATX")]
        EATX,

        [Description("Micro_ATX")] 
        Micro_ATX,

        [Description("Mini_ITX")] 
        Mini_ITX
    }
}
