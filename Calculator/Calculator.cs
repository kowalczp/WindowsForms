using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apps
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }



        bool click = false;

        private void Button_Click(object sender, EventArgs e)
        {
            if ((
                Tb1.Text == "0")||(click))
                Tb1.Clear();
            click = false;
            Button b = (Button)sender;
            Tb1.Text = Tb1.Text + b.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tb1.Clear();
        }

        double val = 0;

        string op = "";
       
        private void op1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            op = b.Text;
            val = Convert.ToDouble(Tb1.Text);
            click = true;

            res2.Text = val + " " + op;
        }

        private void result_Click(object sender, EventArgs e)
        {
            res2.Text = "";
            switch (op)
            {
                case "+":
                    Tb1.Text = Convert.ToString(val + Convert.ToDouble(Tb1.Text));
                    break;
                case "-":
                    Tb1.Text = Convert.ToString(val - Convert.ToDouble(Tb1.Text));
                    break;
                case "*":
                    Tb1.Text = Convert.ToString(val * Convert.ToDouble(Tb1.Text));
                    break;
                case "sqrt":
                    Tb1.Text = Convert.ToString(Math.Sqrt(val));
                    break;
                case "/":
                    Tb1.Text = Convert.ToString(val / Convert.ToDouble(Tb1.Text));
                    break;
                default:
                    break;

            }
            
        }

        private void res2_Click(object sender, EventArgs e)
        {

        }
    }
}
