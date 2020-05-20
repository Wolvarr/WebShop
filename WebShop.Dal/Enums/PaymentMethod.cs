using System.ComponentModel;

namespace WebShop.Dal.Models
{
    public enum PaymentMethod
    {
        [Description("Átvétel során")]
        WhenDelivered,

        [Description("Előre utalás")]
        AdvancePayment,

        [Description("Online bankkártya")]
        OnlineCreditCard,
    }
}