using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WaitressingWindowsFormsApplication
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Tables.tables = new Tables();
            Tables.table1 = new Table();
            Tables.table2 = new Table();
            Tables.table3 = new Table();
            Tables.table4 = new Table();
            Tables.table5 = new Table();
            Tables.table6 = new Table();

            Tables.tablesDictionary = new Dictionary<int, Table>()
        {
            { 1, Tables.table1},
            { 2,Tables.table2},
            { 3,Tables.table3},
            { 4,Tables.table4},
            { 5,Tables.table5},
            { 6,Tables.table6}
        };

            Tables.drinks = new Drinks();
            Tables.appetizers = new Appetizers();
            Tables.desserts = new Desserts();
            Tables.hamburgers = new Hamburgers();
            Tables.mainDishes = new MainDishes();
            Tables.salads = new Salads();
            Tables.sideDishes = new SideDishes();
            Application.Run(Tables.tables);
        }
    }
}
