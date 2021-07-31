using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repository
{
    public class Products
    {
        public int ID { get; set; }
        public string NameProducts { get; set; }
        public int NumberProducts { get; set; }
        public int AmountProducts { get; set; }
        public string Command { get; set; }
        public string filters { get; set; }
    }
}
