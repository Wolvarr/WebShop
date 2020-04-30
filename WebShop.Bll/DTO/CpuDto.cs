using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Bll.Exceptions;
using WebShop.Bll.Extensions;
using WebShop.Dal.Enums;
using WebShop.Dal.Models;

namespace WebShop.Bll.DTO
{
    public class CpuDto : AbstractItemDto
    {
        public CpuDto(Item item)
            :base(item)
        {
            if(!(item is Cpu))
            {
                throw new WrongTypeForDtoException("Cannot convert " + item.GetType().ToString() + "to CpuDto");
            }

            Cpu cpu = item as Cpu;

            this.ProcessorFamily = cpu.ProcessorFamily;
            this.Technology = cpu.Technology;
            this.CoreNumber = cpu.CoreNumber;
            this.ThreadNumber = cpu.ThreadNumber;
            this.Socket = EnumExtensionMethods.GetDescription(cpu.Socket);
            this.BaseClock = cpu.BaseClock;
            this.TDP = cpu.TDP;
        }

     

        public int TDP { get; set; }

        public int BaseClock { get; set; }

        public string ProcessorFamily { get; set; }

        public int Technology { get; set; } // in nm

        public int CoreNumber { get; set; }

        public int ThreadNumber { get; set; }

        public string Socket { get; set; }
    }
}
