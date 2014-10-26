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
            string queryAll = "select * from [staff]";
            return new Connection().getListRecord(queryAll);
        }
        public DataTable getSomeStaff(string query)
        {
            return new Connection().getListRecord(query);
        }
        public Staff getOneStaff(int ID)
        {
            string queryOne = string.Format("select * from [staff] where staff_id = {0}", ID);
            DataRow r = new Connection().getOneRecord(queryOne);
            DataTable lstRepo = new RepositoryDAL().getSomeRepo(string.Format("select * from [repository] where staff_id = {0}", ID));
            Staff staff = new Staff();
            staff.Name = r["staff_name"].ToString();
            staff.Permission = r["staff_permission"].ToString();
            staff.Address = r["staff_address"].ToString();
            staff.Phone = r["staff_phone"].ToString();
            staff.Mail = r["staff_mail"].ToString();
            staff.lstUndertakenRepo = lstRepo;
            return staff;            
        }
        public int deleteStaff(int ID)
        {
            string queryDelete = string.Format("delete from [staff] where staff_id = {0}", ID);
            return new Connection().exeNonQuery(queryDelete);
        }
        public int addStaff(Staff staff)
        {
            string queryAdd = string.Format(string.Format("insert into [staff] (staff_name, staff_permission, staff_address, staff_phone, staff_mail) values ('{0}','{1}','{2}','{3}','{4}')", staff.Name, staff.Permission, staff.Address, staff.Phone, staff.Mail));
            return new Connection().exeNonQuery(queryAdd);
        }
        public int updateStaff(Staff staff)
        {
            string queryUpdate = string.Format("update [staff] set staff_name = '{0}', staff_permission = '{1}', staff_address = '{2}', staff_phone = '{3}', staff_mail = '{4}'", staff.Name, staff.Permission, staff.Address, staff.Phone, staff.Mail);
            return new Connection().exeNonQuery(queryUpdate);
        }
    }
}
