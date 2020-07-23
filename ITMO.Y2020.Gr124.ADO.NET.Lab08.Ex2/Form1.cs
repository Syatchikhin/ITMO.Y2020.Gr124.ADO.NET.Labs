using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
// отключить горизонтаьную прокрутку ListView (1)
using System.Runtime.InteropServices;


namespace ITMO.Y2020.Gr124.ADO.NET.Lab08.Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // отключить горизонтаьную прокрутку ListView (II вар)
            //listView1.Items.Clear();
            //foreach (string newval in stringlist)
            //foreach (string newval in stringlist)
            //  listView1.Items.Add(newval);
            //listView1.Items.Add(0);
            //listView1.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.None);
            //listView1.Columns[0].Width = 310;
            //listView1.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);

            //listView1.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.None);
            //listView1.Columns[1].Width = 300;
            //listView1.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);

            //listView1.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.None);
            //listView1.Columns[2].Width = 300;
            //listView1.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);

            db = new DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True");
        }

        // отключить горизонтаьную прокрутку ListView
        //[DllImport("user32.dll")]
        //static public extern bool ShowScrollBar(System.IntPtr hWnd, int wBar, bool bShow);
        //private const uint SB_HORZ = 0; //Horrizontal Scroll
        //private const uint SB_VERT = 1; //Vertical Scroll
        //private const uint ESB_DISABLE_BOTH = 0x3;
        //private const uint ESB_ENABLE_BOTH = 0x0;

        //public void HideHorizontalScrollBar(ListView lv, int value, bool isNeeded)
        //{
        //    ShowScrollBar(lv.Handle, value, isNeeded);
        //}

        //private void ListViewHorrizontalScrollBar()
        //{
        //    0 for horrizontal
        //    1 for vertical

        //    _ListViewScrollOperation.HideHorizontalScrollBar(this.lvAntSetExcludedFiles, 0, false);
        //    _ListViewScrollOperation.HideHorizontalScrollBar(this.lvAntSetExcludedFiles, 1, true);
        //}


        DataContext db;

        private void button1_Click(object sender, EventArgs e)
        {
            var results = from c in db.GetTable<Customer>()
                          where c.City == "London"
                          select c;

            foreach (var c in results)
                listBox1.Items.Add(c.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.CustomerID = "WINGT";
            cust.City = "London";
            cust.CompanyName = "Steve Lasker";

            //проверка на повтор
            if ((from c in db.GetTable<Customer>()
                 where c.CustomerID == "WINGT"
                 select c).Count() == 0)
            {
                db.GetTable<Customer>().InsertOnSubmit(cust);
                db.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Повторное добавление");
               
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var deleteIndivCust =
               from cust in db.GetTable<Customer>()
               where cust.CustomerID == "WINGT"
               select cust;

            if (deleteIndivCust.Count() > 0)
            {
                db.GetTable<Customer>().DeleteOnSubmit(deleteIndivCust.First());
                db.SubmitChanges();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var custQuery =
                from cust in db.GetTable<Customer>()
                where cust.Orders.Any()
                select cust;

            foreach (var custObj in custQuery)
            {
                ListViewItem item =
                    listView1.Items.Add(custObj.CustomerID.ToString());
                item.SubItems.Add(custObj.City.ToString());
                item.SubItems.Add(custObj.Orders.Count.ToString());
            }
        }
    }
}
