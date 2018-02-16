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
    public partial class Drinks : Form
    {
        bool isQuntiy = false;
        bool isSeveralDiner = false;
        ListBox.SelectedIndexCollection selectedListBox;

        public Drinks()
        {
            InitializeComponent();
            selectedListBox = currentListBox.SelectedIndices;
        }

        private void colaButton_Click(object sender, EventArgs e)
        {
            createDrink("Cola", "Soda");
        }

        private void spriteButton_Click(object sender, EventArgs e)
        {
            createDrink("Sprite", "Soda");
        }

        private void FantaButton_Click(object sender, EventArgs e)
        {
            createDrink("Fanta", "Soda");
        }

        private void waterButton_Click(object sender, EventArgs e)
        {
            createDrink("Water", "Soft");
        }

        private void appleButton_Click(object sender, EventArgs e)
        {
            createDrink("Apple", "Soft");
        }

        private void orangeButton_Click(object sender, EventArgs e)
        {
            createDrink("Orange", "Soft");
        }

        private void createDrink(string i_Name, string i_Type)
        {
            if (severalDinerText.Text == "")
            {
                errorText.Text = "Several Diner Has Not Been Chosen Yet!";
            }
            else if (quantityText.Text == "")
            {
                errorText.Text = "Quantity Has Not Been Chosen Yet!";
            }
            else
            {
                Drink drink = InitializeFoods.InitializeDrink(i_Name, i_Type, Int32.Parse(quantityText.Text), severalDinerText.Text);
                showDrink(drink);
            }
        }

        private void showDrink(Drink i_Drink)
        {
            // Table1.table1Order.m_OrderList.Add(i_Drink);
            errorText.Text = "";
            quantityText.Text = "";
            severalDinerText.Text = "";
            //currentListBox.Items.Insert(lastPositionOfDrink, i_Drink);
            currentListBox.Items.Insert(currentListBox.Items.Count, i_Drink);
        }

        private void quantityButton_Click(object sender, EventArgs e)
        {
            isQuntiy = true;
            isSeveralDiner = false;
            errorText.Text = "";
        }

        private void severalDinerButton_Click(object sender, EventArgs e)
        {
            isSeveralDiner = true;
            isQuntiy = false;
            errorText.Text = "";
        }

        private void oneDigitButton_Click(object sender, EventArgs e)
        {
            showDigit(1);
        }

        private void twoDigitButton_Click(object sender, EventArgs e)
        {
            showDigit(2);
        }

        private void threeDigitButton_Click(object sender, EventArgs e)
        {
            showDigit(3);
        }

        private void fourDigitButton_Click(object sender, EventArgs e)
        {
            showDigit(4);
        }

        private void fiveDigitButton_Click(object sender, EventArgs e)
        {
            showDigit(5);
        }

        private void sixDigitButton_Click(object sender, EventArgs e)
        {
            showDigit(6);
        }

        private void sevenDigitButton_Click(object sender, EventArgs e)
        {
            showDigit(7);
        }

        private void eightDigitButton_Click(object sender, EventArgs e)
        {
            showDigit(8);
        }

        private void nineDigitButton_Click(object sender, EventArgs e)
        {
            showDigit(9);
        }

        private void zeroDigitButton_Click(object sender, EventArgs e)
        {
            showDigit(0);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (isQuntiy)
            {
                string text = quantityText.Text;
                quantityText.Text = (text.Length == 0) ? "" : text.Substring(0, text.Length - 1);
            }
            else if (isSeveralDiner)
            {
                string text = severalDinerText.Text;
                severalDinerText.Text = (text.Length == 0) ? "" : text.Substring(0, text.Length - 1);
            }
        }

        private void showDigit(int i_Digit)
        {
            if (isQuntiy)
            {
                quantityText.Text = string.Format("{0}{1}", quantityText.Text, i_Digit);
            }
            else if (isSeveralDiner)
            {
                severalDinerText.Text = string.Format("{0}{1}", severalDinerText.Text, i_Digit);
            }
            else
            {
                errorText.Text = "Several Diner Or Quantity Has Not Been Chosen Yet!";
            }
        }

        private void listBoxDeletebutton_Click(object sender, EventArgs e)
        {
            // remove all the selected lines/objects from llistbox
            while (selectedListBox.Count > 0)
            {
                currentListBox.Items.RemoveAt(selectedListBox[selectedListBox.Count - 1]);
            }
        }

        private void returnToTableButton_Click(object sender, EventArgs e)
        {
            isQuntiy = false;
            isSeveralDiner = false;
            Table table = Tables.tablesDictionary[Table.CurrentTable];

            // convert the current listbox to list
            List<Food> currentistBox = new List<Food>();
            currentistBox = currentListBox.Items.OfType<Food>().ToList();

            // add the converted current listbox (now list) to the table list
            Table.tableOrder.m_OrderList.AddRange(currentistBox);

            // // add the current listbox to the table listbox
            table.CurrentListBox.Items.AddRange(currentListBox.Items);

            // clear the current listbox
            currentListBox.Items.Clear();

            table.Show();
            this.Hide();
        }
    }
}
