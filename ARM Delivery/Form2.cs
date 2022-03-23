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
    public partial class Form2 : Form
    
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 f)
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3(this);
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7(this);
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 newForm = new Form6(this);
            newForm.Show();
        }
    }
}
