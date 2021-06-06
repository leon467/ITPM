using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1.wdhClasses
{
    class wdhClass
    {
        //getters and setters
        public int Id { get; set; }
        public String noOfDays { get; set; }
        public String workDays { get; set; }
        public String Hours { get; set; }
        public String Mins { get; set; }

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
                string sql = "SELECT * FROM WDHTable";

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

        public bool insert(wdhClass W)
        {
            //create default return type and setting values to false
            bool isSuccess = false;

            //database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //sql query
                string sql = "INSERT INTO WDHTable(noOfDays,workDays, Hours,Mins) VALUES (@noOfDays,@workDays,@Hours,@Mins)";

                //creating sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating parameters to add data
                cmd.Parameters.AddWithValue("@noOfDays", W.noOfDays);
                cmd.Parameters.AddWithValue("@workDays", W.workDays);
                cmd.Parameters.AddWithValue("@Hours", W.Hours);
                cmd.Parameters.AddWithValue("@Mins", W.Mins);

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

        //update data
        public bool update(wdhClass W)
        {

            //create default return type and setting values to false
            bool isSuccess = false;

            //database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //sql query
                string sql = "UPDATE WDHTable SET noOfDays=@noOfDays, workDays=@workDays, Hours=@Hours, Mins=@Mins WHERE Id=@Id";

                //creating sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating parameters to add data
                cmd.Parameters.AddWithValue("@Id", W.Id);
                cmd.Parameters.AddWithValue("@noOfDays", W.noOfDays);
                cmd.Parameters.AddWithValue("@workDays", W.workDays);
                cmd.Parameters.AddWithValue("@Hours", W.Hours);
                cmd.Parameters.AddWithValue("@Mins", W.Mins);

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

        //Deleting data

        public bool delete(wdhClass W)
        {
            //Create default return type and setting value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql query
                string sql = "DELETE FROM WDHTable WHERE Id=@Id";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating parameters to add value
                cmd.Parameters.AddWithValue("@Id", W.Id);

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
