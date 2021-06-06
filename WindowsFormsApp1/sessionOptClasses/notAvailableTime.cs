using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.sessionOptClasses
{
    class notAvailableTime
    {
        //Getters and setters for carrying data
        public String id { get; set; }
        public String sessionID { get; set; }
        public String type { get; set; }
        public String time { get; set; }


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
                string sql = "SELECT * FROM notAvailableTime";
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
        public bool Insert(notAvailableTime nat)
        {
            //Create default return type and setting value to false
            bool isSuccess = false;

            //Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql querry
                string sql = "INSERT INTO notAvailableTime (sessionID, type, time) VALUES (@sessionID, @type, @time)";
                //Creating sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating parameters to add data
                cmd.Parameters.AddWithValue("@sessionID", nat.sessionID);
                cmd.Parameters.AddWithValue("@type", nat.type);
                cmd.Parameters.AddWithValue("@time", nat.time);

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
