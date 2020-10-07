namespace WebShop.Dal.Models
{
    public class PowerSupply : Hardware
    {
        public PowerSupply()
        {
            this.Category = Enums.Category.PowerSupply;
        }

        public int ATXConnector { get; set; }

        public int MolexConnector { get; set; }

        public int SixPinConnector { get; set; }

        public int SixPlusTwoConnector { get; set; }

        public int Efficiency { get; set; } //(%)

        public bool IsModular { get; set; }
    }
}
