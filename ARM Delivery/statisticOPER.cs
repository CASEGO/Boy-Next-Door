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
    public partial class statisticOPER : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ARM.mdb";
        private OleDbConnection myConnection;
        public statisticOPER()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void statisticOPER_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRMDataSet1.Выручка". При необходимости она может быть перемещена или удалена.
            this.выручкаTableAdapter.Fill(this.aRMDataSet1.Выручка);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Otchet af = new Otchet();
            af.Owner = this;
            af.Show();
        }

        private void statisticOPER_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }

        private void statisticOPER_Activated(object sender, EventArgs e)
        {
            this.выручкаTableAdapter.Fill(this.aRMDataSet1.Выручка);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь вы можете просмотреть и добавить отчеты!", "Внимание!");
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
