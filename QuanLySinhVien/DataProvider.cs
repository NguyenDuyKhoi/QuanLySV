using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Data.Common;

namespace QuanLySinhVien
{
    public class DataProvider
    {
        private string connectionString = @"Data Source=LAPTOP-6URMC7N5\sqlexpress;Initial Catalog=DanhSach;User ID=Kem;Password=1";
        private SqlConnection conn;
     
        private DataTable dt;
        private SqlCommand cmd;
        public DataProvider()
        {
            try
            {
                 conn = new SqlConnection(connectionString);
              
            }
            catch (Exception ex){
                MessageBox.Show("connected failed"+ex.Message);
            }


        }
        public DataTable SelectData(string sql,List<CustomPameters> lstParameters)
            
        {
            
            
            try
            {
                conn.Open();
          
                cmd= new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu:" + ex.Message);
                return null;
            }
            finally {
                conn.Close(); 
            }
         }

    }
   
}
