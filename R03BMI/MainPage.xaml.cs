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


           string height = heighit.text;
            string weight = weighit.text;
            
            try
            {
                double h = double.Parse(height);
                double w = double.Parse(weight);
                string zyoutai;
                if (h>10)
                {
                    h = h / 100;
                }
                if (w>1000) {
                   w = w/1000
                }
    double BMI = Math.Round( w / (h * h),1);
              
            if　(BMI<18.50)
                {
                   zyoutai="低体重(痩せ)";
                }else if (BMI<25.00)
                {
                   zyoutai="普通体重";
                }
                else if (BMI<30.00)
                {
                   zyoutai="肥満(1度)";
                } 
                else if (BMI<35.00)
                {
                     zyoutai="肥満(2度)";
                }
                else if(BMI<40.00)
                        {
                    zyoutai="肥満(3度)";
                  }
                else {
                  zyoutai="肥満(4度)";
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

