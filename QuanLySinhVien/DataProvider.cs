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
        public DataTable SelectData1(string sql, List<CustomPameters> lstPara)

        {


            try
            {
                conn.Open();
                sql = "exec SelectAllAccount";
                cmd = new SqlCommand(sql, conn);
               
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu:" + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable SelectData(string sql,List<CustomPameters> lstPara)
            
        {
            
            
            try
            {
                conn.Open();
          
                cmd= new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var para in lstPara)
                {
                    cmd.Parameters.AddWithValue(para.key,para.value);
                }
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
        public DataRow Select(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi load thông tin chi tiết:"+ ex.Message);
                return null;
            }
            finally
            {
                conn.Close ();
            }
        }
        public int ExeCute(string sql,List<CustomPameters> lstPara)
        {
            try
            {
                conn.Open ();
                cmd = new SqlCommand(sql,conn);
               cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in lstPara)
                {
                    cmd.Parameters.AddWithValue(p.key,p.value);
                }
                var rs = cmd.ExecuteNonQuery();
                return (int)rs; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh:"+ ex.Message );
                return -100;
            }
            finally
            {
                conn.Close () ;
            }
        }
    }
   
}
