using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubtitlesNameApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            //if (dictionaryTextBox.Text == "" || VideoNameTextBox.Text == "")
            if (dictionaryTextBox.Text == "")
            {
                MessageBox.Show("enter dictonary or video name");
            }
            else
            {
                EditDirectory.ConvertSubtitlesNameFromMoviesName(dictionaryTextBox.Text);
                //ChangeSubtitles.change(dictionaryTextBox.Text, VideoNameTextBox.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dictionaryTextBox.Text == "")
            {
                MessageBox.Show("enter dictonary");
            }
            else
            {
                EditDirectory.ShiftSubtitlesFiles(dictionaryTextBox.Text, 0, 0, 1, 000, true);
                //ChangeSubtitles.change(dictionaryTextBox.Text, VideoNameTextBox.Text);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dictionaryTextBox.Text == "" || editSubtitleFileTextBox.Text == "" || sourceSubtitleFileTextBox.Text == "")
            {
                MessageBox.Show("enter dictonary or subtitles files name");
            }
            else
            {
                EditDirectory.CopySubtitlesTimeToOtherFiles(dictionaryTextBox.Text, editSubtitleFileTextBox.Text, sourceSubtitleFileTextBox.Text);
                //ChangeSubtitles.change(dictionaryTextBox.Text, VideoNameTextBox.Text);
            }
        }
    }
}
