using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitressingLibrary
{
    public class Hamburger : Food
    {
        private static Dictionary<eHamburgersSizes, int> hamburgersSizesNamesTypesDictionary = new Dictionary<eHamburgersSizes, int>()
        {
            {eHamburgersSizes.Small, 1},
            {eHamburgersSizes.Regular, 2},
            {eHamburgersSizes.Big, 3},
            {eHamburgersSizes.Huge, 4}
        };

        private static Dictionary<eHamburgersTypes, int> hamburgersTypesDictionary = new Dictionary<eHamburgersTypes, int>()
        {
            {eHamburgersTypes.R, 1},
            {eHamburgersTypes.MR, 2},
            {eHamburgersTypes.M, 3},
            {eHamburgersTypes.MW, 4},
            {eHamburgersTypes.WD, 5}
        };

        private static Dictionary<eHamburgersSizes, int> hamburgersSizesPriceDictionary = new Dictionary<eHamburgersSizes, int>()
        {
            {eHamburgersSizes.Small, 45},
            {eHamburgersSizes.Regular, 50},
            {eHamburgersSizes.Big, 60},
            {eHamburgersSizes.Huge, 70}
        };

        string r_Type;

        public Hamburger(string i_Name, string i_Type) : base(i_Name)
        {
            r_Type = i_Type;
        }

        internal void SetMainTypePositionAndPrice(string i_Type)
        {
            eHamburgersSizes hamburgersSizes = ((eHamburgersSizes)Enum.Parse(typeof(eHamburgersSizes), i_Type));
            MainTypePosition = hamburgersSizesNamesTypesDictionary[hamburgersSizes];
            Price = hamburgersSizesPriceDictionary[hamburgersSizes];            
        }

        internal void SetSecondaryTypePosition(string i_Name)
        {
            SecondaryTypePosition = hamburgersTypesDictionary[((eHamburgersTypes)Enum.Parse(typeof(eHamburgersTypes), i_Name))];
        }
        public override string ToString()
        {
            return String.Format("{0,-8} {1,-2} {2,-5} {3,-5}{4,-5}", "Hamburger", ((int)Enum.Parse(typeof(eHamburgersSizes), r_Type)), r_Name, Quantity, Price);
        }

        private enum eHamburgersSizes
        {
            Small,
            Regular,
            Big,
            Huge
        };

        private enum eHamburgersTypes
        {
            R,
            MR,
            M,
            MW,
            WD
        };
    }
}
