using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double firstnumber;
        double secondnumber;
        double capacity;
        string netice = null;

        private void button_1_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(ekran.Text) || ekran.Text=="0")
            {
                ekran.Text = (sender as Button).Content.ToString();
                history.Content += (sender as Button).Content.ToString();
            }
            else
            {
                ekran.Text += (sender as Button).Content.ToString();
                history.Content += (sender as Button).Content.ToString();
            }
                    
       
        }

  
   

        private void button1_Click(object sender, EventArgs e)
        {
            double number = double.Parse(ekran.Text);
            ekran.Text = (Math.Sqrt(number)).ToString();
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            double indiki = 0;
            int count = 0;
            if (netice != null)
            {
      
                button_beraber_Click(sender,e);
                indiki = double.Parse(ekran.Text);
                count++;
            }
           
            
                if (string.IsNullOrEmpty(netice))
                {
                    history.Content += (sender as Button).Content.ToString();
                    netice = (sender as Button).Content.ToString();
                    firstnumber = double.Parse(ekran.Text);

                    ekran.Text += (sender as Button).Content.ToString();
                }
                else
                {
                    string lazim = history.Content.ToString();
                    
                    lazim =lazim.Remove(lazim.IndexOf(netice));
            
                    
                    history.Content = null;
                    history.Content = lazim.ToString();
                    history.Content += (sender as Button).Content.ToString();
                    netice = (sender as Button).Content.ToString();
     

                    ekran.Text += (sender as Button).Content.ToString();
                }
           
            ekran.Text = "0";
     
         

            }

        private void button_beraber_Click(object sender, EventArgs e)
        {
            if (netice != null)
            {
                secondnumber = double.Parse(ekran.Text);
                if (netice == "+")
                {
                  
                    ekran.Text = "0";
                    ekran.Text = (firstnumber + secondnumber).ToString();

                }
                else if (netice == "-")
                {
        
                    ekran.Text = "0";
                    ekran.Text = (firstnumber - secondnumber).ToString();

                }
                else if (netice == "*")
                {
           
                    ekran.Text = "0";
                    ekran.Text = (firstnumber * secondnumber).ToString();

                }
                else if (netice == "/")
                {
                   
                    if (secondnumber == 0)
                    {
                        history.Content = "xeta";
                        ekran.Text = "Xeta";

                    }
                    else
                    {

                        ekran.Text = "0";
                        ekran.Text = (firstnumber / secondnumber).ToString();
                    }


                }
              
            }

            netice = null;
        }

        

        private void button_plusminus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ekran.Text))
            {
                double number = double.Parse(ekran.Text);
                ekran.Text = (number * (-1)).ToString();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ekran.Text))
            {
                string number = (ekran.Text);
                ekran.Text = (number.Remove(number.Length - 1)).ToString();
                history.Content = (number.Remove(number.Length - 1)).ToString();
            }

        }

        private void button_vergul_Click(object sender, EventArgs e)
        {
            string number = (ekran.Text);
            if (!string.IsNullOrEmpty(ekran.Text))
            {
                if (number[number.Length - 1] != ',') ekran.Text += ",";
            }
          

        }

  

        private void button_faiz_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ekran.Text))
            {
                double number = double.Parse(ekran.Text);
                ekran.Text = (number / 100).ToString();
            }
        }

        private void button_mc_Click(object sender, RoutedEventArgs e)
        {
            capacity = 0;
            M.Content = null;
        }

        private void button_mr_Click(object sender, RoutedEventArgs e)
        {
            ekran.Text= capacity.ToString();
        }

        private void button_ms_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(ekran.Text))
            {
                capacity = double.Parse(ekran.Text);
                M.Content = "M";
            }
   

        }

        private void button_mplus_Click(object sender, RoutedEventArgs e)
        {
            capacity += double.Parse(ekran.Text);
        }

        private void button_mminus_Click(object sender, RoutedEventArgs e)
        {
            capacity -= double.Parse(ekran.Text);
        }

        private void button_ce_Click(object sender, RoutedEventArgs e)
        {
          
            string lazim = history.Content.ToString();

            if (!string.IsNullOrWhiteSpace(secondnumber.ToString()))
            {
                for (int i = 0; i < ekran.Text.ToString().Length; i++)
                {
                    lazim = lazim.Remove(lazim.Length-1) ;
                }
                
                history.Content = null;
                history.Content = lazim.ToString();
                secondnumber = 0;
                
            }
            else
            {
     
                firstnumber = 0;
                netice = null;
                history.Content = null;
            }
            ekran.Text = null;
        }

        private void button_c_Click(object sender, RoutedEventArgs e)
        {
            history.Content = null ;
            ekran.Text = null;

        }

        private void button_kok_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(ekran.Text))
            {
                double number = int.Parse(ekran.Text);
                ekran.Text = (Math.Sqrt(number)).ToString();
            }
        }

        private void button_1bolx_Click(object sender, RoutedEventArgs e)
        {

            if (!string.IsNullOrEmpty(ekran.Text))
            {
                double number = int.Parse(ekran.Text);
                if (number == 0)
                {
                    ekran.Text = "xeta";
                }
                else
                {
                    ekran.Text = (number*number).ToString();
                }

            }
        }
    }
}
