using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void monthCalendar2_KeyDown(object sender, KeyEventArgs e)
        {
            int a = 2 + 3;
            MessageBox.Show("World");

        }
    }
}
