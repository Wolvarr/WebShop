using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebShop.Dal.Models
{
    public class CompletPC
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public Guid CaseId { get; set; }
        public Case  Case { get; set; }
        
        public Guid MotherBoardId { get; set; }
        public Motherboard Motherboard { get; set; }

        public Guid CpuId { get; set; }
        public Cpu Cpu { get; set; }

        public Guid GpuId { get; set; }
        public GraphicsCard Gpu { get; set; }

        public List<PC_Memory> Memories { get; set; }

        public List<PC_Drive> Drives { get; set; }

        public Guid PowerSupplyId { get; set; }
        public PowerSupply PowerSupply { get; set; }

    }
}
