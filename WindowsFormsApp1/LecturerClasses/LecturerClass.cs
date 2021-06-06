using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1.LecturerClasses
{
    class LecturerClass
    {
        //Getters ans Setters for carrying data
        public String empId { get; set; }

        public String lecture_name { get; set; }

        public String faculty { get; set; }

        public String dependent { get; set; }

        public String center { get; set; }

        public String building { get; set; }

        public String lec_level { get; set; }

        public String rank { get; set; }

        //for connecting database
        static string myconnstrng = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.timetableManagementConnectionString"].ConnectionString;

        // sellecting data(retrive)

        public DataTable Select()
        {
            // database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                // sql query
                string sql = "SELECT * FROM lecturers";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception )
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;

        }
        //Inserting data(Creating)

        public bool Insert(LecturerClass s)
        {
            //Create default return type and setting value to false
            bool isSuccess = false;

            //Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql querry
                string sql = "INSERT INTO lecturers (empId, lecture_name, faculty, dependent, center, building, lec_level, rank) VALUES (@empId, @lecture_name, @faculty, @dependent, @center, @building, @lec_level, @rank)";
                //Creating sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating parameters to add data
                cmd.Parameters.AddWithValue("@empId", s.empId);
                cmd.Parameters.AddWithValue("@lecture_name", s.lecture_name);
                cmd.Parameters.AddWithValue("@faculty", s.faculty);
                cmd.Parameters.AddWithValue("@dependent", s.dependent);
                cmd.Parameters.AddWithValue("@center", s.center);
                cmd.Parameters.AddWithValue("@building", s.building);
                cmd.Parameters.AddWithValue("@lec_level", s.lec_level);
                cmd.Parameters.AddWithValue("@rank", s.rank);

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

        public bool Update(LecturerClass s)
        {
            //Create default return type and setting value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql query
                string sql = "UPDATE lecturers SET lecture_name=@lecture_name, faculty=@faculty, dependent=@dependent, center=@center, building=@building, lec_level=@lec_level,rank=@rank WHERE empId=@empId";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating parameters to add valuerank
                cmd.Parameters.AddWithValue("@empId", s.empId);
                cmd.Parameters.AddWithValue("@lecture_name", s.lecture_name);
                cmd.Parameters.AddWithValue("@faculty", s.faculty);
                cmd.Parameters.AddWithValue("@dependent", s.dependent);
                cmd.Parameters.AddWithValue("@center", s.center);
                cmd.Parameters.AddWithValue("@building", s.building);
                cmd.Parameters.AddWithValue("@lec_level", s.lec_level);
                cmd.Parameters.AddWithValue("@rank", s.rank);

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
            catch (Exception )
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Deleting data

        public bool Delete(LecturerClass s)
        {
            //Create default return type and setting value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql query
                string sql = "DELETE FROM lecturers WHERE empId=@empId";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating parameters to add value
                cmd.Parameters.AddWithValue("@empId", s.empId);

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
            catch (Exception )
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
