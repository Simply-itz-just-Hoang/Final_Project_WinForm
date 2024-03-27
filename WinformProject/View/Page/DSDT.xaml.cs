using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
using WinformProject.Class;
using WinformProject.View.Design;

namespace WinformProject.View.Page
{
    /// <summary>
    /// Interaction logic for DSDT.xaml
    /// </summary>
    public partial class DSDT : UserControl
    {
        int[] listDKDT = { 1, 2, 2, 4, 4 };
        int[] listTVDT = { 1, 2, 10 };
        int[] listDTDD = { 1, 2, 2, 4, 4 };
        ThesisDAO thesisDAO = new ThesisDAO();
        public SuaDTButton suaDTButton = new SuaDTButton();
        public DSDT()
        {
            InitializeComponent();
            DKDTBar.LoadGridView(gv_DeTai, "Request", " Where status = 'Chua Duoc Duyet'");
            setColumnWidth(listDKDT);
            DKDTBar.btn1.Click += btn1_Click;
            DKDTBar.btn2.Click += btn2_Click;
            DKDTBar.btn3.Click += btn3_Click;
            gv_DeTai.LoadingRow += dataGrid_LoadingRow;
        }


        private void ButtonDuyet_Click(object sender, RoutedEventArgs e)
        {
            if (DKDTBar.btn1.IsEnabled == false)
            {
                MessageBox.Show("Duyệt đề tài tự chọn");
            }
        }
        private void ButtonKhongDuyet_Click(object sender, RoutedEventArgs e)
        {
            if (DKDTBar.btn1.IsEnabled == false)
            {
                MessageBox.Show("Không duyệt đề tài tự chọn");
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Space.Children.Clear();
            DKDTBar.LoadGridView(gv_DeTai, "Request", " Where status = 'Chua Duoc Duyet'");
            setColumnWidth(listDKDT);
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Space.Children.Add(suaDTButton);
            DKDTBar.LoadGridView(gv_DeTai, "LuanVan", "");
            setColumnWidth(listTVDT);
        }
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Space.Children.Clear();
            DKDTBar.LoadGridView(gv_DeTai, "Request", " Where status = 'Duoc Duyet'");
            setColumnWidth(listDTDD);
        }

        private void ThemThesis_Click(object sender, RoutedEventArgs e)
        {
            //Thesis thesis = new Thesis(this.);

            //thesisDAO.them;
        }

        private void dataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            // Tạo một đối tượng Style để đặt màu cho Header của các cột trong DataGrid
            Style headerStyle = new Style(typeof(DataGridColumnHeader));
            headerStyle.Setters.Add(new Setter(BackgroundProperty, Brushes.LightBlue));
            // Áp dụng Style cho tất cả các cột trong DataGrid
            foreach (DataGridColumn column in gv_DeTai.Columns)
            {
                column.HeaderStyle = headerStyle;
            }
            //đổi màu các hàng chẵn
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
