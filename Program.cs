using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SchoolProjectConfigurations
{
    class Program
    {

        public static void Username()
        {
            string user = Interaction.InputBox("How should we call You?");
            UserSettings.Greeting(user);
        }

        public static void Device()
        {
            string device = Interaction.InputBox($"Pick a device You want to buy: \n 1) PC \n 2) Laptop \n 3) Smartphone");
            UserDevice.ChooseDevice(device);
        }

        public static void EndAdvertisement()
        {
            MessageBox.Show("YOU WANT A PREMIUM ON THIS PROGRAM FOR MORE ADS??? \n NOW AND ONLY NOW YOU HAVE THE OPTION TO GET A PREMIUM ONLY FOR 99.99lv!!! HURRY UP BECAUSE I NEED MONEY!!!");
        }

        static void Main(string[] args)
        {
            Program.Username();
            Program.Device();
            Program.EndAdvertisement();
        }
    }
}