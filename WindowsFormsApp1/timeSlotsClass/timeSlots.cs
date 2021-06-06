using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1.timeSlotsClass
{
    class timeSlots
    {
        //getters and setters
        public int Id { get; set; }
        public String day { get; set; }
        public String timeSlot { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //retrive data
        public DataTable select()
        {
            //database connection

            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable Dt = new DataTable();
            try
            {
                //sql query
                string sql = "SELECT * FROM timeSlots";

                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create sql data adapt a using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(Dt);
            }

            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return Dt;
        }


        //inserting data

        public bool insert(timeSlots t)
        {
            //create default return type and setting values to false
            bool isSuccess = false;

            //database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //sql query
                string sql = "INSERT INTO timeSlots(day, timeSlot) VALUES (@day, @timeSlot)";

                //creating sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating parameters to add data
                cmd.Parameters.AddWithValue("@day", t.day);
                cmd.Parameters.AddWithValue("@timeSlot", t.timeSlot);

                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the query runs successfully then the value of the rows will be grater than zero or will be zero
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
