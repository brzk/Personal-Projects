using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitressingConsoleApplication
{
    public class InitializeFoods
    {
        private const int k_DrinkTypePosition = 1;
        private const int k_AppetizerTypePosition = 2;
        private const int k_SaladTypePosition = 3;
        private const int k_MainDishTypePosition = 4;
        private const int k_HamburgerTypePosition = 5;
        private const int k_SideDishTypePosition = 6;
        private const int k_DessertTypePosition = 7;

        public static Drink InitializeDrink(string i_Name, string i_Type, int i_Quantity, string i_SeveralDiner)
        {
            Drink drink = new Drink(i_Name);
            drink.FoodTypePosition = k_DrinkTypePosition;
            drink.Quantity = i_Quantity;
            drink.SetMainTypePositionAndPrice(i_Type);
            drink.SetSecondaryTypePosition(i_Name);

            return drink;
        }

        public static Appetizer InitializeAppetizer(string i_Name, int i_Quantity, string i_SeveralDiner)
        {
            Appetizer appetizer = new Appetizer(i_Name);
            appetizer.FoodTypePosition = k_AppetizerTypePosition;
            appetizer.MainTypePosition = 1;
            appetizer.Quantity = i_Quantity;
            appetizer.SetSecondaryTypePositionAndPrice(i_Name);

            return appetizer;
        }

        public static Salad InitializeSalad(string i_Name, int i_Quantity, string i_SeveralDiner)
        {
            Salad salad = new Salad(i_Name);
            salad.FoodTypePosition = k_SaladTypePosition;
            salad.MainTypePosition = 1;
            salad.Quantity = i_Quantity;
            salad.SetSecondaryTypePositionAndPrice(i_Name);

            return salad;
        }

        public static MainDish InitializeMainDish(string i_Name, int i_Quantity, string i_SeveralDiner)
        {
            MainDish mainDish = new MainDish(i_Name);
            mainDish.FoodTypePosition = k_MainDishTypePosition;
            mainDish.MainTypePosition = 1;
            mainDish.Quantity = i_Quantity;
            mainDish.SetSecondaryTypePositionAndPrice(i_Name);

            return mainDish;
        }

        public static Hamburger Initialize_Hamburger(string i_Name, string i_Type, int i_Quantity, string i_SeveralDiner)
        {
            Hamburger hamburger = new Hamburger(i_Name, i_Type);
            hamburger.FoodTypePosition = k_HamburgerTypePosition;
            hamburger.Quantity = i_Quantity;
            hamburger.SetMainTypePositionAndPrice(i_Type);
            hamburger.SetSecondaryTypePosition(i_Name);

            return hamburger;
        }

        public static SideDish InitializeSideDish(string i_Name, int i_Quantity, string i_SeveralDiner)
        {
            SideDish sideDish = new SideDish(i_Name);
            sideDish.FoodTypePosition = k_SideDishTypePosition;
            sideDish.MainTypePosition = 1;
            sideDish.Quantity = i_Quantity;
            sideDish.SetSecondaryTypePositionAndPrice(i_Name);


            return sideDish;
        }

        public static Dessert InitializeDessert(string i_Name, int i_Quantity, string i_SeveralDiner)
        {
            Dessert dessert = new Dessert(i_Name);
            dessert.FoodTypePosition = k_DessertTypePosition;
            dessert.MainTypePosition = 1;
            dessert.Quantity = i_Quantity;
            dessert.SetSecondaryTypePositionAndPrice(i_Name);

            return dessert;
        }
    }
}
