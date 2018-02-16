using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitressingConsoleApplication
{
    public class Salad : Food
    {        
        private static Dictionary<eSaladTypes, int> saladsTypeDictionary = new Dictionary<eSaladTypes, int>()
        {
            {eSaladTypes.ClassicSalad, 1},
            {eSaladTypes.HealthSalad, 2},
            {eSaladTypes.CeasarSalad, 3}
        };

        private static Dictionary<eSaladTypes, int> saladsPriceDictionary = new Dictionary<eSaladTypes, int>()
        {
            {eSaladTypes.ClassicSalad, 40},
            {eSaladTypes.HealthSalad, 42},
            {eSaladTypes.CeasarSalad, 45}
        };

        public Salad(string i_Name) : base(i_Name)
        {
        }

        public void SetSecondaryTypePositionAndPrice(string i_Name)
        {
            eSaladTypes saladTypes = ((eSaladTypes)Enum.Parse(typeof(eSaladTypes), i_Name));
            SecondaryTypePosition = saladsTypeDictionary[saladTypes];
            Price = saladsPriceDictionary[saladTypes];            
        }

        public override string ToString()
        {
            return String.Format("{0,-20}{1,-5}{2,-5}", r_Name, Quantity, Price);
        }

        private enum eSaladTypes
        {
            ClassicSalad,
            HealthSalad,
            CeasarSalad,
        };
    }
}
