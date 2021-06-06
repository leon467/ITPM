using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1.sessionOptClasses
{
    class nonOverlap
    {
        //Getters and setters for carrying data
        public String id { get; set; }
        public String session1 { get; set; }
        public String session2 { get; set; }
        public String startTime { get; set; }
        public String day { get; set; }
        public String duration { get; set; }


        //for connecting database
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        // sellecting data(retrive)

        public DataTable Select()
        {
            // database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                // sql query
                string sql = "SELECT * FROM nonOverlapSession";
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

        //inserting data
        public bool Insert(nonOverlap no)
        {
            //Create default return type and setting value to false
            bool isSuccess = false;

            //Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql querry
                string sql = "INSERT INTO nonOverlapSession (session1, session2, startTime, day, duration) VALUES (@session1, @session2, @startTime, @day, @duration)";
                //Creating sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating parameters to add data
                cmd.Parameters.AddWithValue("@session1", no.session1);
                cmd.Parameters.AddWithValue("@session2", no.session2);
                cmd.Parameters.AddWithValue("@startTime", no.startTime);
                cmd.Parameters.AddWithValue("@day", no.day);
                cmd.Parameters.AddWithValue("@duration", no.duration);

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
