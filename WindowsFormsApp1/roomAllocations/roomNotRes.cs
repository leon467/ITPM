using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1.roomAllocations
{
    class roomNotRes
    {
        public String room { get; set; }
        public String day { get; set; }
        public String startt { get; set; }
        public String endt { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Selecting data(Retrieve)
        public DataTable Select()
        {
            //Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Sql query
                string sql = "SELECT * FROM notResTime";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool Insert(roomNotRes rnr)
        {
            //Create default return type and setting value to false
            bool isSuccess = false;

            //Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql querry
                string sql = "INSERT INTO notResTime (room, day, startt, endt) VALUES (@room, @day, @startt, @endt)";
                //Creating sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating parameters to add data
                cmd.Parameters.AddWithValue("@room", rnr.room);
                cmd.Parameters.AddWithValue("@day", rnr.day);
                cmd.Parameters.AddWithValue("@startt", rnr.startt);
                cmd.Parameters.AddWithValue("@endt", rnr.endt);

                //Open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than 0. else value is 0.
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
