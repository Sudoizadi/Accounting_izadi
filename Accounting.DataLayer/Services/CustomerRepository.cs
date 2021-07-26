using Accounting.DataLayer.Repository;
using Accounting.ViewModels;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private string ConectionString = (@"Data Source=DESKTOP-JRFVGQ7\SQLSERVER2017;Initial Catalog=sudo_web;Integrated Security=true");


        public bool Delete(int ID, string table)
        {
            using (IDbConnection db = new SqlConnection(ConectionString))
            {
                try
                {

                    string query = $"Delete from {table} Where (id = @id)";
                    db.Execute(query, new { id = ID });
                    return true;

                }
                catch
                {
                    return false;
                }

            }
        }

        public List<Customer> Filters_Customer(string parameter)
        {
            using (IDbConnection db = new SqlConnection(ConectionString))
            {
                List<Customer> list;
                list = db.Query<Customer>("Filters_Customers", new { @filters = parameter }, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }

        }
        public List<ViewModel_GetName> Filters_Name(string parameter = "")
        {
            using (IDbConnection db = new SqlConnection(ConectionString))
            {
                if (parameter == "")
                {
                    List<ViewModel_GetName> list;
                    list = db.Query<ViewModel_GetName>("Filters_Name", new { @filters = parameter }, commandType: CommandType.StoredProcedure).ToList();
                    return list;
                }
                else
                {

                    List<ViewModel_GetName> list;
                    list = db.Query<ViewModel_GetName>("Filters_Name", new { @filters = parameter }, commandType: CommandType.StoredProcedure).ToList();
                    return list;

                }


            }

        }
        public int GetIDByName(string name)
        {
            using (IDbConnection db = new SqlConnection(ConectionString))
            {
                var res = (db.Query<int>("GetIDByName", new { @Name = name }, commandType: CommandType.StoredProcedure).ToList());

                return (int)res[0];

            }

        }

        public List<Customer> GetAll(string table)
        {


            using (IDbConnection db = new SqlConnection(ConectionString))
            {
                List<Customer> list;
                list = db.Query<Customer>($"Select * From {table}").ToList();

                return list;
            }



        }

        public List<Customer> GetById(int ID, string Table)
        {
            using (IDbConnection db = new SqlConnection(ConectionString))
            {
                List<Customer> list;
                list = db.Query<Customer>($"Select * From {Table} Where id = @ID", new { ID = ID }).ToList();
                return list;
            }

        }

        public bool Insert(Customer Info)
        {
            using (IDbConnection db = new SqlConnection(ConectionString))
            {
                try
                {

                    string query = "insert Into Customer (FULLNAME,MOBILE,EMAIL,ADDRESS,Image) Values (@FULLNAME,@MOBILE,@EMAIL,@ADDRESS,@Image)";
                    db.Execute(query, Info);
                    return true;
                    //string query = "Insert Into bee (type,inputdata,value,sala,saladata,pay) Values (@type,@inputdata,@value,@sala,@saladata,@pay)";
                    //db.Execute(query, add_honey);
                    //return true;
                }
                catch
                {
                    return false;
                }

            }

        }

        public bool Update(Customer Info)
        {
            using (IDbConnection db = new SqlConnection(ConectionString))
            {
                try
                {

                    string query = $"Update Customer Set FULLNAME=@FULLNAME,MOBILE=@MOBILE,EMAIL=@EMAIL,ADDRESS=@ADDRESS,Image=@Image Where ID = ID";
                    db.Execute(query, Info);
                    return true;

                }
                catch
                {
                    return false;
                }

            }


        }

        public bool Insert(Repository.Accounting Info)
        {
            using (IDbConnection db = new SqlConnection(ConectionString))
            {
                try
                {

                    string query = "InsertToAccounting";
                    db.Execute(query, new { @CustomerID = Info.CustomerID, @Amount = Info.Amount, @Time = Info.Time, @TypeID = Info.TypeID, @Description = Info.Description }, commandType: CommandType.StoredProcedure);
                    return true;

                }
                catch
                {
                    return false;
                }

            }

        }

        public List<Repository.Accounting> GetAccounting(int TypeID)
        {
            using (IDbConnection db = new SqlConnection(ConectionString))
            {
                List<Repository.Accounting> res;
                res = db.Query<Repository.Accounting>("GetAccounting", new { @TypeID = TypeID}, commandType: CommandType.StoredProcedure).ToList();
                return res;
            }
        }

        public string GetName_fromID(int ID)
        {
            using (IDbConnection db = new SqlConnection(ConectionString))
            {
                var res = (db.Query<string>("GetName_fromID", new { ID = ID }, commandType: CommandType.StoredProcedure).ToList());

                return res[0];
            }
        }

        public List<Repository.Accounting> GetById(int ID)
        {
            using (IDbConnection db = new SqlConnection(ConectionString))
            {
                List<Repository.Accounting> list;
                list = db.Query<Repository.Accounting>("SP_GetByID", new { ID = ID }, commandType: CommandType.StoredProcedure).ToList();
                return list;
            }

        }

        public bool Update(Repository.Accounting Info)
        {

            using (IDbConnection db = new SqlConnection(ConectionString))
            {
                try
                {

                    string query = "SP_Update_Accounting";
                    db.Execute(query, new { @ID = Info.ID, @CustomerID = Info.CustomerID, @Amount = Info.Amount, @Time = Info.Time, @TypeID = Info.TypeID, @Description = Info.Description }, commandType: CommandType.StoredProcedure);
                    return true;

                }
                catch
                {
                    return false;
                }

            }


        }

        public List<Login> GetAll()
        {
            using (IDbConnection db = new SqlConnection(ConectionString))
            {
                List<Login> list;
                list = db.Query<Login>("sp_GetAll",new {@TableName = "Login"}, commandType:CommandType.StoredProcedure).ToList();

                return list;
            }
        }

        public bool Update(Login Info)
        {
            using (IDbConnection db = new SqlConnection(ConectionString))
            {
                try
                {

                    string query = "SP_Update_Login";
                    db.Execute(query, new { @ID = Info.LoginID, @UserName = Info.UserName, @Password = Info.Password }, commandType: CommandType.StoredProcedure);
                    return true;

                }
                catch
                {
                    return false;
                }

            }
        }
    }

}
