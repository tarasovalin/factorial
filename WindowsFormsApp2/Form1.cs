using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (EnteredValue.Text == "")
            {
                // If not int clear textbox text or Undo() last operation
                EnteredValue.Clear();
                ResultValue.Clear();
            }

            long a;
            if (!long.TryParse(EnteredValue.Text, out a))
            {
                // If not int clear textbox text or Undo() last operation
                EnteredValue.Clear();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EnteredValue.Text == String.Empty)
            {
                MessageBox.Show("Введите число!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnteredValue.Focus();
                return;
            }

            int value = Convert.ToInt32(EnteredValue.Text);
            if (value > 20)
            {
                MessageBox.Show("Число должно быть в диапазоне от 0 до 20!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnteredValue.Clear();
                EnteredValue.Focus();
                return;
            }


            Class1 c1 = new Class1();
            ResultValue.Text = c1.CountFactorial(long.Parse(EnteredValue.Text)).ToString();
        }


    }
}




