using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace SchoolProjectConfigurations
{
    class UserSettings
    {
        public static void Greeting(string user)
        {
            MessageBox.Show($"Welcome {user}! This program will find the best device for your budget.");
        }

        public static void SelectCurrency(char currency)
        {
            if (currency == 'l')
            {
                double budget = Double.Parse(Interaction.InputBox("How much is your budget?"));
                PCConfigurations.BudgetLev(budget);
            }
            else if (currency == 'e')
            {
                double budget = Double.Parse(Interaction.InputBox("How much is your budget?"));
                PCConfigurations.BudgetEuro(budget);
            }
            else if (currency == 'd')
            {
                double budget = Double.Parse(Interaction.InputBox("How much is your budget?"));
                PCConfigurations.BudgetUSDDollar(budget);
            }
        }
    }
}
