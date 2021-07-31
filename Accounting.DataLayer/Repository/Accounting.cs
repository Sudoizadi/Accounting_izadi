using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repository
{
    public class Accounting
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int TypeID { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public DateTime Time { get; set; }
        

    }
}
