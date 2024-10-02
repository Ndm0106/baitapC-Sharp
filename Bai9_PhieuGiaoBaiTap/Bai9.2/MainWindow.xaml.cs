using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bai9._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadComboBoxGioiTinh();
            LoadComboBoxPhongBan();
        }
        private void LoadComboBoxGioiTinh()
        {
            txtGioiTinh.Items.Add("Nam");
            txtGioiTinh.Items.Add("Nữ");
        }
        private void LoadComboBoxPhongBan()
        {
            txtPhongBan.Items.Add("Phòng hành chính");
            txtPhongBan.Items.Add("Phòng kỹ thuật");
            txtPhongBan.Items.Add("Phòng kinh doanh");
        }

        private void Them_Click(object sender, RoutedEventArgs e)
        {
            string hoten = txtHoTen.Text;
            string gioiTinh = txtGioiTinh.SelectedItem as string;
            string phongBan = txtPhongBan.SelectedItem as string;

            string thongtinNhanVien = $"{hoten} - {gioiTinh} - {phongBan}"; 
            if (gioiTinh == null || phongBan == null)
            {
                MessageBox.Show("Các trường không được bỏ trống","Thông báo",MessageBoxButton.OKCancel, MessageBoxImage.Error);
                return;
            }
            QLNV.Items.Add(thongtinNhanVien);
            txtHoTen.Clear();
            txtGioiTinh.SelectedIndex = -1;
            txtPhongBan.SelectedIndex = -1;
        }

        private void Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}