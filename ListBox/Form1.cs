using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
            
 
            for (int i = 1; i <= 20; i++)
            {
                listBox1.Items.Add(String.Format("Opcja {0}", i));

         
                //li2.Add(String.Format("Opcja {0}", (char)(i + (int)'A')));


                listBox2.Items.Add(String.Format("Opcja {0}", (char)(i + (int)'A')));
            }
           
             
        }
 

 
 
        string items ;
        int index;
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select items", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                while (listBox1.SelectedItems.Count != 0)
                {
                    listBox2.Items.Add(listBox1.SelectedItems[0]);
                    listBox1.Items.Remove(listBox1.SelectedItems[0]);
                }
            }



                //if (listBox1 != null && listBox1.SelectedIndex != -1)
                //{

                //    this.index = listBox1.SelectedIndex;
                //    listBox2.Items.Add(listBox1.SelectedItem.ToString());

                //    listBox1.Items.RemoveAt(index);
                //}
                //else
                //{
                //    MessageBox.Show("Please select items", "ERROR",
                //    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}


        


        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select items", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                while (listBox2.SelectedItems.Count != 0)
                {
                    listBox1.Items.Add(listBox2.SelectedItems[0]);
                    listBox2.Items.Remove(listBox2.SelectedItems[0]);
                }
            }
        }
    }

}
