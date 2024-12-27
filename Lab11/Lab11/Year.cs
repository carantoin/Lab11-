using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab11
{
    internal class Year : Price
    {
        private int yearOfRelease;
        private string v;
        public int YearOfRelease
        {
            get => yearOfRelease;
            set
            {
                if (value >= 0) yearOfRelease = value;
            }
        }
        public Year(string name, int priceOfTool, int number, int _yearOfRelease) : base(name, priceOfTool, number)
        {
            YearOfRelease = _yearOfRelease;
        }
        public override double GetQuality()
        {
            return base.GetQuality() + (0.5 * DateTime.Now.Year - YearOfRelease);
        }
    }
}