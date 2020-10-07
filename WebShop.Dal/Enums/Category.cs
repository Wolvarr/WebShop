using System.ComponentModel;

namespace WebShop.Dal.Enums
{
    public enum Category
    {   
        [Description("Processzor")]
        Cpu,
        [Description("Videókártya")]
        Gpu,
        [Description("Gépház")]
        Case,
        [Description("Merevlemez")]
        HardDrive,
        [Description("Memória")]
        Memory,
        [Description("Alaplap")]
        MotherBoard,
        [Description("Tápegység")]
        PowerSupply,
        [Description("Kiegészítő")]
        Extra,
        [Description("Számítógép")]
        CompletPc
    }
}
