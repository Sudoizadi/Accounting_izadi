using Accounting.DataLayer.Repository;
using Accounting.DataLayer.Services;
using Accounting.Utility;
using Accounting.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Business
{
    public class computation
    {

        public static ViewModel_Report report()

        {
            ICustomerRepository db = new CustomerRepository();
            ViewModel_Report vr = new ViewModel_Report();
            var receive = db.ReceivedOrPay().Where(c => c.TypeID == 1).Select(c => c.Amount).ToList();
            var pay = db.ReceivedOrPay().Where(c => c.TypeID == 2).Select(c => c.Amount).ToList();
            var minus = int.Parse(receive.SingleOrDefault().ToString()) - int.Parse(pay.SingleOrDefault().ToString());
            var number = db.ReceivedOrPay().Where(c => c.TypeID == 1).Select(c => c.number).ToList();
            vr.Pay = pay.SingleOrDefault().totoman();
            vr.Received = receive.SingleOrDefault().totoman();
            vr.Remaining = minus.totoman();
            vr.Number = number.SingleOrDefault().ToString();


            return vr;





        }



    }
}

