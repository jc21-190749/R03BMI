using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A05 大沼 志苑";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {


           string height = heighit.Placeholder;
            string weight = weighit.Placeholder;
            
            try
            {
                double h = double.Parse(height);
                double w = double.Parse(weight);
                string zyoutai="肥満(4度)";
                if (h>10)
                {
                    h = h / 100;
                }
    double BMI = w / (h * h);
    BMI = Math.Round(BMI* 10) / 10;
               
                if(BMI<40.00){
                    string zyoutai="肥満(3度)";
                  }else if (BMI < 35.00)
                {
                    string zyoutai="肥満(2度)";
                }else if (BMI < 30.00)
                {
                    string zyoutai="肥満(1度)";
                }else if (BMI < 25.00)
                {
                    string zyoutai="普通体重";
                }else if (BMI < 18.50)
                {
                    string zyoutai="低体重";
                }
                
                result.Text ="BMIは"+BMI+"で、体形は"+zyoutai+"す。";
            }
           
            catch (FormatException ex)
            {
    Console.WriteLine(ex);
    result.Text = "!!!";
            }
        }
    } 
    
}

