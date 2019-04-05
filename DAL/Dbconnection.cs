using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Dbconnection
    {
        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-N1PTAGF;Initial Catalog=Library_management_System;Integrated Security=True;Pooling=False");
        public SqlConnection getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        //create a function ExeNonQuery to perform Insert, Update, Delete etc.
        public int ExeNonQuery(SqlCommand cmd)
        {

           
                cmd.Connection = getcon();
                int rowsaffected = -1;
                rowsaffected = cmd.ExecuteNonQuery();
                con.Close();
                return rowsaffected;
           
        }

        // create a function ExeScalar to retrive a Single value from Db or Query.
        public object ExeScalar(SqlCommand cmd)      
        {
            cmd.Connection = getcon();
            object obj = -1;
            obj = cmd.ExecuteScalar();
            con.Close();
            return obj;
        }

        //create a function ExeReader to perform Select Query.
        public DataTable ExeReader(SqlCommand cmd)
        {
            cmd.Connection = getcon();
            SqlDataReader  sdr;
            DataTable dt = new DataTable();

            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;

        }
    }
}
