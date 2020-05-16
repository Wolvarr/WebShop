using System.ComponentModel;

namespace WebShop.Dal.Enums
{
    public enum CpuSocket
    {
        [Description("SocketAM1")]
        SocketAM1,

        [Description("SocketAM2")]
        SocketAM2,

        [Description("SocketAM3")]
        SocketAM3,

        [Description("SocketAM4")]
        SocketAM4,

        [Description("SocketTR41")]
        SocketTR4,

        [Description("SocketG1")]
        SocketG1,

        [Description("LGA1156")]
        LGA1156,

        [Description("LGA1155")]
        LGA1155,

        [Description("LGA2011")]
        LGA2011,

        [Description("LGA1356")]
        LGA1356,

        [Description("LGA1151")]
        LGA1151,

        [Description("LGA2066")]
        LGA2066,
        AMDTR4
    }
}
