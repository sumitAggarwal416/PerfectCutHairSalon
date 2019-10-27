/*
 * I, Sumit Aggarwal, 000793607, certify that all code submitted is my own code and I have not copied it from anywhere. I also certify that I have not allowed
 * anyone else to copy my code.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perfect_Cut_Hair_Salon
{
    public partial class Form1 : Form
    {
        List<Hairdresser> hairdresser; // list of all the hairdressers
        List<Services> services; // list of all the services 
        public Form1()
        {
            hairdresser = new List<Hairdresser>();
            hairdresser.Add(new Hairdresser("Jane", 30.00)); // adds new item to the list
            hairdresser.Add(new Hairdresser("Pat", 45.00));
            hairdresser.Add(new Hairdresser("Ron", 40.00));
            hairdresser.Add(new Hairdresser("Sue", 50.00));
            hairdresser.Add(new Hairdresser("Laurie", 55.00));

            services = new List<Services>();
            services.Add(new Services("Cut", 30.00));
            services.Add(new Services("Wash, blow-dry, and style", 20.00));
            services.Add(new Services("Colour", 40.00));
            services.Add(new Services("Highlights", 50.00));
            services.Add(new Services("Extension", 200.00));
            services.Add(new Services("Up-do", 60.00));   

            InitializeComponent();
        }

        /// <summary>
        /// Updates the charged items list box whenever a new value is selected from the combobox
        /// It accordingly updates the price list box as well, depending upon which hairdresser is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HairdresserComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargedItemsListBox.Items.Add(hairdresser[hairdresserComboBox.SelectedIndex].Name);
            priceListBox.Items.Add("$" + hairdresser[hairdresserComboBox.SelectedIndex].Price);
            serviceListBox.Enabled = true; //enables the list box and allows the user to select items
            hairdresserComboBox.Enabled = false; // disables the combo box so that the user cannot change the hairdresser once selected
            addServiceButton.Enabled = true; // enables the button so that the user can add the services they need
            
        }

        /// <summary>
        /// adds the services selected by the user to the charged items list box
        /// also, adds the price to the price list box depending upon which service is selected and how many times it is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            foreach (Services s in services) // iterates throughout the services list and adds the service if the user has selected that
            {
                if(serviceListBox.SelectedItems.Contains(s.Description))
                    chargedItemsListBox.Items.Add(s.Description);
            }

            //adds the price of the service to the price list box, no matter how many times is a service selected

            if (serviceListBox.SelectedItems.Contains("Cut"))
                priceListBox.Items.Add("$30");
            if (serviceListBox.SelectedItems.Contains("Wash, blow-dry, and style"))
                priceListBox.Items.Add("$20");
            if (serviceListBox.SelectedItems.Contains("Colour"))
                priceListBox.Items.Add("$40");
            if (serviceListBox.SelectedItems.Contains("Highlights"))
                priceListBox.Items.Add("$50");
            if (serviceListBox.SelectedItems.Contains("Extension"))
                priceListBox.Items.Add("$200");
            if (serviceListBox.SelectedItems.Contains("Up-do"))
                priceListBox.Items.Add("$60");

            totalPriceButton.Enabled = true;
        }

        /// <summary>
        /// exits the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// resets the program and sets the focus to hairdresser combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            hairdresserComboBox.Enabled = true;
            chargedItemsListBox.Items.Clear();
            priceListBox.Items.Clear();
            addServiceButton.Enabled = false;
            totalPriceButton.Enabled = false;
            totalPriceTextBox.Text = " ";
            hairdresserComboBox.Focus();
            serviceListBox.Enabled = false;
            serviceListBox.SelectedIndex = -1;

        }

        /// <summary>
        /// calculates the total price of services selected by the user and displays it in the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TotalPriceButton_Click(object sender, EventArgs e)
        {
            List<double> totalPrice = new List<double>();
            foreach (string s in priceListBox.Items) //iterates through all the string values of the list box and adds them to the list after parsing them to a double value
            {
                totalPrice.Add(double.Parse(s.Substring(1)));
            }

            int sum = totalPrice.Sum(x => Convert.ToInt32(x)); //converts the double value to a 32-bit integer value for easy calculation
            totalPriceTextBox.Text = "$"+sum;
                
        }
    }
}
