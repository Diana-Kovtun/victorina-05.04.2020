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
         public Form3(string temp)
        {
            InitializeComponent();
            label1.Text = temp;
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


            // switch ()
            //{
            //    case "2":
            //{
            // label13.Hide();
            //     label3.Hide();
            //   label14.Hide();
            //       label4.Hide();
            //        label15.Hide();
            //           label16.Hide();
            //label17.Hide();
            //  label5.Hide();
            //    label18.Hide();
            //       break;
            // }
            // case "3":
            // {
            //     label5.Hide();
            //   label17.Hide();
            //     label18.Hide();
            //       label4.Hide();
            //  label15.Hide();
            //    label16.Hide();
            //      break;

            //    }
            //  case "4":
            //{
            // label5.Hide();
            //   label17.Hide();
            //     label18.Hide();
            //       break;
            //     }
            //   case "5":
            //  {
            //             break;
            //           }


            //     }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 c = new Form4();
            c.ShowDialog();
            //Random rnd = new Random();
            //int a = rnd.Next(1, 7);
            //label19.Text = a.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {
           
        }
    }
}
