using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1.statisticsClasses
{
    class statistics
    {
        //Getters and setters for carrying data

        public String SID { get; set; }
        public String AcadamicYS { get; set; }
        public String programme { get; set; }
        public String groupno { get; set; }
        public String subgroupno { get; set; }
        public String groupid { get; set; }
        public String subgroupId { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public DataTable Select()
        {
            //Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Sql query
                string sql = "SELECT COUNT(*) FROM students";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                int num = Convert.ToInt32(cmd.ExecuteScalar());

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

    }
}
