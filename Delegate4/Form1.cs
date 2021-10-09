using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate4
{
    public delegate int Calc(int a, int b);
    
    public partial class Form1 : Form
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        public Calc calcAdd = new Calc(Add);
        static Calc calcSub = new Calc(Sub);
        public Form1()
        {
            InitializeComponent();
        }
        int a, b;
        
        private void txtBoxNum1_TextChanged(object sender, EventArgs e)
        {
            Button button = sender as Button;
            a = Convert.ToInt32(txtBoxNum1.Text);
            //a =int.Parse( button.Text);
           // a = int.Parse(TxtBoxNum2.Text);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Button button = sender as Button;
             b = Convert.ToInt32(TxtBoxNum2.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            textResult.Text = calcSub(a, b).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            textResult.Text = calcAdd(a, b).ToString(); 
        }

    }
}
