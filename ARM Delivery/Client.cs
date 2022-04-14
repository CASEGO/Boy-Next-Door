





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//Подключение библиотеки 


namespace ARM_Delivery
{
    //⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠟⠛⠉⠉⠉⠉⠉⠉⠙⠛⠻⢿⣿⣿⣿⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⢿⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⣿⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⢰⣿⣿⣿⣿⣷⣶⣤⡀⢀⣼⣿⣿⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠙⠛⠿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠛⠻⢿⣿⣿⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢿⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣦⣤⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠙⠻⣿⣿⣿⣿⣿⣿⣿⣷⡄⠀⠀⠀⠀⠀⠀⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⡿⠋⠀⠀⠀⠀⠉⠙⠛⠛⠛⠛⠛⠁⠀⠀⠀⠀⠀⠀⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⣷⣦⣄⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣾⣿⣿⣿
    //⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⣿⣿⣿⣿⣿⣿
    public partial class Client : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ARM.mdb";//Обозначение параметров подключения к БД
        private OleDbConnection myConnection;
        public Client()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)//При загрузке происходит вывод данных с БД
        {
            this.клиентыTableAdapter.Fill(this.aRMDataSet1.Клиенты);
        }
        public Client(Home f)
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);//Открытие подключения к БД
            myConnection.Open();
        }

        private void button2_Click(object sender, EventArgs e)//Кнопка выхода
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)//Кнопка Помощь
        {
            MessageBox.Show("Для поиска в графу ввода впиши ФИО и нажми НАЙТИ КЛИЕНТА. Для удаления клиента в графу ввода впиши его код и нажми УДАЛИТЬ. Для изменения статуса впиши код клиента и нажми ИЗМЕНИТЬ СТАТУС." , "Внимание!");
            return;
        }
        private void button1_Click(object sender, EventArgs e) //Запрос на поиск клиента
        {

            string Name = textBox1.Text;
            string query = "SELECT [Код клиента], ФИО, Заказы, Телефон, Адрес FROM Клиенты WHERE  ФИО LIKE '%" + Name + "%' ";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
            textBox1.Clear();
        }
        private void button4_Click(object sender, EventArgs e) //Обновление данных из БД
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            dataGridView1.DataSource = клиентыBindingSource;
        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)//При закрытии формы соединение с БД закрывается
        {
            myConnection.Close();
        }
        private void button5_Click(object sender, EventArgs e) //Запрос на удаление клиента
        {
            int kod = Convert.ToInt32(textBox2.Text);
            string query = "DELETE FROM Клиенты WHERE [Код клиента] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные обновлены!");
            this.клиентыTableAdapter.Fill(this.aRMDataSet1.Клиенты);
            textBox2.Clear();
        }

        private void button6_Click(object sender, EventArgs e) //Запрос на изменение статуса заказа у клиента
        {
            int kod = Convert.ToInt32(textBox2.Text);
            bool stat = true;
            string status = "UPDATE [Клиенты] SET [Статус заказа] =" + stat + " WHERE [Код клиента] = " + kod;
            OleDbCommand command = new OleDbCommand(status, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные обновлены!");
            this.клиентыTableAdapter.Fill(this.aRMDataSet1.Клиенты);
            textBox2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
