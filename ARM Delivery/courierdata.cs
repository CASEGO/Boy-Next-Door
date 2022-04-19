using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;// Подключение библиотеки

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
    public partial class courierdata : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ARM.mdb"; //Обозначение базы данных
        private OleDbConnection myConnection;
        public courierdata()
        {
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.сотрудникиTableAdapter.Fill(this.aRMDataSet1.Сотрудники);// Вывод информации из БД при открытии окна
        }
        public courierdata(Admin f)
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);//Подключение к БД
            myConnection.Open();
        }

        private void button3_Click(object sender, EventArgs e)//Кнопка выход
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//Кнопка добавления сотрудника
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)//Кнопка увольнения сотрудника
        {
            int kod = Convert.ToInt32(textBox9.Text);
            string query = "DELETE FROM Сотрудники WHERE [Код сотрудника] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные обновлены!");
            this.сотрудникиTableAdapter.Fill(this.aRMDataSet1.Сотрудники);
            textBox9.Clear();
        }
        private void button4_Click(object sender, EventArgs e)//Кнопка помощи
        {
            MessageBox.Show("Для Увольнения сотрудника введите его код и нажмите УДАЛИТЬ." +
                " Для добавления сотрудника нажмите ДОБАВИТЬ и впишите все данные. Для изменения должности введите КОД СОТРУДНИКА и ДОЛЖНОСТЬ, Затем нажмите ИЗМЕНИТЬ.", "Внимание!");
            return;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)// при закрытии формы происходит разрыв соединения с БД
        {
            myConnection.Close();
        }

        private void button5_Click(object sender, EventArgs e)// Обновление БД
        {

            this.сотрудникиTableAdapter.Fill(this.aRMDataSet1.Сотрудники);
        }

        private void button6_Click(object sender, EventArgs e) //Запрос на изменение должности сотрудника
        {
            int kod = Convert.ToInt32(textBox2.Text);
            string query = "UPDATE Сотрудники SET Должность ='"+textBox1.Text + "' WHERE [Код сотрудника] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные обновлены!");
            this.сотрудникиTableAdapter.Fill(this.aRMDataSet1.Сотрудники);
            textBox2.Clear();
            textBox1.Clear();
        }
        private void Form3_Activated(object sender, EventArgs e)// При активной форме идет обновление таблиц из БД
        {
            this.сотрудникиTableAdapter.Fill(this.aRMDataSet1.Сотрудники);
        }
    }
}
