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
    public partial class orders : Form
    {
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ARM.mdb"; //Создание параметров подключения к базе данных
        private OleDbConnection myConnection;
        public orders()
        {
            InitializeComponent();
        }
        public orders(Home f)//Подключения к базе данных
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();// Закрытие формы
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.заказыTableAdapter.Fill(this.aRMDataSet1.Заказы); //Вывод данных из базы данных
        }
        private void button5_Click(object sender, EventArgs e) //Кнопка помощь
        {
            MessageBox.Show("Для поиска заказа введите код заказа и нажмите НАЙТИ ЗАКАЗ. Для Добовления заказа нажмите добавить заказ и заполните данные, затем нажмите ДОБАВИТЬ. Для удаления заказа введите код заказа и нажмите УДАЛИТЬ ЗАКАЗ. ", "Внимание!");
            return;
        }
        private void Form5_FormClosed(object sender, FormClosedEventArgs e) //При закрытии формы происходит отключение от базы данных
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)//Запрос на поиск
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "SELECT [Код заказа], [Номер заказа], [ФИО], [Дата доставки заказа], [Адрес заказа], [Номер телефона], [Блюдо], [Напиток], [Доставщик] FROM Заказы WHERE  [Код заказа] LIKE '%" + kod + "%' ";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }

        private void button6_Click(object sender, EventArgs e)//Обновление данных в таблице
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            dataGridView1.DataSource = заказыBindingSource;
            this.заказыTableAdapter.Fill(this.aRMDataSet1.Заказы);
        }
        private void button3_Click(object sender, EventArgs e) //Запрос на удаление
        {
            int kod = Convert.ToInt32(textBox2.Text);
            string query = "DELETE FROM Заказы WHERE [Код заказа] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные обновлены!");
            dataGridView1.DataSource = заказыBindingSource;
            this.заказыTableAdapter.Fill(this.aRMDataSet1.Заказы);
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e) //Открытие новой формы с добавлением заказа
        {
            AddOrders af = new AddOrders();
            af.Owner = this;
            af.Show();
        }
        private void Form5_Activated_1(object sender, EventArgs e) //При активном окне происходит обновление данных
        {
            dataGridView1.DataSource = заказыBindingSource;
            
            this.заказыTableAdapter.Fill(this.aRMDataSet1.Заказы);
        }
    }
}
