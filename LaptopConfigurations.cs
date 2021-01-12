using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace SchoolProjectConfigurations
{
    class LaptopConfigurations
    {

        public static void BudgetLev(double budget)
        {
            if (budget <= 0)
            {
                MessageBox.Show("What are you trying to do?");
            }
            else if (budget <= 1800)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop1800.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop1800.txt"));
                }
            }
            else if (budget > 1800 && budget <= 2400)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop2400.txt"))
                {
                    MessageBox.Show(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop2400.txt");
                }
            }
            else if (budget > 2400 && budget <= 3000)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop3000.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop3000.txt"));
                }
            }
            else if (budget > 3000 && budget <= 4200)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop4200.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop4200.txt"));
                }
            }
            else if (budget > 4200)
            {
                MessageBox.Show("Sorry for this, the program will be updated!");
            }
        }

        public static void BudgetEuro(double budget)
        {
            if (budget < 0)
            {
                MessageBox.Show("What are you trying to do?");
            }
            else if (budget <= 919.98)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop 1st euro.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop 1st euro.txt"));
                }
            }
            else if (budget > 919.98 && budget <= 1226.64)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop 2nd euro.txt"))
                {
                    MessageBox.Show(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop 2nd euro.txt");
                }
            }
            else if (budget > 1226.64 && budget <= 1533.30)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop 3rd euro.txt"))
                {
                    MessageBox.Show(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop 3rd euro.txt");
                }
            }
            else if (budget > 1533.30 && budget <= 2146.62)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop 4th euro.txt"))
                {
                    MessageBox.Show(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop 4th euro.txt");
                }
            }
            else if (budget > 2146.62)
            {
                MessageBox.Show("Sorry for this, the program will be updated!");
            }
        }

        public static void BudgetUSDDollar(double budget)
        {
            if (budget <= 0)
            {
                MessageBox.Show("What are you trying to do?");
            }
            else if (budget <= 1124.28)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop 1st dollat.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop 1st dollat.txt"));
                }
            }
            else if (budget > 1124.28 && budget <= 1499.04)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop 2nd dollar.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop 2nd dollar.txt"));
                }
            }
            else if (budget > 1499.04 && budget <= 1873.80)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop 3rd dollar.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop 3rd dollar.txt"));
                }
            }
            else if (budget > 1873.80 && budget <= 2623.32)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop 4th dollar.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\laptop 4th dollar.txt"));
                }
            }
            else if (budget > 2633.32)
            {
                MessageBox.Show("Sorry for this, the program will be updated!");
            }
        }
    }
}
