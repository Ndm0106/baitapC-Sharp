using Bai_KTHP.Model;
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

namespace Bai_KTHP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private QlhocSinhContext db = new QlhocSinhContext();
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
            LoadDataComboBox();
        }
        private void LoadDataComboBox()
        {
            cbxLop.ItemsSource = db.Lops.ToList();
            cbxLop.DisplayMemberPath = "TenLop";
            cbxLop.SelectedValuePath = "MaLop";
        }
        private void LoadData()
        {
            
            var querry = from hs in db.HocSinhs
                         select new DataHienThi
                         {
                             MaHs = hs.MaHs,
                             HoTen = hs.HoTen,
                             NgaySinh = hs.NgaySinh,
                             GioiTinh = hs.GioiTinh,
                             ConTbls = hs.ConTbls,
                             TenLop = hs.MaLopNavigation.TenLop,
                             Tuoi = DateTime.Now.Year - hs.NgaySinh.Year
                         };
            dataHocSinh.ItemsSource = querry.ToList();
        }
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaHS.Text))
                    throw new Exception("Không được để trống mã học sinh");
                if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                    throw new Exception("Không được để trống tên học sinh");
                if (dpNgaySinh.SelectedDate == null)
                    throw new Exception("Không được để trống ngày sinh");
                if ((rbNam.IsChecked == null || rbNu.IsChecked == null)||(rbNam.IsChecked == false && rbNu.IsChecked == false))
                    throw new Exception("Vui lòng chọn giới tính");
                if (cbxLop.SelectedItem == null)
                    throw new Exception("Vui lòng chọn tên lớp");

                string gioiTinh = string.Empty;
                if (rbNam.IsChecked == true)
                    gioiTinh = "Nam";
                else if (rbNu.IsChecked == true)
                    gioiTinh = "Nữ";

                string conTBLS = string.Empty;
                if (cbConTBLS.IsChecked == true)
                    conTBLS = "Có";
                else if (cbConTBLS.IsChecked == false)
                    conTBLS = "Không";

                DateTime ngaySinh = dpNgaySinh.SelectedDate.Value;
                int tuoi = DateTime.Now.Year - ngaySinh.Year;
                if (tuoi >= 15 || tuoi <= 10)
                    throw new Exception("Tuổi học sinh phải >=10 và <=15.");
                Lop chonLop = (Lop)cbxLop.SelectedItem;

                HocSinh hocSinh = new HocSinh
                {
                    MaHs = txtMaHS.Text,
                    HoTen = txtHoTen.Text,
                    NgaySinh = ngaySinh,
                    GioiTinh = gioiTinh,
                    ConTbls = conTBLS,
                    MaLop = chonLop.MaLop
                };
                db.HocSinhs.Add(hocSinh);
                db.SaveChanges();
                LoadData();

                txtHoTen.Clear();
                txtMaHS.Clear();
                dpNgaySinh.SelectedDate = null;
                rbNam.IsChecked = false;
                rbNu.IsChecked = false;
                cbConTBLS.IsChecked = false;
                cbxLop.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnThongKe_Click(object sender, RoutedEventArgs e)
        {
            var thongKeLop = from lop in db.Lops
                             join hs in db.HocSinhs on lop.MaLop equals hs.MaLop
                             where hs.GioiTinh == "Nữ"
                             group hs by new { lop.MaLop, lop.TenLop } into grouped
                             select new
                             {
                                 MaLop = grouped.Key.MaLop,
                                 TenLop = grouped.Key.TenLop,
                                 SoHocSinhNu = grouped.Count()
                             };
            ThongKe thongKe = new ThongKe();
            thongKe.dataThongKe.ItemsSource = thongKeLop.ToList();
            thongKe.Show();
        }
    }
}