using Accounting.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace Accounting.DataLayer.Repository
{
    public interface ICustomerRepository
    {

        List<Customer> GetAll(string table);
        List<Login> GetAll();
        List<Customer> GetById(int ID,string Table);
        List<Accounting> GetById(int ID);
        List<Customer> Filters_Customer(string parameter);
        List<ViewModel_GetName> Filters_Name(string parameter ="");
        int GetIDByName(string name);
        bool Insert(Customer Info);
        bool Insert(Accounting Info);
        bool Update(Accounting Info);
        bool Update(Customer Info);
        bool Update(Login Info);
        bool Delete(int ID , string table);
        List<Accounting> GetAccounting(int TypeID);
        string GetName_fromID(int ID);
       
    }
}