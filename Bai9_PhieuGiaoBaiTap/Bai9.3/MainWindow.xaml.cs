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

namespace Bai9._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Them_Click(object sender, RoutedEventArgs e)
        {
            string hoTen = txtHoTen.Text;

            string gioiTinh = "";
            if (rbNam.IsChecked == true)
                gioiTinh = "Nam";
            else if (rbNu.IsChecked == true)
                gioiTinh = "Nữ";

            // Lấy tình trạng hôn nhân
            string tinhTrangHonNhan = "";
            if (rbChuaKetHon.IsChecked == true)
                tinhTrangHonNhan = "Chưa kết hôn";
            else if (rbDaKetHon.IsChecked == true)
                tinhTrangHonNhan = "Đã kết hôn";

            // Lấy sở thích
            string soThich = "";
            if (cbBongDa.IsChecked == true)
                soThich += "Bóng đá, ";
            if (cbBoiLoi.IsChecked == true) 
                soThich += "Bơi lội, ";
            if (cbAmNhac.IsChecked == true) 
                soThich += "Âm nhạc, ";
            if (cbLeoNui.IsChecked == true) 
                soThich += "Leo núi, ";

            // Xóa dấu phẩy cuối nếu có
            if (soThich.EndsWith(", "))
                soThich = soThich.Substring(0, soThich.Length - 2);

            // Tạo chuỗi hiển thị cho ListBox
            string thongTin = $"Họ tên: {hoTen}\nGiới tính: {gioiTinh}\nTình trạng hôn nhân: {tinhTrangHonNhan}\nSở thích: {soThich}";
            listCNTV.Items.Add(thongTin);

            // Xóa dữ liệu sau khi thêm
            txtHoTen.Clear();
            rbNam.IsChecked = false;
            rbNu.IsChecked = false;
            rbChuaKetHon.IsChecked = false;
            rbDaKetHon.IsChecked = false;
            cbBongDa.IsChecked = false;
            cbBoiLoi.IsChecked = false;
            cbAmNhac.IsChecked = false;
            cbLeoNui.IsChecked = false;
        }

        private void Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}