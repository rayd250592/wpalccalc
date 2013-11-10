using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Alcohol_Unit_Calculator
{
    public partial class MainPage : PhoneApplicationPage
    {

        int recommendmen = 21;
        int reccomendwomen = 14;
        
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {



            if (!isValid(a.Text))
            {

                MessageBox.Show("Please enter a value");
               

            }

            else if (!isValid(b.Text))
            {

                MessageBox.Show("Please enter a value");
                

            }

            else if (!isValid(c.Text))
            {

                MessageBox.Show("Please enter a value");
               

            }

            else if (!isValid(d.Text))
            {

                MessageBox.Show("Please enter a value");
          

            }

            else if (!isValid(z.Text))
            {

                MessageBox.Show("Please enter a value");


            }

            else
            {
                try
                {


                    String tpint = text_pint.Text;

                    String twine = text_wine.Text;

                    String tsspirit = text_sspirit.Text;

                    String tdsspirit = text_dspirit.Text;

                    String talco = text_alcopop.Text;

                    int ipint = Convert.ToInt32(tpint);
                    int iwine = Convert.ToInt32(twine);
                    int isspirits = Convert.ToInt32(tsspirit);
                    int idspirits = Convert.ToInt32(tdsspirit);
                    int ialcopop = Convert.ToInt32(talco);

                    int p = 2;
                    int w = 3;
                    int ss = 1;
                    int ds = 2;
                    int az = 2;

                    int ip = ipint * p;
                    int iw = iwine * w;
                    int iss = isspirits * ss;
                    int ids = idspirits * ds;
                    int ia = ialcopop * az;

                    int result = ip + iw + iss + ids + ia;
                    text_result.Text = result.ToString();


                    if (result > recommendmen)
                    {

                        int diff = result - recommendmen;
                        MessageBox.Show("You are" + " " + diff + " " + "units over the limit for a man for a week");
                       


                    }

                    else if (result > reccomendwomen)
                    {

                        int diff = result - reccomendwomen;
                        MessageBox.Show("You are" + " " + diff + " " + "units over the limit for a woman for a week");
                        

                    }


                }

                catch (Exception ex)
                {

                    message_user("Please enter a valid value");

                }
            
        }

            
               

        }



        private void message_user(string message)
        {

            MessageBox.Show(message);

        }
        private Boolean isValid(string doofer)
        {
            if (doofer == "")
            {
                return false;
            }

            else

                return true;

        }
       
    }
}