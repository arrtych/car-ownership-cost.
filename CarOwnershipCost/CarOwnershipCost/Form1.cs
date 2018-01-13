using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarOwnershipCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void calculatorBtn_Click(object sender, EventArgs e)
        {
            //Get value from NumericUpDown and put it to int variable
            int UseInYears = Convert.ToInt32(useInYears.Value);
            //Get value from textbox and put it to double variable
            double CarPrice = double.Parse(carPrice.Text);
            //Get value from textbox and put it to double variable
            double CarInsurance = double.Parse(carInsurance.Text);
            //Get value from textbox and put it to double variable
            double CarRepair = double.Parse(carRepair.Text);

            //Create object with input data from Form
            CarCost car = new CarCost(UseInYears, CarPrice, CarInsurance, CarRepair);

            //Calculate total cost result and put it to double variable
            double resultTotal = car.calculateAverageTotal();
            //Calculate Cost Per Year and put it to double variable
            double resultPerYear = car.calculateCostPerYear();
            //Calculate Cost Per Mouth and put it to double variable
            double resultPerMouth = car.calculateCostPerMouth();
            //Calculate Cost Per Day and put it to double variable
            double resultPerDay = car.calculateCostPerDay();

            //Put all calculations to button text
            calculatorBtn.Text = "AT: " + resultTotal.ToString() +
                                 " | 1Y: " + resultPerYear.ToString() +
                                 " | 1M: " + resultPerMouth.ToString() +
                                 " | 1D: " + resultPerDay.ToString();


        }
    }
}
