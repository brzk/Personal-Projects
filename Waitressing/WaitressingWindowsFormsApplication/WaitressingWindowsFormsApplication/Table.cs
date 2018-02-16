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
    public partial class Table : Form
    {
        static int currentTable;
        public static Order tableOrder;

        public Table()
        {
            InitializeComponent();
            tableOrder = new Order();
        }

        public string TableNumberlabel
        {
            get { return tableNumberlabel.Text; }
            set { tableNumberlabel.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tables.tables.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void drinksButton_Click(object sender, EventArgs e)
        {
            showTypeOfFood(Tables.drinks);            
        }

        private void appetizerButton_Click(object sender, EventArgs e)
        {
            showTypeOfFood(Tables.appetizers);            
        }
        public static int CurrentTable
        {
            get { return currentTable; }
            set { currentTable = value; }
        }

        public ListBox CurrentListBox
        {
            get { return tableListBox; }
            set { tableListBox = value; }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            // test - sort + shrink the order from table's listbox

            
            tableOrder.m_OrderList = tableListBox.Items.OfType<Food>().ToList();
            tableOrder.SortOrder();
            tableOrder.m_OrderList = tableOrder.ShrinkOrder();
            tableListBox.Items.Clear();

            // return the sorted + shrinked list to the table listbox 
            foreach (Food food in tableOrder.m_OrderList)
            {
                tableListBox.Items.Add(food);
            }
        }

        private void saladsButton_Click(object sender, EventArgs e)
        {
            showTypeOfFood(Tables.salads);
        }

        private void mainDishesButton_Click(object sender, EventArgs e)
        {
            showTypeOfFood(Tables.mainDishes);            
        }

        private void hamburgersButton_Click(object sender, EventArgs e)
        {
            showTypeOfFood(Tables.hamburgers);            
        }

        private void sideDishesButton_Click(object sender, EventArgs e)
        {
            showTypeOfFood(Tables.sideDishes);            
        }

        private void dessertsButton_Click(object sender, EventArgs e)
        {
            showTypeOfFood(Tables.desserts);            
        }

        private void showTypeOfFood(Form i_Form)
        {
            i_Form.Show();
            this.Hide();
        }
    }
}
