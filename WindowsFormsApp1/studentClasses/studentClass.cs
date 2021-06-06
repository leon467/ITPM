using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1.studentClasses
{
    class studentClass
    {

        //Getters and setters for carrying data
        public int SID { get; set; }
        public String AcademicYS { get; set; }
        public String programme { get; set; }
        public String groupno { get; set; }
        public String subgroupno { get; set; }
        public String groupid { get; set; }
        public String subgroupId { get; set; }

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
                string sql = "SELECT * FROM students";
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

        public bool Insert(studentClass s)
        {
            //Create default return type and setting value to false
            bool isSuccess = false;

            //Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql querry
                string sql = "INSERT INTO students (AcademicYS, programme, groupno, subgroupno, groupid, subgroupId) VALUES (@AcademicYS, @programme, @groupno, @subgroupno, @groupid, @subgroupId)";
                //Creating sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating parameters to add data
                cmd.Parameters.AddWithValue("@AcademicYS", s.AcademicYS);
                cmd.Parameters.AddWithValue("@programme", s.programme);
                cmd.Parameters.AddWithValue("@groupno", s.groupno);
                cmd.Parameters.AddWithValue("@subgroupno", s.subgroupno);
                cmd.Parameters.AddWithValue("@groupid", s.groupid);
                cmd.Parameters.AddWithValue("@subgroupId", s.subgroupId);

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

        public bool Update(studentClass s)
        {
            //Create default return type and setting value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql query
                string sql = "UPDATE students SET AcademicYS=@AcademicYS, programme=@programme, groupno=@groupno, subgroupno=@subgroupno, groupid=@groupid, subgroupId=@subgroupId WHERE SID=@SID";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating parameters to add value
                cmd.Parameters.AddWithValue("@SID", s.SID);
                cmd.Parameters.AddWithValue("@AcademicYS", s.AcademicYS);
                cmd.Parameters.AddWithValue("@programme", s.programme);
                cmd.Parameters.AddWithValue("@groupno", s.groupno);
                cmd.Parameters.AddWithValue("@subgroupno", s.subgroupno);
                cmd.Parameters.AddWithValue("@groupid", s.groupid);
                cmd.Parameters.AddWithValue("@subgroupId", s.subgroupId);

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

        public bool Delete(studentClass s)
        {
            //Create default return type and setting value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql query
                string sql = "DELETE FROM students WHERE SID=@SID";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating parameters to add value
                cmd.Parameters.AddWithValue("@SID", s.SID);

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
