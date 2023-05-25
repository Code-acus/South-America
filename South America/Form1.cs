using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            try
            {
                string countryName;
                StreamReader inputFile;
                inputFile = File.OpenText("Countries.txt");
                countriesListBox.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    countryName = inputFile.ReadLine();
                    countriesListBox.Items.Add(countryName);
                }

                inputFile.Close(); // Close the file outside the while loop
            }
            catch
            {
                MessageBox.Show("An error occurred.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Handle the exit button click event here
            // For example:
            this.Close(); // Close the form
        }
    }
}

