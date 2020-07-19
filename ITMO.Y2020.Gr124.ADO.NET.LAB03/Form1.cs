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

namespace ITMO.Y2020.Gr124.ADO.NET.LAB03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            using (sqlConnection1)
            {
                try
                {
                    sqlConnection1.Open();
                    SqlDataReader reader = sqlCommand1.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            results.Append(reader[i].ToString() + "\t");
                        }
                        results.Append(Environment.NewLine);
                    }

                    ResultsTextBox.Text = results.ToString();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    SqlTransaction sqlTran = connection.BeginTransaction();
            //    SqlCommand command = connection.CreateCommand();
            //    command.Transaction = sqlTran;
            //    try
            //    {
            //        command.CommandText =
            //       "INSERT INTO Products (ProductName, UnitPrice, QuantityPerUnit) VALUES('Wrong size', 12, '1 boxes')"; 
            //        command.ExecuteNonQuery();

            //        command.CommandText =
            //        "INSERT INTO Products (ProductName, UnitPrice, QuantityPerUnit) VALUES('Wrong color', 25, '100 ml')"; 
            //        command.ExecuteNonQuery();

            //        sqlTran.Commit();

            //        MessageBox.Show("Строки записаны в базу данных");
            //    }
            //    catch (SqlException ex)
            //    {
            //        MessageBox.Show(ex.Message, "Ошибка!",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        //
            //        try
            //        {
            //            sqlTran.Rollback();
            //        }
            //        catch (Exception exRollback)
            //        {
            //            MessageBox.Show(exRollback.Message);
            //        }
            //        //
            //    }

            //}
        }
    }
}
