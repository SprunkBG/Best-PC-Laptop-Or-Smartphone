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
    class SmartphoneConfigurations
    {

        public static void BudgetLev(double budget)
        {
            if (budget < 0)
            {
                MessageBox.Show("What are you trying to do?");
            }
            else if (budget <= 200)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 200.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 200.txt"));
                }
            }
            else if (budget > 200 && budget <= 330)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 330.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 330.txt"));
                }
            }
            else if (budget > 330 && budget <= 500)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 500.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 500.txt"));
                }
            }
            else if (budget > 500 && budget <= 950)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 950.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 950.txt"));
                }
            }
            else if (budget > 950)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone +950.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone +950.txt"));
                }
            }
        }

        public static void BudgetEuro(double budget)
        {
            if (budget < 0)
            {
                MessageBox.Show("What are you trying to do?");
            }
            else if (budget <= 124.92)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 1st euro.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 1st euro.txt"));
                }
            }
            else if (budget > 124.92 && budget <= 206.12)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 2nd euro.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 2nd euro.txt"));
                }
            }
            else if (budget > 206.12 && budget <= 312.30)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 3rd euro.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 3rd euro.xt"));
                }
            }
            else if (budget > 312.30 && budget <= 593.37)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 4th euro.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 4th euro.txt"));
                }
            }
            else if (budget > 593.37)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 5th euro.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 5th euro.txt"));
                }
            }
        }

        public static void BudgetUSDDollar(double budget)
        {
            if (budget < 0)
            {
                MessageBox.Show("What are you trying to do?");
            }
            else if (budget <= 152.63)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 1st dollar.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 1st dollar.txt"));
                }
            }
            else if (budget > 152.63 && budget <= 251.84)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 2nd dollar.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 2nd dollar.txt"));
                }
            }
            else if (budget > 251.84 && budget <= 381.57)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 3rd dollar.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 3rd dollat.txt"));
                }
            }
            else if (budget > 381.57 && budget <= 724.98)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 4th dollar.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 4th dollar.txt"));
                }
            }
            else if (budget > 724.98)
            {
                if (File.Exists(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 5th dollar.txt"))
                {
                    MessageBox.Show(File.ReadAllText(@"C:\Users\User\OneDrive\Работен плот\Visual Studio Files\SchoolProjectConfigurations\smartphone 5th dollar.txt"));
                }
            }
        }

    }
}
