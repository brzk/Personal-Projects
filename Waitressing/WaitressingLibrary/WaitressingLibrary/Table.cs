using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitressingLibrary
{
    public class Table
    {
        static int i = 0;
        int value;

        public Table()
        {
            value = i;
            i++;
        }

        public void print()
        {
            Console.WriteLine(value);
        }
    }

    

}
