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

    public partial class Client : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ARM.mdb";
        private OleDbConnection myConnection;
        public Client()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRMDataSet1.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.aRMDataSet1.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRMDataSet1.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.aRMDataSet1.Клиенты);





        }
        public Client(Home f)
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
            MessageBox.Show("Для поиска в графу ввода впиши ФИО и нажми НАЙТИ КЛИЕНТА. Для удаления клиента в графу ввода впиши его код и нажми УДАЛИТЬ.", "Внимание!");
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
            textBox1.Clear();
            //"SELECT ФИО, Заказы FROM Клиенты WHERE ФИО LIKE '%" + Name + "%' " ; "SELECT  FROM Клиенты WHERE ФИО LIKE ='" + Name + "'";


        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            //dataGridView1.DataSource = клиентыTableAdapter;
            dataGridView1.DataSource = клиентыBindingSource;

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "DELETE FROM Клиенты WHERE [Код клиента] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные обновлены!");
            this.клиентыTableAdapter.Fill(this.aRMDataSet1.Клиенты);
            textBox1.Clear();
        }
    }
}
