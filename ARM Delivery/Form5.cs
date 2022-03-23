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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public Form5(Form1 f)
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRMDataSet1.Заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.aRMDataSet1.Заказы);



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я овощ - мне нужна помощь!", "Внимание!");
            return;
        }
    }
}
