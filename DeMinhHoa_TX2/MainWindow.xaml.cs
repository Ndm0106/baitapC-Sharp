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

namespace DeMinhHoa_TX2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<NhanVien> danhSachNhanVien = new List<NhanVien>();
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = danhSachNhanVien;
        }

        private void Nhap_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu (giống như đoạn mã kiểm tra hợp lệ đã viết trước)
                if (string.IsNullOrWhiteSpace(txtMaNV.Text))
                    throw new Exception("Mã nhân viên không được để trống.");
                if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                    throw new Exception("Họ và tên không được để trống.");
                if (dpNgaySinh.SelectedDate == null)
                    throw new Exception("Vui lòng chọn ngày sinh.");
                DateTime ngaySinh = dpNgaySinh.SelectedDate.Value;
                int tuoi = DateTime.Now.Year - ngaySinh.Year;
                if (tuoi < 18)
                    throw new Exception("Tuổi của nhân viên phải lớn hơn hoặc bằng 18.");

                if (!rbNam.IsChecked.HasValue || (!rbNam.IsChecked.Value && !rbNu.IsChecked.Value))
                    throw new Exception("Vui lòng chọn giới tính.");

                if (cbPhongBan.SelectedItem == null)
                    throw new Exception("Vui lòng chọn phòng ban.");

                if (string.IsNullOrWhiteSpace(txtHeSoLuong.Text) || !double.TryParse(txtHeSoLuong.Text, out double heSoLuong) || heSoLuong <= 0)
                    throw new Exception("Hệ số lương phải là một số thực lớn hơn 0.");

                // Tạo đối tượng NhanVien mới và thêm vào danh sách
                NhanVien nv = new NhanVien
                {
                    MaNhanVien = txtMaNV.Text,
                    HoTen = txtHoTen.Text,
                    GioiTinh = rbNam.IsChecked == true ? "Nam" : "Nữ",
                    PhongBan = (cbPhongBan.SelectedItem as ComboBoxItem).Content.ToString(),
                    NgaySinh = ngaySinh,
                    Tuoi = tuoi
                };

                // Thêm nhân viên vào danh sách và làm mới DataGrid
                danhSachNhanVien.Add(nv);
                dataGrid.Items.Refresh();

                MessageBox.Show("Dữ liệu đã được thêm thành công.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                txtHeSoLuong.Clear();
                txtHoTen.Clear();
                txtMaNV.Clear();
                cbPhongBan.SelectedItem = null;
                rbNam.IsChecked = false;
                rbNu.IsChecked = false;
                dpNgaySinh.SelectedDate = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi nhập liệu", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void Window2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Tìm tuổi cao nhất trong danh sách nhân viên
                int maxAge = 0;
                if (danhSachNhanVien.Count > 0)
                {
                    maxAge = danhSachNhanVien.Max(nv => nv.Tuoi);
                }

                // Lọc danh sách nhân viên có tuổi cao nhất
                List<NhanVien> nhanViensMaxAge = danhSachNhanVien
                    .Where(nv => nv.Tuoi == maxAge)
                    .ToList();

                // Tạo cửa sổ mới và truyền danh sách nhân viên có tuổi cao nhất vào
                Window2 window2 = new Window2(nhanViensMaxAge);
                window2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}