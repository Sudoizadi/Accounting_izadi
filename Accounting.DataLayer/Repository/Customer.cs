using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repository
{
    public class Customer
    {
        public int ID { get; set; }
        public string FULLNAME { get; set; }
        public string MOBILE { get; set; }
        public string EMAIL { get; set; }
        public string ADDRESS { get; set; }
        public string Image { get; set; }
    }
}
