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
    public partial class AddForm : Form
    {
        DataBase db = new DataBase();

        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ARM.mdb";
        private OleDbConnection myConnection;

        public AddForm()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name, Time, ZP, Phone, Status, Stavka;
            int kod = Convert.ToInt32(textBox8.Text);
            Name = textBox1.Text;
            Time = textBox5.Text;
            ZP = textBox6.Text;
            Phone = textBox7.Text;
            Status = textBox3.Text;
            Stavka = textBox2.Text;
            string query = "INSERT INTO Сотрудники VALUES (" + kod + ", '" + Name + "', " + Time + "," + ZP + "," + Phone + "," + Status + "," + Stavka + ") ";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные обновлены!"); //string query = "INSERT INTO Сотрудники VALUES (" + kod + ", '" + Name + "', " + Time + ", " + ZP + ", " + Phone + "," + Status + "," + Stavka + ")";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
