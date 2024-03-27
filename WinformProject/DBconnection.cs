using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WinformProject
{
    internal class DBconnection
    {
        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=D:\\WORK\\FINAL_PROJECT_WIN\\FINAL_PROJECT_WINFORM\\DATABASE\\QUANLYLUANVAN.MDF;Integrated Security=True;Connect Timeout=30");
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
