using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitressingLibrary
{
    public class Appetizer : Food
    {
        private static Dictionary<eAppetizerTypes, int> appetizersTypeDictionary = new Dictionary<eAppetizerTypes, int>()
        {
            {eAppetizerTypes.ChickenWings, 1},
            {eAppetizerTypes.ChickenNuggets, 2},
            {eAppetizerTypes.ChickenSkewers, 3}
        };

        private static Dictionary<eAppetizerTypes, int> appetizersPriceDictionary = new Dictionary<eAppetizerTypes, int>()
        {
            {eAppetizerTypes.ChickenWings, 31},
            {eAppetizerTypes.ChickenNuggets, 30},
            {eAppetizerTypes.ChickenSkewers, 35}
        };

        public Appetizer(string i_Name) : base(i_Name)
        {
        }

        public override string ToString()
        {
            return String.Format("{0,-20}     |       {1,-5}{2,-5}", r_Name, Quantity, Price);
        }

        public void SetSecondaryTypePositionAndPrice(string i_Name)
        {
            eAppetizerTypes appetizerType = ((eAppetizerTypes)Enum.Parse(typeof(eAppetizerTypes), i_Name));
            SecondaryTypePosition = appetizersTypeDictionary[appetizerType];
            Price = appetizersPriceDictionary[appetizerType];
        }       

        private enum eAppetizerTypes
        {
            ChickenWings,
            ChickenNuggets,
            ChickenSkewers
        };
    }
}
