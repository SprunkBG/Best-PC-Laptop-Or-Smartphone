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
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\до990лв.txt"));
                }
            }

            else if (budget >= 990 && budget <= 1400)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\990-1400.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\990-1400.txt"));
                }
            }

            else if (budget >= 1400 && budget <= 1900)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\1400-1900.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\1400-1900.txt"));
                }
            }

            else if (budget >= 1900 && budget <= 2800)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\1900-2800.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\1900-2800.txt"));
                }
            }

            else if (budget > 2800 || budget > 2800)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\2800+.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\2800+.txt"));
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
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\1st euro.txt"));
                }
            }
            else if (budget > 505.99 && budget <= 715.54)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\2nd euro.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\2nd euro.txt"));
                }
            }
            else if (budget > 715.54 && budget <= 971.09)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\3rd euro.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\3rd euro.txt"));
                }
            }
            else if (budget > 971.09 && budget <= 1431.08)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\4th euro.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\4th euro.txt"));
                }
            }
            else if (budget > 1431.08)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\5th euro.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\5th euro.txt"));
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
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\1st dollar.txt"));
                }
            }
            else if (budget > 623.53 && budget <= 881.76)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\2nd dollar.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\2nd dollar.txt"));
                }
            }
            else if (budget > 881.76 && budget <= 1196.67)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\3rd dollar.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\3rd dollar.txt"));
                }
            }
            else if (budget > 1196.67 && budget <= 1763.52)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\4th dollar.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\4th dollar.txt"));
                }
            }
            else if (budget > 1763.52)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\5th dollar.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\5th dollar.txt"));
                }

            }
        }

    }
}
