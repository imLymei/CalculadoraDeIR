using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Employee
    {
        public string CPF { get; set; }
        public string Name { get; set; }
        public float DailyPrice { get; set; }
        public int DaysWorked { get; set; }
        public float BaseWage { get; private set; }
        public double IRTax { get; private set; }
        public double IRTotalTax { get; private set; }

        public Employee(string CPFInput, string nameInput, float dailyPriceInput, int daysWorkedInput)
        {
            CPF = CPFInput;
            Name = nameInput;
            DailyPrice = dailyPriceInput;
            DaysWorked = daysWorkedInput;

            CalculateIR();
            
        }

        private void CalculateIR()
        {
            BaseWage = DailyPrice * DaysWorked;
            IRTax = 0;

            if (BaseWage <= 1903.98)
            {
                IRTax = 0;
            }
            else if (BaseWage <= 2826.65)
            {
                IRTax = 0.075;
            }
            else if (BaseWage <= 3751.05)
            {
                IRTax = 0.15;
            }
            else if (BaseWage <= 4664.68)
            {
                IRTax = 0.225;
            }

            IRTotalTax = BaseWage * IRTax;
        }

    }
}
