using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ARM_Delivery
{
    public partial class Form5 : Form
        
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ARM.mdb";
        private OleDbConnection myConnection;
        public Form5()
        {
            InitializeComponent();
        }
        public Form5(Form1 f)
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
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
            MessageBox.Show("Для поиска заказа введите код заказа и нажмите НАЙТИ ЗАКАЗ. Для Добовления заказа нажмите добавить заказ и заполните данные, затем нажмите ДОБАВИТЬ. Для удаления заказа введите код заказа и нажмите УДАЛИТЬ ЗАКАЗ. ", "Внимание!");
            return;
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "SELECT [Код заказа], [Номер заказа], [ФИО], [Дата доставки заказа], [Адрес заказа], [Номер телефона], [Блюдо], [Напиток], [Доставщик] FROM Заказы WHERE  [Код заказа] LIKE '%" + kod + "%' ";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            dataGridView1.DataSource = заказыBindingSource;
            this.заказыTableAdapter.Fill(this.aRMDataSet1.Заказы);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "DELETE FROM Заказы WHERE [Код заказа] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные обновлены!");
            dataGridView1.DataSource = заказыBindingSource;
            this.заказыTableAdapter.Fill(this.aRMDataSet1.Заказы);
        }
    }
}
