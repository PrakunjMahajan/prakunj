using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Add
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Sum(int n1, int n2)
        {
            if (n1 <= 0 && n2 <= 0)
            {
                throw new ArgumentException("No Zero or Negative are allowed");
            }
            else
            {
                //return n1 + n2;
              //added new comment
                txtRslt.Text = Convert.ToString(n1 + n2);
            }
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            MathClass obj = new MathClass();

            int Num1 = Convert.ToInt32(txtNum1.Text);
            int Num2 = Convert.ToInt32(txtNum2.Text);
            txtRslt.Text = Convert.ToString(obj.Sum(Num1, Num2));
        }
    }
}
