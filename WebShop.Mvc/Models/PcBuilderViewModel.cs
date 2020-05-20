using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Bll.DTO;
using WebShop.Dal.Models;

namespace WebShop.Models
{
    public class PcBuilderViewModel
    {
        public PcBuilderViewModel()
        {

        }
        public PcBuilderViewModel(List<ItemHeader> list)
        {
            AvailableItems = list;
        }
        public List<ItemHeader> AvailableItems { get; set; }

        public Guid Motherboard { get; set; }
        public Guid CPU { get; set; }
        public Guid RAM { get; set; }
        public Guid GPU { get; set; }
        public Guid Drive { get; set; }
        public Guid PSU { get; set; }
        public Guid Case { get; set; }
    }
}
