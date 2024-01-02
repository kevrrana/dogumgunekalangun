using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dogum_ornk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dogumGunu = new DateTime(2024, 03, 28);
            DateTime bugun =DateTime.Today;
            TimeSpan kalansur = dogumGunu - bugun;
            int kalangun=kalansur.Days;
            label1.Text=kalangun.ToString();

          
        }
    }
}
