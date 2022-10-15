using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp6
{
    internal class Dataa1
    {
        public void getData()
        {
            SqlConnection con = new SqlConnection("Data source = DESKTOP-M4928R4; database=Test; user id=sa; password=p@ssword ");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from studentdata ", con);
            //cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + "\t" + reader[1].ToString() +"\t"+ reader[2].ToString());   
            }
            con.Close();
        }
        public void insData(string name, DateTime date, string city)
        {
            SqlConnection con = new SqlConnection("Data source = DESKTOP-M4928R4; database=Test; user id=sa; password=p@ssword ");
            SqlCommand cmd = new SqlCommand("sp_insapple");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.AddWithValue("@sdate", SqlDbType.Date).Value = date;
            cmd.Parameters.AddWithValue("@city", SqlDbType.NVarChar).Value = city;
            con.Open();
            //cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Inserted");

        }
        public static void Main()
        {
            Dataa1 dataa1 = new Dataa1();
            dataa1.getData();
            dataa1.insData("Deepika", DateTime.Now, "Dindigul");
        }
        
    }
}
