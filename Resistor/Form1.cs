using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resistor
{
    public partial class CalcResistor : Form
    {
        public CalcResistor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string combo = comboBox1.Text;
            switch (combo)
            {
                case "Black":
                    label5.Text = "0";
                    label1.BackColor = Color.Black;
                    break;
                case "Brown":
                    label5.Text = "1";
                    label1.BackColor = Color.Brown;
                    break;
                case "Red":
                    label5.Text = "2";
                    label1.BackColor = Color.Red;
                    break;
                case "Orange":
                    label5.Text = "3";
                    label1.BackColor = Color.Orange;
                    break;
                case "Yellow":
                    label5.Text = "4";
                    label1.BackColor = Color.Yellow;
                    break;
                case "Green":
                    label5.Text = "5";
                    label1.BackColor = Color.Green;
                    break;
                case "Blue":
                    label5.Text = "6";
                    label1.BackColor = Color.Blue;
                    break;
                case "Violet":
                    label5.Text = "7";
                    label1.BackColor = Color.Violet;
                    break;
                case "Gray":
                    label5.Text = "8";
                    label1.BackColor = Color.Gray;
                    break;
                case "White":
                    label5.Text = "9";
                    label1.BackColor = Color.White;
                    break;


            }
            //if (comboBox1.Text == "Czarny")
            //{
            //    label5.Text = "0";
            //    label1.BackColor = Color.Black;
            //}
            //else
            //{
            //    label1.BackColor = Color.White;
            //}
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string combo = comboBox2.Text;
            switch (combo)
            {
                case "Black":
                    label8.Text = "0";
                    label2.BackColor = Color.Black;
                    break;
                case "Brown":
                    label8.Text = "1";
                    label2.BackColor = Color.Brown;
                    break;
                case "Red":
                    label8.Text = "2";
                    label2.BackColor = Color.Red;
                    break;
                case "Orange":
                    label8.Text = "3";
                    label2.BackColor = Color.Orange;
                    break;
                case "Yellow":
                    label8.Text = "4";
                    label2.BackColor = Color.Yellow;
                    break;
                case "Green":
                    label8.Text = "5";
                    label2.BackColor = Color.Green;
                    break;
                case "Blue":
                    label8.Text = "6";
                    label2.BackColor = Color.Blue;
                    break;
                case "Violet":
                    label8.Text = "7";
                    label2.BackColor = Color.Violet;
                    break;
                case "Gray":
                    label8.Text = "8";
                    label2.BackColor = Color.Gray;
                    break;
                case "White":
                    label8.Text = "9";
                    label2.BackColor = Color.White;
                    break;

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string combo = comboBox3.Text;
            switch (combo)
            {
                case "Black":
                    label10.Text = "1";
                    label3.BackColor = Color.Black;
                    break;
                case "Brown":
                    label10.Text = "10";
                    label3.BackColor = Color.Brown;
                    break;
                case "Red":
                    label10.Text = "100";
                    label3.BackColor = Color.Red;
                    break;
                case "Orange":
                    label10.Text = "1000";
                    label3.BackColor = Color.Orange;
                    break;
                case "Yellow":
                    label10.Text = "10000";
                    label3.BackColor = Color.Yellow;
                    break;
                case "Green":
                    label10.Text = "100000";
                    label3.BackColor = Color.Green;
                    break;
                case "Blue":
                    label10.Text = "1000000";
                    label3.BackColor = Color.Blue;
                    break;
                case "Violet":
                    label10.Text = "10000000";
                    label3.BackColor = Color.Violet;
                    break;
                case "Gold":
                    label10.Text = "0.1";
                    label3.BackColor = Color.Gold;
                    break;
                case "Silver":
                    label10.Text = "0.01";
                    label3.BackColor = Color.Silver;
                    break;

            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string combo = comboBox4.Text;
            switch (combo)
            {

                case "Brown":
                    label12.Text = "1";
                    label15.BackColor = Color.Brown;
                    break;
                case "Red":
                    label12.Text = "2";
                    label15.BackColor = Color.Red;
                    break;

                case "Green":
                    label12.Text = "0.5";
                    label15.BackColor = Color.Green;
                    break;
                case "Blue":
                    label12.Text = "0.25";
                    label15.BackColor = Color.Blue;
                    break;
                case "Violet":
                    label12.Text = "0.10";
                    label15.BackColor = Color.Violet;
                    break;
                case "Gray":
                    label12.Text = "0.1";
                    label15.BackColor = Color.Gray;
                    break;
                case "Silver":
                    label12.Text = "10";
                    label15.BackColor = Color.Silver;
                    break;
                case "Gold":
                    label12.Text = "5";
                    label15.BackColor = Color.Gold;
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string val = label5.Text + label8.Text;

            if (label5.Text != "" && label8.Text != "" && label10.Text != "" && label12.Text != "")
            {
                double multiplier = Convert.ToDouble(label10.Text);
                double result = Convert.ToDouble(val) * multiplier / 1000;
                label24.Text = result + " k ohms  " + "+/- " + label12.Text + " %";
            }
            else
            {
                MessageBox.Show("Please fill out all the required fields", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label8.Text = "";
            label10.Text = "";
            label12.Text = "";
            label24.Text = "";


        }
    }
}
