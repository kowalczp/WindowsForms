using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        
        public void ConvertValue(object sender, EventArgs e)
        {
            double val = 0;
            if (listBox1.SelectedIndex != -1)
            {
               val = Convert.ToDouble(tb1.Text);
                
                string operation = listBox1.Text;
                switch (operation)
                {

                    case "kg -> lbs":
                        if ((val >= 0) && (Double.TryParse(tb1.Text, out val)))
                        {
                            textBox2.Text = Convert.ToString(val * 2.2046);

                        }
                        else
                        {
                            MessageBox.Show("Wrong value", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                        break;
                    case "lbs -> kg":
                        if (val >= 0)
                        {
                            textBox2.Text = Convert.ToString(val / 2.2046);

                        }
                        else
                        {
                            MessageBox.Show("Wrong value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case "C -> F":
                        textBox2.Text = Convert.ToString((val*(1.8)) + 32) ;
                        break;
                    case "F -> C":
                        textBox2.Text = Convert.ToString((val - 32) * 5.0/9.0) ;
                        break;
                    case "km/h -> kts":
                        textBox2.Text = Convert.ToString(val * 1.852);
                        break;
                    case "kts -> km/h":
                        textBox2.Text = Convert.ToString(val / 1.852);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Select item", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}
