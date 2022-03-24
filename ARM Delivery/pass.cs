using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM_Delivery
{
    public partial class pass : Form
    {
        public pass()
        {
            InitializeComponent();
        }
        public pass(Form1 f)
        {
            InitializeComponent();

        }
        private void pass_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "passadm")
            {
                Form2 af = new Form2();
                af.Show();
                this.Close();

            }
            if (textBox1.Text == "operator" && textBox2.Text == "passoper")
            {
                oper af = new oper();
                af.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
