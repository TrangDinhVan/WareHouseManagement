using System;
using System.Collections.Generic;
using System.Text;
//
using System.Data;
using WarehouseEntity;

namespace WarehouseDatabaseHelper
{
    public class CustomerDAL
    {
        public DataTable getAllCustomer()
        {
            string queryAll = "select * from [customer]";
            return new Connection().getListRecord(queryAll);
        }
        public DataTable getSomeCustomer(string query)
        {
            return new Connection().getListRecord(query);
        }
        public Customer getOneCustomer(int ID)
        {
            string queryOne = string.Format("select * from [customer] where customer_id = {0}", ID);
            DataRow r = new Connection().getOneRecord(queryOne);
            DataTable lstOrder = new OrderDAL().getSomeOrder(string.Format("select * from [order] where customer_id ={0}", ID));
            Customer cus = new Customer();
            cus.Id = ID;
            cus.Name = r["customer_name"].ToString();
            cus.Address = r["customer_address"].ToString();
            cus.Mail = r["customer_mail"].ToString();
            cus.Phone = r["customer_phone"].ToString();
            cus.Fax = r["customer_fax"].ToString();
            cus.LstOrder = lstOrder;
            return cus;
        }
        public int deleteCustomer(int ID)
        {
            string queryDelete = string.Format("delete from [customer] where customer_id = {0}", ID);
            return new Connection().exeNonQuery(queryDelete);
        }
        public int addCustomer(Customer cus)
        {
            string queryAdd = string.Format("insert into [customer] (cutomer_name, customer_address, customer_mail, customer_phone, customer_fax) Values('{0}','{1}','{2}','{3}','{4}')", cus.Name, cus.Address, cus.Mail, cus.Phone, cus.Fax);
            return new Connection().exeNonQuery(queryAdd);
        }
        public int updateCustomer(Customer cus)
        {
            string queryUpdate = string.Format("update [customer] set customer_name = '{0}', customer_address = '{1}', customer_mail = '{2}', customer_phone = '{3}', customer_fax = '{4}' where customer_id = {5} ", cus.Name, cus.Address, cus.Mail, cus.Phone, cus.Fax, cus.Id);
            return new Connection().exeNonQuery(queryUpdate);
        }
    }
}
