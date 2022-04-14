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
    public partial class statistics : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ARM.mdb";
        private OleDbConnection myConnection;
        public statistics()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRMDataSet1.Выручка". При необходимости она может быть перемещена или удалена.
            this.выручкаTableAdapter.Fill(this.aRMDataSet1.Выручка);




        }
        public statistics(Admin f)
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Otchet af = new Otchet();
            af.Owner = this;
            af.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я овощ - мне нужна помощь!", "Внимание!");
            return;
        }

        private void Form7_Activated(object sender, EventArgs e)
        {
            this.выручкаTableAdapter.Fill(this.aRMDataSet1.Выручка);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox1.Text);
            string query = "DELETE FROM Выручка WHERE [Код] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные обновлены!");
            this.выручкаTableAdapter.Fill(this.aRMDataSet1.Выручка);
            textBox1.Clear();
        }

        private void statistics_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }
    }
}
