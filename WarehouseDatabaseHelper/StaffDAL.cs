using System;
using System.Collections.Generic;
using System.Text;
//
using System.Data;
using WarehouseEntity;

namespace WarehouseDatabaseHelper
{
    public class StaffDAL
    {
        public DataTable getAllStaff()
        {
            string queryAll = "select * from [v_staff]";
            return new Connection().GetListRecord(queryAll);
        }
        public DataTable GetSomeStaff(string query)
        {
            return new Connection().GetListRecord(query);
        }
        public Staff GetOneStaff(int ID)
        {
            string queryOne = string.Format("select * from [staff] where staff_id = {0}", ID);
            DataRow r = new Connection().GetOneRecord(queryOne);
            DataTable lstRepo = new RepositoryDAL().GetSomeRepo(string.Format("select * from [repository] where staff_id = {0}", ID));
            Staff staff = new Staff
            {
                Id = ID,
                Name = r["staff_name"].ToString(),
                Pass = r["staff_pass"].ToString(),
                Permission = r["staff_permission"].ToString(),
                Address = r["staff_address"].ToString(),
                Phone = r["staff_phone"].ToString(),
                Mail = r["staff_mail"].ToString(),
                LstUndertakenRepo = lstRepo
            };
            return staff;            
        }
        public int DeleteStaff(int ID)
        {
            string queryDelete = string.Format("delete from [staff] where staff_id = {0}", ID);
            return new Connection().ExeNonQuery(queryDelete);
        }
        public int AddStaff(Staff staff)
        {
            string queryAdd = string.Format("insert into [staff] (staff_name, staff_pass, staff_permission, staff_address, staff_phone, staff_mail) values ('{0}','{1}','{2}','{3}','{4}','{5}')", staff.Name, staff.Pass, staff.Permission, staff.Address, staff.Phone, staff.Mail);
            return new Connection().ExeNonQuery(queryAdd);
        }
        public int UpdateStaff(Staff staff)
        {
            string queryUpdate = string.Format("update [staff] set staff_name = '{0}', staff_permission = '{1}', staff_address = '{2}', staff_phone = '{3}', staff_mail = '{4}', staff_pass = '{5}' where staff_id = {6}", staff.Name, staff.Permission, staff.Address, staff.Phone, staff.Mail, staff.Pass, staff.Id);
            return new Connection().ExeNonQuery(queryUpdate);
        }
    }
}
