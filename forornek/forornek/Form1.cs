using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sayi1=Convert.ToInt32(txtBaslangic.Text);
            int sayi2=Convert.ToInt32(txtBitis.Text);
            for (int i = sayi1; i <=sayi2; i++)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
