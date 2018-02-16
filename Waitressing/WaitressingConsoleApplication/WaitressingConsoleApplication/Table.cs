using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitressingConsoleApplication
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
