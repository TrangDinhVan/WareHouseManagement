using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;
//
using System.Data;
using WarehouseEntity;

namespace WarehouseDatabaseHelper
{
    public class CustomerDAL
    {
        public DataTable GetAllCustomer()
        {
            string queryAll = "select * from [v_customer]";
            return new Connection().GetListRecord(queryAll);
        }
        public DataTable GetSomeCustomer(string query)
        {
            return new Connection().GetListRecord(query);
        }
        public Customer GetOneCustomer(int ID)
        {
            string queryOne = string.Format("select * from [customer] where customer_id = {0}", ID);
            DataRow r = new Connection().GetOneRecord(queryOne);
            DataTable lstOrder = new OrderDAL().GetSomeOrder(string.Format("select * from [order] where customer_id ={0}", ID));
            Customer cus = new Customer
            {
                Id = ID,
                Name = r["customer_name"].ToString(),
                Address = r["customer_address"].ToString(),
                Mail = r["customer_mail"].ToString(),
                Phone = r["customer_phone"].ToString(),
                Fax = r["customer_fax"].ToString(),
                LstOrder = lstOrder
            };
            return cus;
        }
        public int DeleteCustomer(int ID)
        {
            string queryDelete = string.Format("delete from [customer] where customer_id = {0}", ID);
            return new Connection().ExeNonQuery(queryDelete);
        }
        public int AddCustomer(Customer cus)
        {
            string queryAdd = string.Format("insert into [customer] (customer_name, customer_address, customer_mail, customer_phone, customer_fax) Values('{0}','{1}','{2}','{3}','{4}')", cus.Name, cus.Address, cus.Mail, cus.Phone, cus.Fax);
            return new Connection().ExeNonQuery(queryAdd);
        }
        public int UpdateCustomer(Customer cus)
        {
            string queryUpdate = string.Format("update [customer] set customer_name = '{0}', customer_address = '{1}', customer_mail = '{2}', customer_phone = '{3}', customer_fax = '{4}' where customer_id = {5} ", cus.Name, cus.Address, cus.Mail, cus.Phone, cus.Fax, cus.Id);
            return new Connection().ExeNonQuery(queryUpdate);
        }

        public int GetScopeIdentity()
        {
            string queryScopeIdentiy = string.Format("select max([customer_id]) from [customer]");
            DataRow r = new Connection().GetOneRecord(queryScopeIdentiy);
            return Convert.ToInt32(r[0].ToString());
        }
    }
}
