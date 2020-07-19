using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ITMO.Y2020.Gr124.ADO.NET.LAB04.Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static SqlConnection NorthwindConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=northwind;Integrated Security=True");

        static string query = "SELECT * FROM Customers";

        //create adapter
        static SqlDataAdapter SqlDataAdapter1 = new SqlDataAdapter(query, NorthwindConnection);

        DataSet NorthwindDataset = new DataSet("Northwind");

        //Call constructor
        SqlCommandBuilder commands = new SqlCommandBuilder(SqlDataAdapter1);

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter1.Fill(NorthwindDataset, "Customers");
            dataGridView1.DataSource = NorthwindDataset.Tables["Customers"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NorthwindDataset.EndInit();
            SqlDataAdapter1.Update(NorthwindDataset.Tables["Customers"]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Button 2 scenario without any limitations----------
            DataRow CustRow = NorthwindDataset.Tables["Customers"].NewRow();
            Object[] CustRecord =  {"AAAAB", "Alfreds Futterkiste", "Maria Anders", "Sales Representative", "Obere Str. 57", "Berlin", null, 
            "12209", "Germany", "030-0074321","030-0076545"};
            CustRow.ItemArray = CustRecord;
            NorthwindDataset.Tables["Customers"].Rows.Add(CustRow);

            SqlDataAdapter1.Update(NorthwindDataset.Tables["Customers"]);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NorthwindDataset.EndInit();
            var index = dataGridView1.CurrentRow.Index;
            NorthwindDataset.Tables["Customers"].Rows[index].Delete();

            SqlDataAdapter1.Update(NorthwindDataset.Tables["Customers"]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //LIKE Button 2 scenario, BUT with TRY-CATCH----------
            try
            {
                DataRow CustRow = NorthwindDataset.Tables["Customers"].NewRow();
                Object[] CustRecord =  {"AAAAB", "Alfreds Futterkiste", "Maria Anders", "Sales Representative", "Obere Str. 57", "Berlin", null,
                "12209", "Germany", "030-0074321","030-0076545"};
                CustRow.ItemArray = CustRecord;
                NorthwindDataset.Tables["Customers"].Rows.Add(CustRow);

                SqlDataAdapter1.Update(NorthwindDataset.Tables["Customers"]);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка вставки! Такие данные уже имеются, измените данные первичного ключа",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Удалить неверную строку
                NorthwindDataset.EndInit();
                var index = dataGridView1.CurrentRow.Index;
                NorthwindDataset.Tables["Customers"].Rows[index].Delete();

                SqlDataAdapter1.Update(NorthwindDataset.Tables["Customers"]);
            }




        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
