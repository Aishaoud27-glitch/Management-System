using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text;
            int age, days, experience;

            if (string.IsNullOrWhiteSpace(name) ||
                !int.TryParse(txtCustomerAge.Text, out age) ||
                !int.TryParse(txtRentalDays.Text, out days) ||
                !int.TryParse(txtDrivingExperience.Text, out experience))
            {
                MessageBox.Show("Please enter valid information.");
                return;
            }

            if (age < 18 || days <= 0 || experience < 0)
            {
                MessageBox.Show("Please check age, rental days and experience.");
                return;
            }

            double price = 0;

            if (rdoEconomy.Checked)
                price = 30;
            else if (rdoSUV.Checked)
                price = 60;
            else if (rdoLuxury.Checked)
                price = 100;
            else
            {
                MessageBox.Show("Please select vehicle type.");
                return;
            }

            double insurance = chkInsurance.Checked ? 15 * days : 0;
            double total = (price * days) + insurance;

            lstRental.Items.Add("Customer: " + name);
            lstRental.Items.Add("Age: " + age);
            lstRental.Items.Add("Rental Days: " + days);
            lstRental.Items.Add("Driving Experience: " + experience);
            lstRental.Items.Add("Vehicle Price/Day: $" + price);
            lstRental.Items.Add("Insurance: $" + insurance);
            lstRental.Items.Add("Total Amount: $" + total);
            lstRental.Items.Add("-------------------------");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtCustomerAge.Clear();
            txtRentalDays.Clear();
            txtDrivingExperience.Clear();

            rdoEconomy.Checked = false;
            rdoSUV.Checked = false;
            rdoLuxury.Checked = false;
            chkInsurance.Checked = false;

            lstRental.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

