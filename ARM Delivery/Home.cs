using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb; 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)//Кнопка "Выход"
        {
            this.Close(); 
        }
        private void button3_Click(object sender, EventArgs e)//Кнопка открытия окна "авторизации"
        {
            pass newForm = new pass(this); 
            newForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)//Кнопка открытия окна "заказы"
        {
            orders newForm = new orders(this); 
            newForm.Show();
        }
        private void button2_Click(object sender, EventArgs e) //Кнопка открытия онка "клиенты"
        {
            Client newForm = new Client(this);
            newForm.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}