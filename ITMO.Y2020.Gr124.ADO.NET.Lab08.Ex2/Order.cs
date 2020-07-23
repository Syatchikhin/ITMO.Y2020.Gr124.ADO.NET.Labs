using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace ITMO.Y2020.Gr124.ADO.NET.Lab08.Ex2
{

    [Table(Name = "Orders")]
    public class Order
    {
        private int _OrderID = 0;
        private string _CustomerID;
        private EntityRef<Customer> _Customer;
        public Order() { this._Customer = new EntityRef<Customer>(); }

        [Column(Storage = "_OrderID", DbType = "Int NOT NULL IDENTITY",
        IsPrimaryKey = true, IsDbGenerated = true)]
        public int OrderID
        {
            get { return this._OrderID; }
        }

        [Column(Storage = "_CustomerID", DbType = "NChar(5)")]
        public string CustomerID
        {
            get { return this._CustomerID; }
            set { this._CustomerID = value; }
        }

        [Association(Storage = "_Customer", ThisKey = "CustomerID")]
        public Customer Customer
        {
            get { return this._Customer.Entity; }
            set { this._Customer.Entity = value; }
        }
        public override string ToString()
        {
            return CustomerID + "\t" + OrderID;
        }
    }


}