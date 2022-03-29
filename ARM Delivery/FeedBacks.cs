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
    public partial class FeedBacks : Form
    {
        public FeedBacks()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRMDataSet1.Отзывы". При необходимости она может быть перемещена или удалена.
            this.отзывыTableAdapter.Fill(this.aRMDataSet1.Отзывы);


        }
        public FeedBacks(Admin f)
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь можно просмотреть отзывы.", "Внимание!");
            return;
        }
    }
}
