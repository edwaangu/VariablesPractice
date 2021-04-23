using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablesPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hockeyButton_Click(object sender, EventArgs e)
        {
            string playerName = "Wayne Gretzky";
            int playerNumber = 99;
            outputText.Text = $"{playerName} is number {playerNumber}";
        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            double radius = 15;
            double pi = 3.1415926;
            double area = pi * radius * radius;
            outputText.Text = $"The area of a circle with a radius of {radius}cm is {area.ToString("0.00")}cm^2";
        }

        private void carpetButton_Click(object sender, EventArgs e)
        {
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = 8.5 * 6;
            double totalCost = area * costPerMeter;
            outputText.Text = $"The area of a room with dimensions {length}m x {width}m is {area}m^2";
            outputText.Text += $"The cost to carpet this area at ${costPerMeter} per square metre is ${totalCost.ToString("0.00")}";
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            double shirtCost = 12.49;
            double payment = 20;
            double tax = shirtCost * 0.13;
            double total = shirtCost + tax;
            double change = payment - total;

            outputText.Text = $"Bill of Sale";
            outputText.Text += $"\n\nShirt:      {shirtCost}";
            outputText.Text += $"\n\nTax:        {tax.ToString("0.00")}";
            outputText.Text += $"\nTotal:      {total.ToString("0.00")}";
            outputText.Text += $"\n\nTendered:   {payment}";
            outputText.Text += $"\nChange:     {change.ToString("0.00")}";
        }
    }
}
