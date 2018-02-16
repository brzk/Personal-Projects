using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaitressingLibrary;

namespace WaitressingWindowsFormsApplication
{
    public partial class Tables : Form
    {
        public static Tables tables;
        public static Table table1;
        public static Table table2;
        public static Table table3;
        public static Table table4;
        public static Table table5;
        public static Table table6;
                
        public static Appetizers appetizers;
        public static Desserts desserts;
        public static Drinks drinks;
        public static Hamburgers hamburgers;
        public static MainDishes mainDishes;        
        public static Salads salads;
        public static SideDishes sideDishes;
        
        public static Dictionary<int, Table> tablesDictionary;






        public Tables()
        {
            InitializeComponent();
        }

        private void table1button_Click(object sender, EventArgs e)
        {
            showTableText(table1, 1);
        }

        private void table2button_Click(object sender, EventArgs e)
        {
            showTableText(table2, 2);
        }

        private void table3button_Click(object sender, EventArgs e)
        {
            showTableText(table3, 3);
        }

        private void table4button_Click(object sender, EventArgs e)
        {
            showTableText(table4, 4);
        }

        private void table5button_Click(object sender, EventArgs e)
        {
            showTableText(table5, 5);
        }

        private void table6button_Click(object sender, EventArgs e)
        {
            showTableText(table6, 6);
        }

        private void showTableText(Table i_Table, int i_TableNumber)
        {
            Table.CurrentTable = i_TableNumber;
            i_Table.TableNumberlabel = string.Format("Table {0}", i_TableNumber);
            i_Table.Show();
            this.Hide();

        }
    }
}
