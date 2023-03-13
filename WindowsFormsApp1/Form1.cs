using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

            Employee Person = new Employee(CPFInput.Text, NameInput.Text, float.Parse(DailyInput.Text), int.Parse(DaysInput.Text));

            WageOutput.Text = Person.BaseWage.ToString();
            IROutput.Text = (Person.IRTotalTax).ToString();
            TotalWageOutput.Text = (Person.BaseWage - Person.IRTotalTax).ToString();
        }
    }
}
