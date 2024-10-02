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

namespace Bai9._4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtTieuThuDinhMuc.Text = "50";
        }
        private void TongTienPhaiTra()
        {
            if(txtHoTen.Text == "")
            {
                MessageBox.Show("Hãy nhập tên khách hàng","Thông báo",MessageBoxButton.OKCancel);
                return;
            }    
            if (txtChiSoCu.Text == "" || txtChiSoMoi.Text == "")
            {
                MessageBox.Show("Không để trống chỉ số cũ và chỉ số mới", "Thông báo", MessageBoxButton.OKCancel);
                return;
            }
            int chiSoCu = int.Parse(txtChiSoCu.Text);
            int chiSoMoi = int.Parse(txtChiSoMoi.Text);
            int soKwTieuThu = chiSoMoi - chiSoCu;
            txtSoKwTieuThu.Text = soKwTieuThu.ToString();
            int soKwTrongDinhMuc = int.Parse(txtTieuThuDinhMuc.Text);
            int soKwVuotDinhMuc = soKwTieuThu - soKwTrongDinhMuc;
            txtTieuThuVuotMuc.Text = soKwVuotDinhMuc.ToString();
            int TongTienPhaiTra = (soKwTrongDinhMuc * 500) + (soKwVuotDinhMuc * 1000);
            txtTienPhaiTra.Text = TongTienPhaiTra.ToString();

        }
        private void btnTinh_Click(object sender, RoutedEventArgs e)
        {
            TongTienPhaiTra();
        }

        private void btnIn_Click(object sender, RoutedEventArgs e)
        {
            txtHienThi.Content = $"{txtHoTen.Text}\nSố kw tiêu thụ: {txtSoKwTieuThu.Text}\nTổng tiền: {txtTienPhaiTra.Text}";
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}