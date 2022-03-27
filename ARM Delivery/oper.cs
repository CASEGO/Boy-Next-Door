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
    public partial class oper : Form
    {
        public oper()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FeedBacks newForm = new FeedBacks();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            statistics newForm = new statistics();
            newForm.Show();
        }
    }
}
