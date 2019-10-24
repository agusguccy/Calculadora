using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Calculadora.Services;

namespace Calculadora
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;

            LabelDisplay.Text = button.Text;
        }

        private void BtnSuma_Clicked(object sender, EventArgs e) 
        {
            float a = float.Parse(LabelDisplay.Text);
            float b = float.Parse(LabelDisplay.Text);
            LabelDisplay.Text = (a + b).ToString();
        
        }

        private void BtnResta_Clicked(object sender, EventArgs e)
        {
            float a = float.Parse(LabelDisplay.Text);
            float b = float.Parse(LabelDisplay.Text);
            LabelDisplay.Text = (a - b).ToString();
        
        }

        private void BtnMult_Clicked(object sender, EventArgs e)
        {
            float a = float.Parse(LabelDisplay.Text);
            float b = float.Parse(LabelDisplay.Text);
            LabelDisplay.Text = (a * b).ToString();
        
        }

        private void BtnDiv_Clicked(object sender, EventArgs e)
        {
            float a = float.Parse(LabelDisplay.Text);
            float b = float.Parse(LabelDisplay.Text);
            LabelDisplay.Text = (a / b).ToString();
        }

       /* private void BtnResto_Clicked(object sender, EventArgs e)
        {
            float a = float.Parse(LabelDisplay.Text);
            float b = float.Parse(LabelDisplay.Text);
            LabelDisplay.Text = (a % b).ToString();
        }
        */

        private void BtnClr_Clicked(object sender, EventArgs e)
        {
            LabelDisplay.Text = string.Empty;
        }



    }
}
