using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitressingConsoleApplication
{
    public class Drink : Food
    {
        private static Dictionary<eNamesTypes, int> drinksDamesTypesDictionary = new Dictionary<eNamesTypes, int>()
        {
            {eNamesTypes.Cola, 1},
            {eNamesTypes.Sprite, 2},
            {eNamesTypes.Fanta, 3},
            {eNamesTypes.Water, 1},
            {eNamesTypes.Apple, 2},
            {eNamesTypes.Orange, 3}
        };

        private static Dictionary<eDrinksTypes, int> drinksTypeDictionary = new Dictionary<eDrinksTypes, int>()
        {
            {eDrinksTypes.Child, 1},
            {eDrinksTypes.Soft, 2},
            {eDrinksTypes.Wine, 3},
            {eDrinksTypes.Soda, 4},
            {eDrinksTypes.Bear, 5}
        };

        private static Dictionary<eDrinksTypes, int> drinksPriceDictionary = new Dictionary<eDrinksTypes, int>()
        {
            {eDrinksTypes.Child, 9},
            {eDrinksTypes.Soft, 14},
            {eDrinksTypes.Wine, 33},
            {eDrinksTypes.Soda, 14},
            {eDrinksTypes.Bear, 30}
        };

        public Drink(string i_Name) : base(i_Name)
        {
        }

        internal void SetMainTypePositionAndPrice(string i_Type)
        {
            eDrinksTypes drinkType = ((eDrinksTypes)Enum.Parse(typeof(eDrinksTypes), i_Type));
            MainTypePosition = drinksTypeDictionary[drinkType];
            Price = drinksPriceDictionary[drinkType];
        }

        internal void SetSecondaryTypePosition(string i_Name)
        {
            SecondaryTypePosition = drinksDamesTypesDictionary[((eNamesTypes)Enum.Parse(typeof(eNamesTypes), i_Name))];
        }

        public override string ToString()
        {
            return String.Format("{0,-20}{1,-5}{2,-5}", r_Name, Quantity, Price);
        }

        private enum eNamesTypes
        {
            Cola,
            Sprite,
            Fanta,
            Water,
            Apple,
            Orange,
        };

        private enum eDrinksTypes
        {
            Child,
            Soft,
            Wine,
            Soda,
            Bear
        };
    }
}
