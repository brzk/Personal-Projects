using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitressingLibrary
{
    public class Food
    {
        protected int[] m_ProductPositions;
        protected readonly string r_Name;

        public Food(string i_Name)
        {
            r_Name = i_Name;
            m_ProductPositions = new int[5];
        }

        public int FoodTypePosition
        {
            get { return m_ProductPositions[0]; }
            set { m_ProductPositions[0] = value; }
        }

        public int MainTypePosition
        {
            get { return m_ProductPositions[1]; }
            set { m_ProductPositions[1] = value; }
        }

        public int SecondaryTypePosition
        {
            get { return m_ProductPositions[2]; }
            set { m_ProductPositions[2] = value; }
        }

        public int Quantity
        {
            get { return m_ProductPositions[3]; }
            set { m_ProductPositions[3] = value; }
        }

        public int Price
        {
            get { return m_ProductPositions[4]; }
            set { m_ProductPositions[4] = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}",r_Name ,FoodTypePosition, MainTypePosition, SecondaryTypePosition, Quantity, Price);
        }
    }
}
