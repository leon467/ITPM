using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1.roomAllocations
{
    class roomGrp
    {
        public String room { get; set; }
        public String grp { get; set; }
        public String sub { get; set; }

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
                string sql = "SELECT * FROM grpRoom";
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

        public bool Insert(roomGrp rg)
        {
            //Create default return type and setting value to false
            bool isSuccess = false;

            //Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql querry
                string sql = "INSERT INTO grpRoom (room, grp, sub) VALUES (@room, @grp, @sub)";
                //Creating sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating parameters to add data
                cmd.Parameters.AddWithValue("@room", rg.room);
                cmd.Parameters.AddWithValue("@grp", rg.grp);
                cmd.Parameters.AddWithValue("@sub", rg.sub);

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
