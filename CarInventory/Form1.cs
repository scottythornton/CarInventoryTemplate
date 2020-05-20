using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarInventory
{
    public partial class Form1 : Form
    {
        List<Car> carsList = new List<Car>();
        //List<save> saveList = new List<save>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string make, colour, mileage, year;

            year = yearInput.Text;
            make = makeInput.Text;
            mileage = mileageInput.Text;
            colour = colourInput.Text;

            Car c = new Car(year, make, colour, mileage);

            carsList.Add(c);

            outputLabel.Text = "";

            //for (int i = 0; i < carsList.Count; i++)
            //{
            //    outputLabel.Text += carsList[i].year + " " + carsList[i].make + " " + carsList[i].colour + " " + carsList[i].mileage + "\n";
            //}

            foreach(Car car in carsList)
            {
                outputLabel.Text = c.year + " " + c.make + " " + c.colour + " " + c.mileage + "\n";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
