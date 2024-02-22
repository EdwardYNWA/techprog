using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    internal class Class1
    {
        double a = 1.0;
        const decimal b = 214;
        long[] mass = { 1, 2, 3 };
        enum smaller : byte
        {
            one,
            two,
            three
        };
        void fun()
        {
            MessageBox.Show(Convert.ToString(a + Convert.ToInt32(b)));
            MessageBox.Show(Convert.ToString(mass[1] + a));
        }
    }
}
