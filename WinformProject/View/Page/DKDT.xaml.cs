using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WinformProject.View.Design;
using WinformProject.View.SmallWindow;

namespace WinformProject.View.Page
{
    /// <summary>
    /// Interaction logic for DKDT.xaml
    /// </summary>
    public partial class DKDT : UserControl
    {
        int[] listDKDT = { 1, 2, 2, 4, 4 };
        int[] listTVDT = { 1, 2, 10 };
        int[] listDTDD = { 1, 2, 2, 4, 4 };
        //Kết nối database
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public DKDT()
        {
            InitializeComponent();
            DKDTBar.LoadGridView(gv_DeTai, "Request", " Where status = 'Chua Duoc Duyet'");
            setColumnWidth(listDKDT);
            DKDTBar.btn1.Click += btn1_Click;
            DKDTBar.btn2.Click += btn2_Click;
            DKDTBar.btn3.Click += btn3_Click;
        }

        private void ButtonDangKy_Click(object sender, RoutedEventArgs e)
        {
            if(DKDTBar.btn1.IsEnabled == false) // Đăng ký đề tài tự chọn
            {
                
            }
            else if (DKDTBar.btn2.IsEnabled == false)
            {
                
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e) 
        {
            DKDTBar.LoadGridView(gv_DeTai, "Request", " Where status = 'Chua Duoc Duyet'");
            setColumnWidth(listDKDT);
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            DKDTBar.LoadGridView(gv_DeTai, "LuanVan", "");
            setColumnWidth(listTVDT);
        }
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            DKDTBar.LoadGridView(gv_DeTai, "Request", " Where status = 'Duoc Duyet'");
            setColumnWidth(listDTDD);
        }
        private void dataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            Style headerStyle = new Style(typeof(DataGridColumnHeader));
            headerStyle.Setters.Add(new Setter(BackgroundProperty, Brushes.LightBlue));
            foreach (DataGridColumn column in gv_DeTai.Columns)
            {
                column.HeaderStyle = headerStyle;
            }
            if (e.Row.AlternationIndex % 2 == 1)
            {
                e.Row.Background = Brushes.LightGray;
            }
            else
            {
                e.Row.Background = Brushes.White;
            }
        }
        public void setColumnWidth(int[] ratio)
        {
            double totalWidth = gv_DeTai.ActualWidth;
            double count = ratio.Sum();
            int i = 0;
            foreach (var column in gv_DeTai.Columns)
            {
                column.Width = new DataGridLength(totalWidth * ratio[i] / count);
                i++;
            }
        }
    }
}
