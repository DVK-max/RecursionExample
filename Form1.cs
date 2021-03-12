using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursionExample
{
    public partial class Form1 : Form
    {

        int MaxSize = 12;

        int[] Bits;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bits = new int[MaxSize];
            
            for (int x=0;x<MaxSize;x++)
            {
                Bits[x] = 0;
            }

            string Binary = "";
            for (int x = 0; x < MaxSize; x++)
            {
                Binary += Bits[x].ToString();
            }

            label1.Text = "";
                        
            for (int X2=MaxSize-1;X2>=0;X2--)
            {
                label1.Text += Bits[X2].ToString();
            }
        }

        public void IncBit(int index)
        {
            if (Bits[index]==0)
            {
                Bits[index] = 1;
            } else 
            { 
                if (index==(MaxSize-1))
                {
                    Bits[index] = 0;
                } else
                {
                    Bits[index] = 0;
                    IncBit(index + 1);
                }                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IncBit(0);
            label1.Text = "";
            for (int X2 = MaxSize - 1; X2 >= 0; X2--)
            {
                label1.Text += Bits[X2].ToString();
            }
        }
    }
}
