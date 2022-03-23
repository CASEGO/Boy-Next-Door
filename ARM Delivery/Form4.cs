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

    public partial class Form4 : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ARM.mdb";
        private OleDbConnection myConnection;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRMDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.aRMDataSet.Клиенты);


        }
        public Form4(Form1 f)
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я овощ - мне нужна помощь!", "Внимание!");
            return;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Name = textBox1.Text;
            string query = "SELECT [Код клиента], ФИО, Заказы, Телефон, Адрес FROM Клиенты WHERE  ФИО LIKE '%" + Name + "%' ";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
            //"SELECT ФИО, Заказы FROM Клиенты WHERE ФИО LIKE '%" + Name + "%' " ; "SELECT  FROM Клиенты WHERE ФИО LIKE ='" + Name + "'";


        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            dataGridView1.DataSource = клиентыBindingSource;
            this.клиентыTableAdapter.Fill(this.aRMDataSet.Клиенты);
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }
    }
}
