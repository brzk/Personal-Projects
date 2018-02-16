using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitressingLibrary
{
    public class MainDish : Food
    {
        private static Dictionary<eMainDishTypes, int> mainDishesTypeDictionary = new Dictionary<eMainDishTypes, int>()
        {
            {eMainDishTypes.Schnitzel, 1},
            {eMainDishTypes.ChickenBreast, 2},
            {eMainDishTypes.SpringChicken, 3}
        };

        private static Dictionary<eMainDishTypes, int> mainDishesPriceDictionary = new Dictionary<eMainDishTypes, int>()
        {
            {eMainDishTypes.Schnitzel, 55},
            {eMainDishTypes.ChickenBreast, 42},
            {eMainDishTypes.SpringChicken, 60}
        };

        public MainDish(string i_Name) : base(i_Name)
        {
        }

        public override string ToString()
        {
            return String.Format("{0,-20}{1,-5}{2,-5}", r_Name, Quantity, Price);
        }

        public void SetSecondaryTypePositionAndPrice(string i_Name)
        {
            eMainDishTypes mainDishTypes = ((eMainDishTypes)Enum.Parse(typeof(eMainDishTypes), i_Name));
            SecondaryTypePosition = mainDishesTypeDictionary[mainDishTypes];
            Price = mainDishesPriceDictionary[mainDishTypes];
        }

        private enum eMainDishTypes
        {
            Schnitzel,
            ChickenBreast,
            SpringChicken,
        };
    }
}
