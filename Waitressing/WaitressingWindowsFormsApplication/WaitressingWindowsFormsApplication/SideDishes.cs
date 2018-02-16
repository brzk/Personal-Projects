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
    public partial class SideDishes : Form
    {
        bool isQuntiy = false;
        bool isSeveralDiner = false;
        ListBox.SelectedIndexCollection selectedListBox;

        public SideDishes()
        {
            InitializeComponent();
            selectedListBox = currentListBox.SelectedIndices;
        }

        private void friesButton_Click(object sender, EventArgs e)
        {
            createSideDish("Fries");
        }

        private void mashedButton_Click(object sender, EventArgs e)
        {
            createSideDish("Mashed");
        }

        private void onionRingsButton_Click(object sender, EventArgs e)
        {
            createSideDish("OnionRings");
        }

        private void riceButton_Click(object sender, EventArgs e)
        {
            createSideDish("Rice");
        }

        private void soupButton_Click(object sender, EventArgs e)
        {
            createSideDish("Soup");
        }

        private void saladButton_Click(object sender, EventArgs e)
        {
            createSideDish("Salad");
        }

        private void createSideDish(string i_Name)
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
                SideDish sideDish = InitializeFoods.InitializeSideDish(i_Name, Int32.Parse(quantityText.Text), severalDinerText.Text);                
                showSideDish(sideDish);
            }
        }

        private void showSideDish(SideDish i_SideDish)
        {            
            errorText.Text = "";
            quantityText.Text = "";
            severalDinerText.Text = "";         
            currentListBox.Items.Insert(currentListBox.Items.Count, i_SideDish);
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
