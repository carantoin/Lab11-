using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab11
{
    internal class Price
    {
        public string Name { get; set; }
        private int priceOfTool;
        public int PriceOfTool
        {
            get => priceOfTool;
            set
            {
                if (value >= 0) priceOfTool = value;
            }
        }
        private int number;
        public int Number
        {
            get => number;
            set { if (value >= 0) number = value; }
        }
        public Price(string name, int priceOfTools, int number)
        {
            Name = name;
            PriceOfTool = priceOfTools;
            Number = number;
        }
        public virtual double GetQuality()
        {
            return PriceOfTool / Number;
        }
    }
}