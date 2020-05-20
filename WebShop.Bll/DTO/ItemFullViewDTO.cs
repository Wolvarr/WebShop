using Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using WebShop.Bll.Extensions;
using WebShop.Dal.Models;

namespace WebShop.Bll.DTO
{
    public class ItemFullViewDTO : ItemHeader
    {
        public ItemFullViewDTO(Item item)
            : base(item)
        {
            SpecificProperties = new SpecificProperties(item);
            SimilarItems = new PagedResult<ItemHeader>();
            this.Ratings = item.Ratings;
            this.Comments = item.Comments;
        }

        public SpecificProperties SpecificProperties { get; set; }

        public string Warranty { get; set; }

        public DateTime? ExpectedAvailalbleDate { get; set; }

        public PagedResult<ItemHeader> SimilarItems { get; set; }

        public List<Rating> Ratings { get; set; }
        public List<Comment> Comments { get; set; }
    }


    public class SpecificProperties
    {
        public SpecificProperties(Item item)
        {
            if (item is Case)
            {
                Case pcCase = item as Case;
                this.BuiltInFanNumber = pcCase.BuiltInFanNumber;
                this.SupportedMotherboard = EnumExtensionMethods.GetDescription(pcCase.SupportedMotherboard);
                this.Height = pcCase.Height;
                this.Width = pcCase.Width;
                this.Depth = pcCase.Depth;
                this.HDDNumber = pcCase.HDDNumber;

            }

            if(item is Cpu)
            {
                Cpu cpu = item as Cpu;
                this.ProcessorFamily = cpu.ProcessorFamily;
                this.Technology = cpu.Technology;
                this.CoreNumber = cpu.CoreNumber;
                this.ThreadNumber = cpu.ThreadNumber;
                this.Socket = EnumExtensionMethods.GetDescription(cpu.Socket);
                this.BaseClock = cpu.BaseClock;
                this.TDP = cpu.TDP;
            }

            if(item is GraphicsCard)
            {
                GraphicsCard gpu = item as GraphicsCard;
                this.BuiltInMemory = gpu.BuiltInMemory;
                this.MemoryClock = gpu.MemoryClock;
                this.BandWidth = gpu.BandWidth;
                this.CoolerType = gpu.CoolerType;
                this.MemoryType = EnumExtensionMethods.GetDescription(gpu.MemoryType);
                this.PowerSupplyConnection = gpu.PowerSupplyConnection;
                this.BaseClock = gpu.BaseClock;
                this.TDP = gpu.TDP;
            }

            if(item is HardDrive)
            {
                HardDrive drive = item as HardDrive;
                this.Size = drive.Size;
                this.ReadSpeed = drive.ReadSpeed;
                this.WriteSpeed = drive.WriteSpeed;
                this.Weight = drive.Weight;
                this.DriveSocket =  EnumExtensionMethods.GetDescription(drive.Socket);
            }

            if(item is Memory)
            {
                Memory mem = item as Memory;
                this.BaseClock = mem.BaseClock;
                this.Capacity = mem.Capacity;
                this.MemoryTypeForMmoryCard = EnumExtensionMethods.GetDescription(mem.MemoryType);
                this.Timing = mem.Timing;
                this.Kit = mem.Kit;
            }

            if(item is Motherboard)
            {
                Motherboard board = item as Motherboard;
                this.Type = EnumExtensionMethods.GetDescription(board.Type);
                this.Chipset = board.Chipset;
                this.CpuSocketForMotherboard = EnumExtensionMethods.GetDescription(board.Socket);
                this.SupportedMemoryType = EnumExtensionMethods.GetDescription(board.SupportedMemoryType);
                this.SupportedMemorySpeed = board.SupportedMemorySpeed;
                this.MemorySocketNumber = board.MemorySocketNumber;
            }

            if(item is PowerSupply)
            {
                PowerSupply psu = item as PowerSupply;
                this.ATXConnector = psu.ATXConnector;
                this.MolexConnector = psu.MolexConnector;
                this.SixPinConnector = psu.SixPinConnector;
                this.SixPlusTwoConnector = psu.SixPlusTwoConnector;
                this.Efficiency = psu.Efficiency;
                this.IsModular = psu.IsModular;
            }
            if(item is CompletPC)
            {
                CompletPC pc = item as CompletPC;
                this.Case = pc.Case;
                this.Motherboard = pc.Motherboard;
                this.Cpu = pc.Cpu;
                this.Gpu = pc.Gpu;
                this.Memories = pc.Memories;
                this.Drives = pc.Drives;
                this.PowerSupply = pc.PowerSupply;
            }
        }
        #region hardware
        
        public int? BaseClock { get; set; }

        public int? TDP { get; set; }

        public int? Weight { get; set; }
        #endregion

        #region PC

        [DisplayName("Gépház")]
        public string Case { get; set; }

        [DisplayName("Alaplap")]
        public string Motherboard { get; set; }

        [DisplayName("Processzor")]
        public string Cpu { get; set; }

        [DisplayName("Videókártya")]
        public string Gpu { get; set; }

        [DisplayName("Memória")]
        public string Memories { get; set; }

        [DisplayName("Meghajtók")]
        public string Drives { get; set; }

        [DisplayName("Tápegység")]
        public string PowerSupply { get; set; }
        #endregion

        #region case
        [DisplayName("Beépített ventillátorok")]
        public int? BuiltInFanNumber { get; set; }

        [DisplayName("Alaplap típusa")]

        public string SupportedMotherboard { get; set; }

        [DisplayName("Magasság(mm)")]
        public int? Height { get; set; }

        [DisplayName("Szélesség(mm)")]
        public int? Width { get; set; }

        [DisplayName("Mélység(mm)")]
        public int? Depth { get; set; }

        [DisplayName("HDD foglalatok száma")]
        public int? HDDNumber { get; set; }
        #endregion

        #region cpu
        [DisplayName("Processzor család")]
        public string ProcessorFamily { get; set; }

        [DisplayName("Technológia(nm)")]
        public int? Technology { get; set; } // in nm

        [DisplayName("Magok száma")]
        public int? CoreNumber { get; set; }

        [DisplayName("Szálak száma")]
        public int? ThreadNumber { get; set; }

        [DisplayName("Foglalat")]
        public string Socket { get; set; }

        #endregion

        #region gpu
        [DisplayName("Beépített memória")]
        public int? BuiltInMemory { get; set; }

        [DisplayName("Memória órajel")]
        public int? MemoryClock { get; set; }

        [DisplayName("Sávszélesség")]
        public int? BandWidth { get; set; }

        [DisplayName("Hűtés típusa")]
        public string CoolerType { get; set; }

        [DisplayName("Memória típusas")]
        public string MemoryType { get; set; }

        [DisplayName("Tápegység csatlakozás")]
        public string PowerSupplyConnection { get; set; }  //(pin)
        #endregion

        #region drive

        [DisplayName("Méret")]
        public int? Size { get; set; }

        [DisplayName("Olvasási sebesség")]
        public int? ReadSpeed { get; set; }

        [DisplayName("Írási sebesség")]
        public int? WriteSpeed { get; set; }

        [DisplayName("Csatlakozás")]
        public string DriveSocket { get; set; }
        #endregion

        #region memory

        [DisplayName("Méret")]
        public int? Capacity { get; set; }

        [DisplayName("Memória típusa")]
        public string MemoryTypeForMmoryCard { get; set; }

        [DisplayName("Időzítés(CL)")]
        public int? Timing { get; set; } //(CL)

        [DisplayName("Kiszerelés:")]
        public int? Kit { get; set; } //modules
        #endregion

        #region motherboard

        [DisplayName("Alaplap típusa")]
        public string Type { get; set; }

        [DisplayName("Chipset típusa")]
        public string Chipset { get; set; }

        [DisplayName("Foglalat")]
        public string CpuSocketForMotherboard { get; set; }

        [DisplayName("Támogatott memória típus")]
        public string SupportedMemoryType { get; set; }

        [DisplayName("Támogatott memória sebesség(Mzh)")]
        public string SupportedMemorySpeed { get; set; }  //3000, 3200,..

        [DisplayName("Memória foglalatok száma")]
        public int? MemorySocketNumber { get; set; }
        #endregion

        #region psu
        [DisplayName("ATX csatlakozók száma")]
        public int? ATXConnector { get; set; }

        [DisplayName("Molex csatlakozók száma")]
        public int? MolexConnector { get; set; }

        [DisplayName("Hat pines csatlakozók száma")]
        public int? SixPinConnector { get; set; }

        [DisplayName("Hat + két pines csatlakozók száma")]
        public int? SixPlusTwoConnector { get; set; }

        [DisplayName("Hatásfok")]
        public int? Efficiency { get; set; } //(%)

        [DisplayName("Moduláris tápegység")]
        public bool? IsModular { get; set; }
        #endregion


        public string GetDisplayName(string propertyName)
        {
           return DisplayNameHelper.GetDisplayName(this, propertyName);
        }
    }
}
