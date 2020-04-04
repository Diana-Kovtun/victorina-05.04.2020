using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proekt_05._04._2020
{
    public partial class Form3 : Form
    {
         public Form3(string temp, string temp1, string temp2, string temp3, string temp4)
        {
            InitializeComponent();
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label6.BackColor = Color.FromArgb(0, 0, 0, 0);
            label7.BackColor = Color.FromArgb(0, 0, 0, 0);
            label8.BackColor = Color.FromArgb(0, 0, 0, 0);
            label9.BackColor = Color.FromArgb(0, 0, 0, 0);
            label10.BackColor = Color.FromArgb(0, 0, 0, 0);
            label11.BackColor = Color.FromArgb(0, 0, 0, 0);
            label12.BackColor = Color.FromArgb(0, 0, 0, 0);
            label13.BackColor = Color.FromArgb(0, 0, 0, 0);
            label14.BackColor = Color.FromArgb(0, 0, 0, 0);
            label15.BackColor = Color.FromArgb(0, 0, 0, 0);
            label16.BackColor = Color.FromArgb(0, 0, 0, 0);
            label17.BackColor = Color.FromArgb(0, 0, 0, 0);
            label18.BackColor = Color.FromArgb(0, 0, 0, 0);
            label19.BackColor = Color.FromArgb(0, 0, 0, 0);
            pictureBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label19.Hide();
            label1.Text = temp;
            label2.Text = temp1;
            label3.Text = temp2;
            label4.Text = temp3;
            label5.Text = temp4;
            int n = 0;
            label9.Text = n.ToString();
            label10.Text = n.ToString();
            label11.Text = n.ToString();
            label12.Text = n.ToString();
            label13.Text = n.ToString();
            label14.Text = n.ToString();
            label15.Text = n.ToString();
            label16.Text = n.ToString();
            label17.Text = n.ToString();
            label18.Text = n.ToString();


            if (temp2 == "")
            {
             label13.Hide();
             label3.Hide();
             label14.Hide();
             label4.Hide();
             label15.Hide();
             label16.Hide();
             label17.Hide();
             label5.Hide();
             label18.Hide();
           
             }
            
            if(temp3=="") 
            {
            label5.Hide();
            label17.Hide();
            label18.Hide();
            label4.Hide();
            label15.Hide();
            label16.Hide();

            }
           
            if(temp4 =="")
            {
            label5.Hide();
            label17.Hide();
            label18.Hide();
            
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 7);
            label19.Text = a.ToString();
            Form4 c = new Form4(label19.Text,label1.Text, label2.Text, label3.Text, label4.Text, label5.Text);
            c.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
