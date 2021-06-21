using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SchoolProjectConfigurations
{
    class UserDevice
    {

        public static void ChooseDevice(string device)
        {
            if (device == "PC" || device == "pc" || device == "Pc" || device == "pC")
            {
                MessageBox.Show("ATTENTION!!! ONLY NOW YOU CAN GET A HDMI CABLE ON A SUPER LOW PRICE!!!!!! NOT 2lv, NOT 5lv, BUT ONLY 10lv!!! YOU GET THE CABEL NOT TO THE PRICE OF 1, NOT 2, BUT THE PRICE OF 5 HMDI CABLES YOU GET 1!!!");
                char currency = Char.Parse(Interaction.InputBox("Enter currency you want to work with (lev - l), (euro - e), (USD dollars - d)"));
                UserSettings.CheckCurrencyPC(currency);
            }
            else if (
                //all low
                device == "laptop" ||
                //ALL CAPITALS
                device == "LAPTOP" ||
                //One capital
                device == "Laptop" ||
                device == "lAptop" ||
                device == "laPtop" ||
                device == "lapTop" ||
                device == "laptOp" ||
                device == "laptoP" ||
                //Two Capitals
                //Capital L
                device == "LAptop" ||
                device == "LaPtop" ||
                device == "LapTop" ||
                device == "LaptOp" ||
                device == "LaptoP" ||
                //Capital A
                device == "lAPtop" ||
                device == "lApTop" ||
                device == "lAptOp" ||
                device == "lAptoP" ||
                //Capital P1
                device == "laPTop" ||
                device == "laPtOp" ||
                device == "laPtoP" ||
                //Capital T
                device == "lapTOp" ||
                device == "lapToP" ||
                //Capital O
                device == "laptOP" ||
                //Three Capitals
                //Capitals L, A
                device == "LAPtop" ||
                device == "LApTop" ||
                device == "LAptOp" ||
                device == "LAptoP" ||
                //Capitals L, P1
                device == "LaPTop" ||
                device == "LaPtOp" ||
                device == "LaPtoP" ||
                //Capitals L, T
                device == "LapTOp" ||
                device == "LapToP" ||
                //Capitals L, O
                device == "LaptOP" ||
                //Capitals A, P
                device == "lAPTop" ||
                device == "lAPtOp" ||
                device == "lAPtoP" ||
                //Capitals A, T
                device == "lApTOp" ||
                device == "lApToP" ||
                //Capitals A, O
                device == "lAptOP" ||
                //Capitals P, T
                device == "laPTOp" ||
                device == "laPToP" ||
                //Capitals P, O
                device == "laPtOP" ||
                //Capitals T, O
                device == "lapTOP"
                )
            {
                MessageBox.Show("ATTENTION!!! ONLY NOW YOU CAN GET A INTERNET FLASH DRIVE ON A SUPER LOW PRICE!!!!!! NOT 10lv, NOT 15lv, BUT ONLY 30lv!!! YOU GET THE FLASH DRIVE NOT TO THE PRICE OF 1, NOT 2, BUT THE PRICE OF 5 INTERNET FLASH DRIVES YOU GET 1!!!");
                char currency = Char.Parse(Interaction.InputBox("Enter currency you want to work with (lev - l), (euro - e), (USD dollars - d)"));
                UserSettings.CheckCurrencyLaptop(currency);
            }
            else if (
                //all low
                device == "smartphone" ||
                //ALL CAPITALS
                device == "SMARTPHONE" ||
                //One Capital
                device == "Smartphone" ||
                device == "sMartphone" ||
                device == "smArtphone" ||
                device == "smaRtphone" ||
                device == "smarTphone" ||
                device == "smartPhone" ||
                device == "smartpHone" ||
                device == "smartphOne" ||
                device == "smartphoNe" ||
                device == "smartohonE" ||
                //Two capitals
                //Capital S
                device == "SMartphone" ||
                device == "SmArtphone" ||
                device == "SmaRtphone" ||
                device == "SmarTphone" ||
                device == "SmartPhone" ||
                device == "SmartpHone" ||
                device == "SmartphOne" ||
                device == "SmartphoNe" ||
                device == "SmartphonE" ||
                //Capital M
                device == "sMArtphone" ||
                device == "sMaRtphone" ||
                device == "sMarTphone" ||
                device == "sMartPhone" ||
                device == "sMartpHone" ||
                device == "sMartphOne" ||
                device == "sMartphoNe" ||
                device == "sMartphonE" ||
                //Capital A
                device == "smARtphone" ||
                device == "smArTphone" ||
                device == "smArtPhone" ||
                device == "smArtpHone" ||
                device == "smArtphOne" ||
                device == "smArtphoNe" ||
                device == "smArtphonE" ||
                //Capital R
                device == "smaRTphone" ||
                device == "smaRtPhone" ||
                device == "smaRtpHone" ||
                device == "smaRtphOne" ||
                device == "smaRtphoNe" ||
                device == "smaRtphonE" ||
                //Capital T
                device == "smarTPhone" ||
                device == "smarTpHone" ||
                device == "smarTphOne" ||
                device == "smarTphoNe" ||
                device == "smarTphonE" ||
                //Capital P
                device == "smartPHone" ||
                device == "smartPhOne" ||
                device == "smartPHoNe" ||
                device == "smartPhonE" ||
                //Capital H
                device == "smartpHOne" ||
                device == "smartpHoNe" ||
                device == "smartpHonE" ||
                //Capital O
                device == "smartphONe" ||
                device == "smartphOnE" ||
                //Capital N
                device == "smartphoNE" ||
                //Three capitals
                //Capitals S, M
                device == "SMArtphone" ||
                device == "SMaRtphone" ||
                device == "SMarTphone" ||
                device == "SMartPhone" ||
                device == "SMartpHone" ||
                device == "SMartphOne" ||
                device == "SMartphoNe" ||
                device == "SMartphonE" ||
                //Capitals S, A
                device == "SmARtphone" ||
                device == "SmArTphone" ||
                device == "SmArtPhone" ||
                device == "SmArtpHone" ||
                device == "SmArtphOne" ||
                device == "SmArtphoNe" ||
                device == "SmArtphonE" ||
                //Capitals S, R
                device == "SmaRTphone" ||
                device == "SmaRtPhone" ||
                device == "SmaRtpHone" ||
                device == "SmaRtphOne" ||
                device == "SmaRtphoNe" ||
                device == "SmaRtphonE" ||
                //Capitals S, T
                device == "SmarTPhone" ||
                device == "SmarTpHone" ||
                device == "SmarTphOne" ||
                device == "SmarTphoNe" ||
                device == "SmarTphonE" ||
                //Capitals S, P
                device == "SmartPHone" ||
                device == "SmartPhOne" ||
                device == "SmartPhoNe" ||
                device == "SmartPhonE" ||
                //Capitals S, H
                device == "SmartpHOne" ||
                device == "SmartpHoNe" ||
                device == "SmartpHonE" ||
                //Caapitals S, O
                device == "SmartphONe" ||
                device == "SmartphOnE" ||
                //Capitals S, N
                device == "SmartphoNE" ||
                //Capitals M, A
                device == "sMARtphone" ||
                device == "sMArTphone" ||
                device == "sMArtPhone" ||
                device == "sMArtpHone" ||
                device == "sMArtphOne" ||
                device == "sMArtphoNe" ||
                device == "sMArtphonE" ||
                //Capitals M, R
                device == "sMaRTphone" ||
                device == "sMaRtPhone" ||
                device == "sMaRtpHone" ||
                device == "sMaRtphOne" ||
                device == "sMaRtphoNe" ||
                device == "sMaRtphonE" ||
                //Capitals M, T
                device == "sMarTPhone" ||
                device == "sMarTpHone" ||
                device == "sMarTphOne" ||
                device == "sMarTphoNe" ||
                device == "sMarTphonE" ||
                //Capitals M, P
                device == "sMartPHone" ||
                device == "sMartPhOne" ||
                device == "sMartPhoNe" ||
                device == "sMartPhonE" ||
                //Capitals M, H
                device == "sMartpHOne" ||
                device == "sMartpHoNe" ||
                device == "sMartpHonE" ||
                //Capitals M, O
                device == "sMartphONe" ||
                device == "sMartphOnE" ||
                //Capitals M, N
                device == "sMartphoNE" ||
                //Capitals A, R
                device == "smARTphone" ||
                device == "smARtPhone" ||
                device == "smARtpHone" ||
                device == "smARtphOne" ||
                device == "smARtphoNe" ||
                device == "smARtphonE" ||
                //Capitals A, T
                device == "smArTPhone" ||
                device == "smArTpHone" ||
                device == "smArTphOne" ||
                device == "smArTphoNe" ||
                device == "smArTphonE" ||
                //Capitals A, P
                device == "smArtPHone" ||
                device == "smArtPhOne" ||
                device == "smArtPhoNe" ||
                device == "smArtPhonE" ||
                //Capitals A, H
                device == "smArtpHOne" ||
                device == "smArtpHoNe" ||
                device == "smArtpHonE" ||
                //Capitals A, O
                device == "smArtphONe" ||
                device == "smArtphOnE" ||
                //Capitals A, N
                device == "smArtphoNE" ||
                //Capitals R, T
                device == "smaRTPhone" ||
                device == "smaRTpHone" ||
                device == "smaRTphOne" ||
                device == "smaRTphoNe" ||
                device == "smaRTphonE" ||
                //Capitals R, P
                device == "smaRtPHone" ||
                device == "smaRtPhOne" ||
                device == "smaRtPhoNe" ||
                device == "smaRtPhonE" ||
                //Capitals R, H
                device == "smaRtpHOne" ||
                device == "smaRtpHoNe" ||
                device == "smaRtpHonE" ||
                //Capitals R, O
                device == "smaRtphONe" ||
                device == "smaRtphOnE" ||
                //Capitals R, N
                device == "smaRtphoNE" ||
                //Capitals T, P
                device == "smarTPHone" ||
                device == "smarTPhOne" ||
                device == "smarTPhoNe" ||
                device == "smarTPhonE" ||
                //Capitals T, H
                device == "smarTpHOne" ||
                device == "smarTpHoNe" ||
                device == "smarTpHonE" ||
                //Capitals T, O
                device == "smarTphONe" ||
                device == "smarTphOnE" ||
                //Capitals T, N
                device == "smarTphoNE" ||
                //Capitals P, H
                device == "smartPHOne" ||
                device == "smartPHoNe" ||
                device == "smartPHonE" ||
                //Capitals P, O
                device == "smartPhONe" ||
                device == "smartPhOnE" ||
                //Capitals P, N
                device == "smartPhoNE" ||
                //Capitals H, O
                device == "smartpHONe" ||
                device == "smartpHOnE" ||
                //Capitals H, N
                device == "smartpHoNE" ||
                //Capitals O, N
                device == "smartphONE")
            {
                MessageBox.Show("ATTENTION!!! ONLY NOW YOU CAN GET A CASE ON A SUPER LOW PRICE!!!!!! NOT 2lv, NOT 5lv, BUT ONLY 15lv!!! YOU GET THE CASE NOT TO THE PRICE OF 1, NOT 2, BUT THE PRICE OF 5 PHONE CASES YOU GET 1!!!");
                char currency = Char.Parse(Interaction.InputBox("Enter currency you want to work with (lev - l), (euro - e), (USD dollars - d)"));
                UserSettings.CheckCurrencySmartphone(currency);
            }
            else
            {
                MessageBox.Show("Why?");
            }
        }

    }
}
