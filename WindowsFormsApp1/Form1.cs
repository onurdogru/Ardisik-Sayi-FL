using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;

            for (int i = 0; i < 10; i++)
            {
                toplam = toplam + i;
            }
            label1.Text = toplam.ToString();



            //breakpoint için;

            for (int i = 1; i < 6; i+=1)
            {
                listBox1.Items.Add(i);
            }

        }

    }
}
