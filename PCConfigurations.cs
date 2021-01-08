using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SchoolProjectConfigurations
{
    class PCConfigurations
    {
        public static void BudgetLev(double budget)
        {
            if (budget <= 0)
            {
                MessageBox.Show("What are you trying to do?");
            }
            else if (budget <= 990)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\до990лв.txt"))
                {
                    string budget990 = File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\до990лв.txt");
                    MessageBox.Show(budget990);
                }
            }

            else if (budget >= 990 && budget <= 1400)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\990-1400.txt"))
                {
                    string budget1400 = File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\990-1400.txt");
                    MessageBox.Show(budget1400);
                }
            }

            else if (budget >= 1400 && budget <= 1900)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\1400-1900.txt"))
                {
                    string budget1900 = File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\1400-1900.txt");
                    MessageBox.Show(budget1900);
                }
            }

            else if (budget >= 1900 && budget <= 2800)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\1900-2800.txt"))
                {
                    string budget2800 = File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\1900-2800.txt");
                    MessageBox.Show(budget2800);
                }
            }

            else if (budget > 2800 || budget > 2800)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\2800+.txt"))
                {
                    string budgetOver2800 = File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\2800+.txt");
                    MessageBox.Show(budgetOver2800);
                }
            }
        }

        public static void BudgetEuro(double budget)
        {
            if (budget <= 0)
            {
                MessageBox.Show("What are you trying to do?");
            }
            else if (budget <= 505.99)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\1st euro.txt"))
                {
                    string budget505 = File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\1st euro.txt");
                    MessageBox.Show(budget505);
                }
            }
            else if (budget > 505.99 && budget <= 715.54)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\2nd euro.txt"))
                {
                    string budget715 = File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\2nd euro.txt");
                    MessageBox.Show(budget715);
                }
            }
            else if (budget > 715.54 && budget <= 971.09)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\3rd euro.txt"))
                {
                    string budget971 = File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\3rd euro.txt");
                    MessageBox.Show(budget971);
                }
            }
            else if (budget > 971.09 && budget <= 1431.08)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\4th euro.txt"))
                {
                    string budget1431 = File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\4th euro.txt");
                    MessageBox.Show(budget1431);
                }
            }
            else if (budget > 0 || budget > 1431.08)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\5th euro.txt"))
                {
                    string budget14 = File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\5th euro.txt");
                    MessageBox.Show(budget14);
                }

            }
        }

        public static void BudgetUSDDollar(double budget)
        {
            if (budget <= 0)
            {
                MessageBox.Show("What are you trying to do?");
            }
            else if (budget <= 623.53)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\1st dollar.txt"))
                {
                    string budget623 = File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\1st dollar.txt");
                    MessageBox.Show(budget623);
                }
            }
            else if (budget > 623.53 && budget <= 881.76)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\2nd dollar.txt"))
                {
                    string budget881 = File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\2nd dollar.txt");
                    MessageBox.Show(budget881);
                }
            }
            else if (budget > 881.76 && budget <= 1196.67)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\3rd dollar.txt"))
                {
                    string budget1196 = File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\3rd dollar.txt");
                    MessageBox.Show(budget1196);
                }
            }
            else if (budget > 1196.67 && budget <= 1763.52)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\4th dollar.txt"))
                {
                    string budget1763 = File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\4th dollar.txt");
                    MessageBox.Show(budget1763);
                }
            }
            else if (budget > 1763.52)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\5th dollar.txt"))
                {
                    string budget17 = File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\5th dollar.txt");
                    MessageBox.Show(budget17);
                }

            }
        }

    }
}
