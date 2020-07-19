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
using System.Configuration;

namespace ITMO.Y2020.Gr124.ADO.NET.LAB02Ex2
{
    public partial class Form2 : Form
    {
        //string connectionString =
        //@"Data Source=((LocalDB)\MSSQLLocalDB;Initial Catalog=Northwind; 
        //Integrated Security=true";
        //@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog = rNorthwind;
        //Integrated Security = True";
        //@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog = Northwind;
        //Integrated Security = True";
        public Form2()
        {
            InitializeComponent();

            this.connection.StateChange += new
            StateChangeEventHandler(this.connection_StateChange);

        }

        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }
        
        string connectionString =
        GetConnectionStringByName("DBConnect.NorthwindConnectionString");

        //Lesson 01 Ex4 
        private void connection_StateChange(object sender, StateChangeEventArgs e)
        {
            подключитьсяToolStripMenuItem.Enabled =
                (e.CurrentState == ConnectionState.Closed);
            асинхронПодклКБДToolStripMenuItem.Enabled =
                (e.CurrentState == ConnectionState.Closed);
            отключитьсяToolStripMenuItem.Enabled =
                (e.CurrentState == ConnectionState.Open);
        }


        SqlConnection connection = new SqlConnection();

        private void подключитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                //start task 1 - 2
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных " +
                    connection.Database + " выполнено успешно " + "\nСервер: " +
                    connection.DataSource);
                }
                else
                    MessageBox.Show("Соединение с базой данных уже  установлено");
            }
            //end task 1 - 2

            //start of task 3
            catch (SqlException XcpSQL)
            {
                foreach (SqlError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message, "Источник ошибки: " + se.Source,
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }
            }


            //end of task 3

            // begin again task 1-2
            //catch
            //{
            //    MessageBox.Show("Ошибка соединения с базой данных");

            //}
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void отключитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else
                MessageBox.Show("Соединение с базой данных уже закрыто");
        }

        private async void асинхронПодклКБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.ConnectionString = connectionString;
                        await connection.OpenAsync();
                    
                        MessageBox.Show("Соединение с базой данных " +
                        connection.Database + " выполнено успешно " + "\nСервер: " +
                        connection.DataSource);
                    }
                    else
                    MessageBox.Show("Соединение с базой данных уже установлено");
                }
                catch
                {
                MessageBox.Show("Ошибка соединения с базой данных");
                }

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void списокПодключенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection settings =
            ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    string str = String.Format("Name = {0}\nProviderName = {1}\nConnectionString = {2}", cs.Name, 
                    cs.ProviderName, cs.ConnectionString);
                    MessageBox.Show(str, "Параметры подключений");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (connection)
            { 
                    if (connection.State == ConnectionState.Closed)
                    {
                        MessageBox.Show("Сначала подключитесь к базе");
                        return;
                    }

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT COUNT(*) FROM Products";
                try
                {
                    int number = (int)command.ExecuteScalar();
                    label1.Text = number.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int number =
                WorkWithDataBase.ExecuteScalarMetod(connectionString, "SELECT COUNT(*) FROM Products"); 
                label2.Text = number.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("SELECT ProductName, UnitPrice, QuantityPerUnit FROM Products", connection);
                    connection.Open();
                    //SqlCommand command = connection.CreateCommand();
                    //command.CommandText = "SELECT ProductName FROM Products";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem newItem = listView1.Items.Add(reader["ProductName"].ToString());
                        //newItem.SubItems.Add(reader["UnitPrice"].ToString());
                        newItem.SubItems.Add(reader.GetDecimal(1).ToString());
                        newItem.SubItems.Add(reader["QuantityPerUnit"].ToString());
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }


    public class  WorkWithDataBase
    {
        public static int ExecuteScalarMetod(string cs, string qv)
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = qv;
                int number = (int)command.ExecuteScalar();
                return number;
            }

        }
    }
}
