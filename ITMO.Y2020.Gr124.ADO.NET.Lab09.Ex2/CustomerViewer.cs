using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
//using System.Data.Entity.Entitystate;
using CodeFirst;

namespace ITMO.Y2020.Gr124.ADO.NET.Lab09.Ex2
{
    public partial class CustomerViewer : Form
    {
        public CustomerViewer()
        {
            InitializeComponent();
           Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SampleContext>());

        }

        SampleContext context = new SampleContext();
        byte[] Ph;


        private void buttonAdd_Click(object sender, EventArgs e) //Добавить данные
        {
            try
            {
                Customer customer = new Customer
                {
                    FirstName = this.textBoxname.Text,
                    LastName = this.textBoxname.Text,
                    Email = this.textBoxmail.Text,
                    Age = Int32.Parse(this.textBoxage.Text),
                    Photo = Ph,
                    Orders = orderlistBox.SelectedItems.OfType<Order>().ToList() //see p 80
                };
                context.Customers.Add(customer);
                context.SaveChanges();
                Output(); // see p 79
                textBoxname.Text = String.Empty;
                textBoxlastname.Text = String.Empty;
                textBoxmail.Text = String.Empty;
                textBoxage.Text = String.Empty;
                //присвоение полю Orders выбранных заказов


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }


        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                Image bm = new Bitmap(diag.OpenFile());

                ImageConverter converter = new ImageConverter();
                Ph = (byte[])converter.ConvertTo(bm, typeof(byte[]));
            }
        }

        private void Output()
        {
            if (this.CustomerradioButton.Checked == true)
                GridView.DataSource = context.Customers.ToList();
            else if (this.OrderradioButton.Checked == true)
                GridView.DataSource = context.Orders.ToList();

            else if (this.VipOrderRadioButton.Checked == true)
                GridView.DataSource = context.VipOrders.ToList();

        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            Output();


        }

        private void customerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var query = from b in context.Customers
            //            orderby b.FirstName
            //            select b;

            //customerList.DataSource = query.ToList();
        }


        private void CustomerViewer_Load(object sender, EventArgs e)
        {
            context.Orders.Add(new Order
            {
                ProductName = "Аудио",
                Quantity = 12,
                PurchaseDate = DateTime.Parse("16.08.2020")
            });
            context.Orders.Add(new Order
            {
                ProductName = "Видео",
                Quantity = 22,
                PurchaseDate = DateTime.Parse("16.08.2020")
            });
            context.SaveChanges();
            orderlistBox.DataSource = context.Orders.ToList();

            context.VipOrders.Add(new VipOrder
            {
                ProductName = "Авто",
                Quantity = 101,
                PurchaseDate = DateTime.Parse("16.08.2020"),
                status = "Высокий"
            });

            var query = from b in context.Customers
                        orderby b.FirstName
                        select b;

            customerList.DataSource = query.ToList();


        }

        private void orderlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridView.CurrentRow == null) return;
                var customer = GridView.CurrentRow.DataBoundItem as Customer;
                if (customer == null) return;

            labelid.Text = Convert.ToString(customer.CustomerId);
            textBoxCustomer.Text = customer.ToString();

            textBoxname.Text = customer.FirstName;

            textBoxlastname.Text = customer.LastName;
            textBoxmail.Text = customer.Email; 
            textBoxage.Text = Convert.ToString(customer.Age);

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (labelid.Text == String.Empty) return;

            var id = Convert.ToInt32(labelid.Text);
            var customer = context.Customers.Find(id);
            if (customer == null) return;

            customer.FirstName = this.textBoxname.Text;
            customer.LastName = this.textBoxlastname.Text;
            customer.Email = this.textBoxmail.Text;
            customer.Age = Int32.Parse(this.textBoxage.Text);

            context.Entry(customer).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();
            Output();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (labelid.Text == String.Empty) return;

            var id = Convert.ToInt32(labelid.Text);
            var customer = context.Customers.Find(id);

            context.Entry(customer).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
            Output();
        }

    }   

}
