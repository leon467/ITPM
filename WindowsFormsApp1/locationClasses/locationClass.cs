using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1.locationClasses
{
    class locationClass
    {
        //Getters and setters for carrying data

        public String room { get; set; }
        public String building { get; set; }
        public String room_type { get; set; }
        public String capacity { get; set; }

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
                string sql = "SELECT * FROM locations";
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

        //Inserting data(Creating)

        public bool Insert(locationClass l)
        {
            //Create default return type and setting value to false
            bool isSuccess = false;

            //Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql querry
                string sql = "INSERT INTO locations (room, building, room_type, capacity) VALUES (@room, @building, @room_type, @capacity)";
                //Creating sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating parameters to add data
                cmd.Parameters.AddWithValue("@room", l.room);
                cmd.Parameters.AddWithValue("@building", l.building);
                cmd.Parameters.AddWithValue("@room_type", l.room_type);
                cmd.Parameters.AddWithValue("@capacity", l.capacity);

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

        //Updating data

        public bool Update(locationClass l)
        {
            //Create default return type and setting value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql query
                string sql = "UPDATE locations SET room=@room, building=@building, room_type=@room_type, capacity=@capacity WHERE room=@room";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating parameters to add value
                cmd.Parameters.AddWithValue("@room", l.room);
                cmd.Parameters.AddWithValue("@building", l.building);
                cmd.Parameters.AddWithValue("@room_type", l.room_type);
                cmd.Parameters.AddWithValue("@capacity", l.capacity);

                //Open database conection
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

        //Deleting data

        public bool Delete(locationClass l)
        {
            //Create default return type and setting value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql query
                string sql = "DELETE FROM locations WHERE room=@room";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating parameters to add value
                cmd.Parameters.AddWithValue("@room", l.room);

                //Open database conection
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
