using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarOwnershipCost
{
    class CarCost
    {
        // How many	years plan to use the Car
        double useInyears;
        //How much	to	pay	to	purchase the Car
        double carPrice;
        //Average Insurance	Cost per year
        double carInsurance;
        // Average	Repair Cost per year
        double carRepair;


        //Constructor
        public CarCost(double useYears, double carPrice, double carInsurance, double carRepair)
        {
            this.useInyears = useYears;
            this.carPrice = carPrice;
            this.carInsurance = carInsurance;
            this.carRepair = carRepair;
        }
        
        //Method for calculating Total Cost for using car, Returns double
        public double calculateAverageTotal()
        {
            double result = this.carPrice + (this.carInsurance * this.useInyears) + (this.carRepair * this.useInyears);
            //Round up result to two digits and return value;
            return Math.Round(result, 2);
        }

        //Method for calculating cost for using car per year, Returns double
        public double calculateCostPerYear()
        {
            double result = (this.carPrice / this.useInyears) + this.carInsurance + this.carRepair;
            //Round up result to two digits and return value;
            return Math.Round(result, 2);
        }

        //Method for calculating cost for using car per mouth, Returns double
        public double calculateCostPerMouth()
        {
            double result = calculateCostPerYear() / 12;
            //Round up result to two digits and return value;
            return Math.Round(result, 2);
        }

        //Method for calculating cost for using car per day, Returns double
        public double calculateCostPerDay()
        {

            double result = calculateCostPerYear() / 365;
            //Round up result to two digits and return value;
            return Math.Round(result, 2);
        }
    }
}
