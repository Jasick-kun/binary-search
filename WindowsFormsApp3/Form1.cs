using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] a = new int[20];
        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for(int i = 0; i < 20; i++)
            {
                a[i] = random.Next()%50;
            }
            Array.Sort(a);
            StringBuilder str = new StringBuilder();
            str.Append("Массив = ");
            for(int i=0; i<20; i++)
            {
                str.Append(a[i].ToString());
                str.Append("  ");
            }
            label2.Text=str.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked)
            {
                int max = 19;
                int min = 0;
                int i = 9;
                while (a[i] != n && max!=min)
                {
                    if(a[i] > n)
                    {
                        max = i-1;
                        i = (i + min) / 2;
                        
                    }
                    else
                    {
                        min = i + 1;
                        i = (i + max) / 2;
                    }

                }
                label1.Text="индекс = "+ i.ToString();
            }
            if (radioButton2.Checked)
            {
                int max = 19;
                int x = -1;
                int min = 0;
               
                while ((max-min)!=1)
                {
                    if (a[2*(max - min) / 3 + min] == n)
                    {
                        x = 2 * (max - min) / 3 + min;
                        break;
                    } 
                    if (a[(max - min) / 3 + min] == n)
                    {
                        x = (max - min) / 3 + min;
                        break;
                    }
                    if ((a[(max - min) / 3 + min] < n) && (a[2*(max - min) / 3 + min] > n))
                    {
                        int buf = max;
                        max = 2*(max - min) / 3 + min;
                        min=(buf - min) / 3 + min;




                    }
                    else if(a[2*(max - min) / 3 + min] < n)
                    {
                        min = 2*(max - min) / 3 + min;


                    }
                    else
                    {
                        max = (max - min) / 3 + min;


                    }
                    
                }
               
                label1.Text = "индекс = " + x.ToString();
            }
            if (radioButton3.Checked)
            {
                for(int i = 0; i < 20; i++)
                {
                    if(a[i] == n)
                    {
                        label1.Text = i.ToString();
                        break;
                    }
                }
            }
        }
    }

}
