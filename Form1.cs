using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;


namespace SC_Stealth_Detection_Range_Finder
{
    public partial class CalculatorMain : Form
    {
        public CalculatorMain()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        private void Formshown(object sender, EventArgs e)
        {
            MessageBox.Show("o7 and thanks for checking out my Star Citizen stealth calculator! " +
                            "\r\r" +
                            "This is really just a project for me to better understand C#, but I will probably continue to iterate " +
                            "on it as I learn more and as the stealth model in Star Citizen continues to change." +
                            "\r \r"+
                            ">>>> HOW TO USE <<<<" +
                            "\r" + 
                            "------------------------------------" +
                            "\r" +
                            "Just input your ship's emissions (IR, EM, & CS) values into their respective " +
                            "text boxes and click 'Calculate' to determine your detection range." +
                            "\r\r" +
                            " Enjoy!" +
                            "\r" +
                            "-Blaqkstar");
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declares IR, EM, CS, Range, and flag variables
                decimal IR;
                decimal EM;
                decimal CS;
                decimal Range;


                // Assigns user input to the values IR, EM, and CS
                IR = decimal.Parse(IRInput.Text);
                EM = decimal.Parse(EMInput.Text);
                CS = decimal.Parse(CSInput.Text);

                // Ensuring emissions values are greater than 0
                if (IR > 0 && EM > 0 && CS > 0)
                {
                    // Establishes IR as the highest value and assigns it to Range
                    if (IR > CS && IR > EM)
                    {
                        Range = IR;

                        if (Range >= 100000)
                        {
                            RangeOutput.Text = (Range / 1000).ToString() + "KM";
                        }
                        else if (Range >= 10000 && Range <= 99999)
                        {
                            RangeOutput.Text = (Range / 1000).ToString() + "KM";
                        }
                        else if (Range >= 1000 && Range <= 9999)
                        {
                            RangeOutput.Text = (Range / 1000).ToString() + "KM";
                        }
                        else if (Range <= 999)
                        {
                            RangeOutput.Text = (Range).ToString() + "M";
                        }
                    }
                    else if (EM > CS && EM > IR)
                    {
                        // Establishes EM as the highest value and assigns it to Range
                        Range = EM;

                        if (Range >= 100000)
                        {
                            RangeOutput.Text = (Range / 1000).ToString() + "KM";
                        }
                        else if (Range >= 10000 && Range <= 99999)
                        {
                            RangeOutput.Text = (Range / 1000).ToString() + "KM";
                        }
                        else if (Range >= 1000 && Range <= 9999)
                        {
                            RangeOutput.Text = (Range / 1000).ToString() + "KM";
                        }
                        else if (Range <= 999)
                        {
                            RangeOutput.Text = (Range).ToString() + "M";
                        }
                    }
                    else if (CS > EM && CS > IR)
                    {
                        // Establishes that CS is the highest value and performs calculation with EM
                        Range = CS;

                        if (Range >= 100000)
                        {
                            RangeOutput.Text = (Range / 1000).ToString() + "KM";
                        }
                        else if (Range >= 10000 && Range <= 99999)
                        {
                            RangeOutput.Text = (Range / 1000).ToString() + "KM";
                        }
                        else if (Range >= 1000 && Range <= 9999)
                        {
                            RangeOutput.Text = (Range / 1000).ToString() + "KM";
                        }
                        else if (Range <= 999)
                        {
                            RangeOutput.Text = (Range).ToString() + "M";
                        }
                    }
                    // If all values are the same
                    if (IR == CS && IR == EM)
                    {
                        Range = IR;

                        if (Range >= 100000)
                        {
                            RangeOutput.Text = (Range / 1000).ToString() + "KM";
                        }
                        else if (Range >= 10000 && Range <= 99999)
                        {
                            RangeOutput.Text = (Range / 1000).ToString() + "KM";
                        }
                        else if (Range >= 1000 && Range <= 9999)
                        {
                            RangeOutput.Text = (Range / 1000).ToString() + "KM";
                        }
                        else if (Range <= 999)
                        {
                            RangeOutput.Text = (Range).ToString() + "M";
                        }
                    }
                }
                else
                {
                    // Invalid input error pop
                    MessageBox.Show("IR, EM, and CS values must be greater than zero!");
                }
            }
            catch (Exception ex)
            {
                // Displays error pop
                MessageBox.Show(ex.Message);
            }
        
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            IRInput.Text = "";
            EMInput.Text = "";
            CSInput.Text = "";
            RangeOutput.Text = "";
            IRInput.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    } 


}
