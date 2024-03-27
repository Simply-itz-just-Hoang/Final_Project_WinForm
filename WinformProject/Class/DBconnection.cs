using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WinformProject.Class
{
    internal class DBconnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public DataTable Load(string sqlStr)
        {
            DataTable dtSinhVien = new DataTable();

            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dtSinhVien);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtSinhVien;
        }
        public void Execuate(string sqlStr)
        {
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("thao tac thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("thao tac that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
