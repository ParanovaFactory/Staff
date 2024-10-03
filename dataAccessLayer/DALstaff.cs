using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entityLayer;

namespace dataAccessLayer
{
    public class DALstaff
    {
        public static List<entityStaff> staffListing()
        {
            List<entityStaff> values = new List<entityStaff>();
            SqlCommand cmd = new SqlCommand("select * from TblStaffs", SQLConnection.connection);
            if (cmd.Connection.State != ConnectionState.Open) 
            {
                cmd.Connection.Open();
            }
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read()) 
            { 
                entityStaff entityStaff = new entityStaff();
                entityStaff.StaffId = int.Parse(reader["staffId"].ToString());
                entityStaff.StaffName = reader["staffName"].ToString();
                entityStaff.StaffSurname = reader["staffSurname"].ToString();
                entityStaff.StaffCity = reader["staffCity"].ToString();
                entityStaff.StaffDepartment = reader["staffDepartment"].ToString();
                entityStaff.StaffSalary = short.Parse(reader["staffSalary"].ToString());
                values.Add(entityStaff);
            }
            reader.Close();
            return values;
        }

        public static int staffSave(entityStaff entityStaff)
        {
            SqlCommand cmd = new SqlCommand("insert into TblStaffs (staffName, staffSurname, staffCity, staffDepartment, staffSalary) values (@p1,@p2,@p3,@p4,@p5)", SQLConnection.connection);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1", entityStaff.StaffName);
            cmd.Parameters.AddWithValue("@p2", entityStaff.StaffSurname);
            cmd.Parameters.AddWithValue("@p3", entityStaff.StaffCity);
            cmd.Parameters.AddWithValue("@p4", entityStaff.StaffDepartment);
            cmd.Parameters.AddWithValue("@p5", entityStaff.StaffSalary);
            return cmd.ExecuteNonQuery();
        }

        public static int staffDelete(entityStaff entityStaff)
        {
            SqlCommand cmd = new SqlCommand("delete from TblStaffs where staffId = @p1", SQLConnection.connection);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1", entityStaff.StaffId);
            return cmd.ExecuteNonQuery();
        }

        public static int staffUpdate(entityStaff entityStaff)
        {
            SqlCommand cmd = new SqlCommand("update TblStaffs set staffName=@p1, staffSurname=@p2, staffCity=@p3, staffDepartment=@p4, staffSalary=@p5 where staffId = @p6", SQLConnection.connection);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1", entityStaff.StaffName);
            cmd.Parameters.AddWithValue("@p2", entityStaff.StaffSurname);
            cmd.Parameters.AddWithValue("@p3", entityStaff.StaffCity);
            cmd.Parameters.AddWithValue("@p4", entityStaff.StaffDepartment);
            cmd.Parameters.AddWithValue("@p5", entityStaff.StaffSalary);
            cmd.Parameters.AddWithValue("@p6", entityStaff.StaffId);
            return cmd.ExecuteNonQuery();
        }
    }
}
