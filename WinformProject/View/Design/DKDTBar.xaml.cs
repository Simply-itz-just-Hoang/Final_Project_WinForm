using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WinformProject.View.Design
{
    /// <summary>
    /// Interaction logic for DKMHBar.xaml
    /// </summary>
    public partial class DKDTBar : UserControl
    {
        //Kết nối database
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        //public DataGrid gv = new DataGrid();
        //thông số chiều cao của btn
        public int hight1 =40;
        public int hight2 = 30;

        public DKDTBar()
        {
            InitializeComponent();
            lockBtn(btn1);
        }
        private void lockBtn(Button btn)
        {
            //thay đổi chiều cao
            btn1.Height = hight2;
            btn2.Height = hight2;
            btn3.Height = hight2;
            btn.Height = hight1;
            //khóa
            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;
            btn.IsEnabled = false;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            lockBtn(btn1);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            lockBtn(btn2);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            lockBtn(btn3);
        }
        public void LoadGridView(DataGrid gv , string str1, string str2)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM " + str1 + str2);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                gv.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


    }
    
}
