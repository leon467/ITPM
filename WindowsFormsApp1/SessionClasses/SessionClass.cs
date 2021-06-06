using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.SessionClasses
{
    class SessionClass
    {
        //Getters ans Setters for carrying data
        public int id { get; set; }

        public String lecturer1 { get; set; }

        public String lecturer2 { get; set; }

        public String tag { get; set; }

        public String groupNo { get; set; }

        public String subName { get; set; }

        public String NoStudents { get; set; }

        public String Hrs { get; set; }

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
                string sql = "SELECT * FROM sessions";
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

        public bool Insert(SessionClass s)
        {
            //Create default return type and setting value to false
            bool isSuccess = false;

            //Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql querry
                string sql = "INSERT INTO sessions (lecturer1, lecturer2, tag, groupNo, subName, NoStudents, Hrs) VALUES ( @lecturer1, @lecturer2, @tag, @groupNo, @subName, @NoStudents, @Hrs)";
                //Creating sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating parameters to add data

                cmd.Parameters.AddWithValue("@lecturer1", s.lecturer1);
                cmd.Parameters.AddWithValue("@lecturer2", s.lecturer2);
                cmd.Parameters.AddWithValue("@tag", s.tag);
                cmd.Parameters.AddWithValue("@groupNo", s.groupNo);
                cmd.Parameters.AddWithValue("@subName", s.subName);
                cmd.Parameters.AddWithValue("@NoStudents", s.NoStudents);
                cmd.Parameters.AddWithValue("@Hrs", s.Hrs);

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

        public bool Update(SessionClass s)
        {
            //Create default return type and setting value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql query
                string sql = "UPDATE sessions SET lecturer1=@lecturer1,lecturer2=@lecturer2,tag=@tag, groupNo=@groupNo, subName=@subName, NoStudents=@NoStudents,Hrs=@Hrs WHERE id=@id";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating parameters to add valuerank

                cmd.Parameters.AddWithValue("@lecturer1", s.lecturer1);
                cmd.Parameters.AddWithValue("@lecturer2", s.lecturer2);
                cmd.Parameters.AddWithValue("@tag", s.tag);
                cmd.Parameters.AddWithValue("@groupNo", s.groupNo);
                cmd.Parameters.AddWithValue("@subName", s.subName);
                cmd.Parameters.AddWithValue("@NoStudents", s.NoStudents);
                cmd.Parameters.AddWithValue("@Hrs", s.Hrs);
                cmd.Parameters.AddWithValue("@id", s.id);

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
            catch (Exception e )
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Deleting data

        public bool Delete(SessionClass s)
        {
            //Create default return type and setting value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //Sql query
                string sql = "DELETE FROM sessions WHERE id=@id";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating parameters to add value
                cmd.Parameters.AddWithValue("@id", s.id);

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
