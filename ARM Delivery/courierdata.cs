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
    
    public partial class courierdata : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ARM.mdb";
        private OleDbConnection myConnection;
        public courierdata()
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aRMDataSet1.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.aRMDataSet1.Сотрудники);






        }
        public courierdata(Admin f)
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox9.Text);
            string query = "DELETE FROM Сотрудники WHERE [Код сотрудника] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные обновлены!");
            this.сотрудникиTableAdapter.Fill(this.aRMDataSet1.Сотрудники);
            textBox9.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для Увольнения сотрудника введите его код и нажмите УДАЛИТЬ. Для добавления сотрудника нажмите ДОБАВИТЬ и впишите все данные. Для изменения должности введите КОД СОТРУДНИКА и ДОЛЖНОСТЬ, Затем нажмите ИЗМЕНИТЬ.", "Внимание!");
            return;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.сотрудникиTableAdapter.Fill(this.aRMDataSet1.Сотрудники);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox9.Text);
            string query = "UPDATE Сотрудники SET Должность ='"+textBox1.Text + "' WHERE [Код сотрудника] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные обновлены!");
            this.сотрудникиTableAdapter.Fill(this.aRMDataSet1.Сотрудники);
            textBox9.Clear();
            textBox1.Clear();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            this.сотрудникиTableAdapter.Fill(this.aRMDataSet1.Сотрудники);
        }
    }
}
