using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitressingConsoleApplication
{
    public class Order
    {
        public List<Food> m_OrderList;

        public Order()
        {
            m_OrderList = new List<Food>();
        }

        public void SortOrder()
        {
            int numberOfFoods = m_OrderList.Count;
            for (int i = 0; i < numberOfFoods; i++)
            {
                for (int j = 1; j < numberOfFoods - i; j++)
                {
                    if (m_OrderList[j - 1].SecondaryTypePosition > m_OrderList[j].SecondaryTypePosition)
                    {
                        swap(j, j - 1);
                    }
                }
            }

            for (int i = 0; i < numberOfFoods; i++)
            {
                for (int j = 1; j < numberOfFoods - i; j++)
                {
                    if (m_OrderList[j - 1].MainTypePosition > m_OrderList[j].MainTypePosition)
                    {
                        swap(j, j - 1);
                    }
                }
            }

            for (int i = 0; i < numberOfFoods; i++)
            {
                for (int j = 1; j < numberOfFoods - i; j++)
                {
                    if (m_OrderList[j - 1].FoodTypePosition > m_OrderList[j].FoodTypePosition)
                    {
                        swap(j, j - 1);
                    }
                }
            }
        }

        private void swap(int i_FirstFood, int i_SecondFood)
        {
            Food tempFood = m_OrderList[i_FirstFood];
            m_OrderList[i_FirstFood] = m_OrderList[i_SecondFood];
            m_OrderList[i_SecondFood] = tempFood;
        }

        public List<Food> ShrinkOrder()
        {
            List<Food> newOrderList = new List<Food>();
            newOrderList.Add(m_OrderList[0]);
            int previousPosition = 0;
            int currentPosition = 1;
            int listPosition = 0;

            while (currentPosition < m_OrderList.Count)
            {
                if (isSameFood(m_OrderList[previousPosition], m_OrderList[currentPosition]))
                {
                    newOrderList[listPosition].Quantity += m_OrderList[currentPosition].Quantity;
                }
                else
                {
                    newOrderList.Add(m_OrderList[currentPosition]);
                    previousPosition = currentPosition;
                    listPosition = newOrderList.Count - 1; ;
                }

                currentPosition++;
            }

            return newOrderList;
        }

        public bool isSameFood(Food i_FirstFood, Food i_SecondFood)
        {
            return i_FirstFood.MainTypePosition == i_SecondFood.MainTypePosition &&
                 i_FirstFood.FoodTypePosition == i_SecondFood.FoodTypePosition &&
                 i_FirstFood.SecondaryTypePosition == i_SecondFood.SecondaryTypePosition;

        }
    }
}
