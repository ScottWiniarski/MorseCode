using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MorseCode
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        string input = "";
        string input1 = "";
        void Dot_Clicked(object sender, System.EventArgs e)
        {
            input += '.';
            In_char.Text = input;
        }
        void Dot_ClickedOne(object sender, System.EventArgs e)
        {
            input1 += '.';
            In_char1.Text = input1;
        }
        void Dash_Clicked(object sender, System.EventArgs e)
        {
            input += '-';
            In_char.Text = input;
        }
        void Dash_ClickedOne(object sender, System.EventArgs e)
        {
            input1 += '-';
            In_char1.Text = input1;
        }
        void Space_Clicked(object sender, System.EventArgs e)
        {
            Out_char.Text += Morse.MorseCoder(input);
            input = "";
        }
        void Space_ClickedOne(object sender, System.EventArgs e)
        {
            Out_char1.Text += Morse.MorseCoder(input1);
            input1 = "";
        }
    }
}
