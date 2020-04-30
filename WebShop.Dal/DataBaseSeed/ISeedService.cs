using System.Collections.Generic;
using WebShop.Dal.Models;

namespace WebShop.Dal.DataBaseSeed
{
    public interface ISeedService
    {
        IList<Cpu> Cpus { get; }
        IList<Case> Cases { get; }
        IList<GraphicsCard> Graphics { get; }
        IList<HardDrive> HardDrives { get; }
        IList<Memory> Memories { get; }
        IList<Motherboard> Motherboards { get; }
        IList<PowerSupply> PowerSupplies { get; }

        //TODO

        IList<CompletPC> CompletPCs { get; }
    }
}
