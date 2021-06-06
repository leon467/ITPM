using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1.subjectClasses
{
    class subjectClass
    {
        //Getters ans Setters for carrying data
        public String subject_code { get; set; }

        public String sname { get; set; }

        public String semester { get; set; }

        public String offered_yr { get; set; }

        public String lab_hrs { get; set; }

        public String tute_hrs { get; set; }

        public String lec_hrs { get; set; }

        public String evaluation_hrs { get; set; }


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
                string sql = "SELECT * FROM subject";
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

        public bool Insert(subjectClass s)
        {
            //Create default return type and setting value to false
            bool isSuccess = false;

            //Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql querry
                string sql = "INSERT INTO subject (subject_code, sname, semester, offered_yr, lab_hrs, tute_hrs, lec_hrs, evaluation_hrs) VALUES (@subject_code, @sname, @semester, @offered_yr, @lab_hrs, @tute_hrs, @lec_hrs, @evaluation_hrs)";
                //Creating sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating parameters to add data
                cmd.Parameters.AddWithValue("@subject_code", s.subject_code);
                cmd.Parameters.AddWithValue("@sname", s.sname);
                cmd.Parameters.AddWithValue("@semester", s.semester);
                cmd.Parameters.AddWithValue("@offered_yr", s.offered_yr);
                cmd.Parameters.AddWithValue("@lab_hrs", s.lab_hrs);
                cmd.Parameters.AddWithValue("@tute_hrs", s.tute_hrs);
                cmd.Parameters.AddWithValue("@lec_hrs", s.lec_hrs);
                cmd.Parameters.AddWithValue("@evaluation_hrs", s.evaluation_hrs);

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
            catch (Exception )
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Updating data

        public bool Update(subjectClass s)
        {
            //Create default return type and setting value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql query
                string sql = "UPDATE subject SET sname=@sname, semester=@semester, offered_yr=@offered_yr, lab_hrs=@lab_hrs, tute_hrs=@tute_hrs, lec_hrs=@lec_hrs, evaluation_hrs=@evaluation_hrs WHERE subject_code=@subject_code";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating parameters to add valuerank
                cmd.Parameters.AddWithValue("@subject_code", s.subject_code);
                cmd.Parameters.AddWithValue("@sname", s.sname);
                cmd.Parameters.AddWithValue("@semester", s.semester);
                cmd.Parameters.AddWithValue("@offered_yr", s.offered_yr);
                cmd.Parameters.AddWithValue("@lab_hrs", s.lab_hrs);
                cmd.Parameters.AddWithValue("@tute_hrs", s.tute_hrs);
                cmd.Parameters.AddWithValue("@lec_hrs", s.lec_hrs);
                cmd.Parameters.AddWithValue("@evaluation_hrs", s.evaluation_hrs);

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

        public bool Delete(subjectClass s)
        {
            //Create default return type and setting value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql query
                string sql = "DELETE FROM subject WHERE subject_code=@subject_code";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating parameters to add value
                cmd.Parameters.AddWithValue("@subject_code", s.subject_code);

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
