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
    public partial class Form2 : Form
    {
        public Form2(String temp)
        {
            InitializeComponent();
            switch (temp)
            {
                case "2":
                    {
                        textBox3.Hide();   
                        label3.Hide();
                        textBox4.Hide();
                        label4.Hide();
                        textBox5.Hide();
                        label5.Hide();
                        break;
                    }
                case "3":
                    {
                        textBox4.Hide();
                        label4.Hide();
                        textBox5.Hide();
                        label5.Hide();
                        break;

                    }
                case "4":
                    {
                        textBox5.Hide();
                        label5.Hide();
                        break;
                    }
                case "5":
                    {
                        break;
                    }
         

            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 d = new Form3(textBox1.Text);
            this.Hide();
            d.ShowDialog();
            this.Close();
        }
    }
}
