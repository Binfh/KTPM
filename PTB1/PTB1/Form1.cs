using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace PTB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btngiai_Click(object sender, EventArgs e)
        {
            double a, b, ketqua;
            a = double.Parse(txta.Text);
            b = double.Parse(txtb.Text);
            Giai c = new Giai(a, b);
            ketqua = c.Solve();
            txtkq.Text = ketqua.ToString();
        }

        

        
    }
}
