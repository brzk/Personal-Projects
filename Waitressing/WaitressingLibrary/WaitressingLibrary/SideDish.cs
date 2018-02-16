using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitressingLibrary
{
    public class SideDish : Food
    {        
        private static Dictionary<eSideDishTypes, int> sideDishesTypeDictionary = new Dictionary<eSideDishTypes, int>()
        {
            {eSideDishTypes.Fries, 1},
            {eSideDishTypes.Mashed, 2},
            {eSideDishTypes.OnionRings, 3},
            {eSideDishTypes.Rice, 4},
            {eSideDishTypes.Soup, 5},
            {eSideDishTypes.Salad, 6}
        };

        private static Dictionary<eSideDishTypes, int> sideDishesPriceDictionary = new Dictionary<eSideDishTypes, int>()
        {
            {eSideDishTypes.Fries, 15},
            {eSideDishTypes.Mashed, 15 },
            {eSideDishTypes.OnionRings, 15},
            {eSideDishTypes.Rice, 15},
            {eSideDishTypes.Soup, 15 },
            {eSideDishTypes.Salad, 15}
        };
        
        public SideDish(string i_Name) : base(i_Name)
        {
        }

        public void SetSecondaryTypePositionAndPrice(string i_Name)
        {
            eSideDishTypes sideDishTypes = ((eSideDishTypes)Enum.Parse(typeof(eSideDishTypes), i_Name));
            SecondaryTypePosition = sideDishesTypeDictionary[sideDishTypes];
            Price = sideDishesPriceDictionary[sideDishTypes];            
        }
        public override string ToString()
        {
            return String.Format("{0,-20}{1,-8}{2,-5}", r_Name, Quantity, Price);
        }

        private enum eSideDishTypes
        {
            Fries,
            Mashed,
            OnionRings,
            Rice,
            Soup,
            Salad
        };
    }
}
