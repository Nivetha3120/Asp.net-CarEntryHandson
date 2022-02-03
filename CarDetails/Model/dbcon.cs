using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CarDetails.Model
{
    public class dbcon
    {
        string connectionString = "Data Source = 100.72.130.5; Initial Catalog = Training; User ID = TrainingUsr; Password=Tr@ininGU$r@#321";
        public string insert(dbprop dp)
        {
            SqlConnection co = new SqlConnection(connectionString);
            co.Open();
            SqlCommand cmd = new SqlCommand("insert into CarEntryDetails values('"+dp.CarModel+"','"+dp.Category+"',"+dp.Price+","+dp.YearOfModel+",'"+dp.Description+"')", co);
            cmd.ExecuteNonQuery();
            co.Close();
            return "Saved Successfully";
        }

        public string update(dbprop dp)
        {
            SqlConnection co = new SqlConnection(connectionString);
            co.Open();
            SqlCommand cmd = new SqlCommand("update CarEntryDetails set Category='"+dp.Category+"',Price = "+dp.Price+",YearOfModel="+dp.YearOfModel+",Description='"+dp.Description+"' where CarModel = '"+dp.CarModel+"'",co);
            cmd.ExecuteNonQuery();
            co.Close();
            return "Updated Successfully";
        }


        public string delete(dbprop dp)
        {
            SqlConnection co = new SqlConnection(connectionString);
            co.Open();
            SqlCommand cmd = new SqlCommand("delete from CarEntryDetails where CarModel='"+dp.CarModel+"'",co);
            cmd.ExecuteNonQuery();
            co.Close();
            return "Deleted Successfully";
        }


        public DataTable Loaddb()
        {
            SqlConnection co = new SqlConnection(connectionString);
            SqlDataAdapter sd = new SqlDataAdapter("select * from CarEntryDetails", co);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            return dt;
        }
    }
}