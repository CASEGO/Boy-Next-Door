﻿using System;
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

    public partial class Form8 : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ARM.mdb";
        private OleDbConnection myConnection;
        public Form8()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string NZ = textBox2.Text;
            string Name = textBox3.Text;
            string Time = textBox4.Text;
            string Adres = textBox5.Text;
            string Phone = textBox6.Text;
            string dish = textBox7.Text;
            string drink = textBox8.Text;
            string courier = textBox9.Text;
            string query = "INSERT INTO Заказы ([Код заказа],[Номер заказа],[ФИО],[Дата доставки заказа],[Адрес заказа],[Номер телефона],[Блюдо],[Напиток],[Доставщик]) VALUES(" + kod + ",'" + NZ + "','" + Name + "', '" + Time + "','" + Adres + "','" + Phone + "', '" + dish + "','" + drink + "','" + courier + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные обновлены!");
            this.Close();
        }
    }
}
