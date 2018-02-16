using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitressingConsoleApplication
{
    public class Dessert : Food
    {
        private static Dictionary<eDessertTypes, int> dessersTypeDictionary = new Dictionary<eDessertTypes, int>()
        {
            {eDessertTypes.CremeBrulee, 1},
            {eDessertTypes.ChocolateCake, 2},
            {eDessertTypes.Cheesecake, 3},
            {eDessertTypes.IceCream, 4}
        };

        private static Dictionary<eDessertTypes, int> dessersPriceDictionary = new Dictionary<eDessertTypes, int>()
        {
            {eDessertTypes.CremeBrulee, 20},
            {eDessertTypes.ChocolateCake, 36},
            {eDessertTypes.Cheesecake, 35},
            {eDessertTypes.IceCream, 37}
        };

        public Dessert(string i_Name) : base(i_Name)
        {
        }

        public void SetSecondaryTypePositionAndPrice(string i_Name)
        {
            eDessertTypes dessertType = ((eDessertTypes)Enum.Parse(typeof(eDessertTypes), i_Name));
            SecondaryTypePosition = dessersTypeDictionary[dessertType];
            Price = dessersPriceDictionary[dessertType];
        }
        public override string ToString()
        {
            return String.Format("{0,-20}{1,-5}{2,-5}", r_Name, Quantity, Price);
        }

        private enum eDessertTypes
        {
            CremeBrulee,
            ChocolateCake,
            Cheesecake,
            IceCream
        };
    }
}
