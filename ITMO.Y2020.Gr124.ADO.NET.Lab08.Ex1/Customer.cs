using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace ITMO.Y2020.Gr124.ADO.NET.Lab08.Ex1
{
     
    
    [Table(Name = "Customers")]
    public class Customer
    {
            private string _CustomerID;
            [Column(IsPrimaryKey = true, Storage = "_CustomerID")]
            public string CustomerID
            {
                get
                {
                    return this._CustomerID;
                }
                set
                {
                    this._CustomerID = value;
                }

            }

            private string _City;
            [Column(Storage = "_City")]
            public string City
            {
                get
                {
                    return this._City;
                }
                set
                {
                    this._City = value;
                }
            }

            private string _CompanyName;
            [Column(Storage = "_CompanyName")]
            public string CompanyName
            {
                get
                {
                    return this._CompanyName;
                }
                set
                {

                    this._CompanyName = value;
                }
            }

        public override string ToString()
        {
            return CustomerID + "\t" + City + "\t" + CompanyName;
        }
    }
}