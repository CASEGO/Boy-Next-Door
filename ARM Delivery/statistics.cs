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
    public partial class statistics : Form
    {
        public statistics()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRMDataSet1.Выручка". При необходимости она может быть перемещена или удалена.
            this.выручкаTableAdapter.Fill(this.aRMDataSet1.Выручка);




        }
        public statistics(Admin f)
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Otchet af = new Otchet();
            af.Owner = this;
            af.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я овощ - мне нужна помощь!", "Внимание!");
            return;
        }

        private void Form7_Activated(object sender, EventArgs e)
        {
            this.выручкаTableAdapter.Fill(this.aRMDataSet1.Выручка);
        }
    }
}
