using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitressingConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {

            Drink d = InitializeFoods.InitializeDrink("Cola", "Soda", 3, "4");
            Drink d1 = InitializeFoods.InitializeDrink("Apple", "Soft", 3, "4");
            Drink d2 = InitializeFoods.InitializeDrink("Water", "Soft", 3, "4");
            Drink d3 = InitializeFoods.InitializeDrink("Cola", "Soda", 3, "4");
            Drink d4 = InitializeFoods.InitializeDrink("Sprite", "Soda", 3, "4");
            Drink d5 = InitializeFoods.InitializeDrink("Apple", "Soft", 3, "4");
            Drink d6 = InitializeFoods.InitializeDrink("Water", "Soft", 3, "4");
            Hamburger h = InitializeFoods.Initialize_Hamburger("MW", "Regular", 2, "5");
            Hamburger h1 = InitializeFoods.Initialize_Hamburger("M", "Small", 3, "5");
            Hamburger h2 = InitializeFoods.Initialize_Hamburger("R", "Regular", 1, "5");

            Appetizer a = InitializeFoods.InitializeAppetizer("ChickenWings", 5, "6");
            Dessert d7 = InitializeFoods.InitializeDessert("ChocolateCake", 5, "4");
            MainDish m = InitializeFoods.InitializeMainDish("Schnitzel", 4, "3");
            Salad s = InitializeFoods.InitializeSalad("CeasarSalad", 3, "1");
            SideDish sd = InitializeFoods.InitializeSideDish("Soup", 6, "2");
            SideDish sd1 = InitializeFoods.InitializeSideDish("Rice", 6, "2");


            Order order = new Order();
            order.m_OrderList.Add(d7);
            order.m_OrderList.Add(a);
            order.m_OrderList.Add(m);
            order.m_OrderList.Add(sd1);
            order.m_OrderList.Add(s);
            order.m_OrderList.Add(sd);

            order.m_OrderList.Add(d);
            order.m_OrderList.Add(d1);
            order.m_OrderList.Add(h2);
            order.m_OrderList.Add(d2);
            order.m_OrderList.Add(d3);
            order.m_OrderList.Add(h);
            order.m_OrderList.Add(d4);
            order.m_OrderList.Add(d5);
            order.m_OrderList.Add(h1);
            order.m_OrderList.Add(d6);

            for (int i = 0; i < order.m_OrderList.Count; i++)
                Console.WriteLine(order.m_OrderList[i].ToString());

            Console.WriteLine();

            order.SortOrder();
            for (int i = 0; i < order.m_OrderList.Count; i++)
                Console.WriteLine(order.m_OrderList[i].ToString());

            Console.WriteLine();


            order.m_OrderList = order.ShrinkOrder();
            for (int i = 0; i < order.m_OrderList.Count; i++)
                Console.WriteLine(order.m_OrderList[i].ToString());

            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
