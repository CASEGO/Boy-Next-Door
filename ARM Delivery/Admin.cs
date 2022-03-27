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
    public partial class Admin : Form
    
    {
        public Admin()
        {
            InitializeComponent();
        }
        public Admin(pass f)
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            courierdata newForm = new courierdata(this);
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            statistics newForm = new statistics(this);
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FeedBacks newForm = new FeedBacks(this);
            newForm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
