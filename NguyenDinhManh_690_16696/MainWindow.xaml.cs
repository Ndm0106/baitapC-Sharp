using NguyenDinhManh_690_16696.Models;
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

namespace NguyenDinhManh_690_16696
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QlduocPhamContext db;
        public MainWindow()
        {
            InitializeComponent();
            db=new QlduocPhamContext();
            LoadData();
            LoadDataCombobox();
        }
        private void LoadData()
        {
            var querry = from thuoc in db.Thuocs
                         where thuoc.SoLuong <= 250
                         orderby thuoc.TenThuoc ascending
                         select new DataThongTin
                         {
                             MaThuoc = thuoc.MaThuoc,
                             TenThuoc = thuoc.TenThuoc, 
                             SoLuong = thuoc.SoLuong,
                             GiaBan = thuoc.GiaBan,
                             MaDm = thuoc.MaDm,
                             ThanhTien = thuoc.SoLuong * thuoc.GiaBan
                         };
            dataThuoc.ItemsSource = querry.ToList();
        }
        private void LoadDataCombobox()
        {
            cbxDanhMucThuoc.ItemsSource = db.DanhMucThuocs.ToList();
            cbxDanhMucThuoc.DisplayMemberPath = "TenDm";
            cbxDanhMucThuoc.SelectedValuePath = "MaDm";
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //DanhMucThuoc? danhMucThuoc = cbxDanhMucThuoc.SelectedItem as DanhMucThuoc;
                if (string.IsNullOrWhiteSpace(txtMaThuoc.Text))
                    throw new Exception("Vui lòng nhập mã thuốc");
                if (string.IsNullOrWhiteSpace(txtTenThuoc.Text))
                    throw new Exception("Vui lòng nhập tên thuốc");
                if (string.IsNullOrWhiteSpace(txtGiaThuoc.Text))
                    throw new Exception("Vui lòng nhập giá bán thuốc");
                if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
                    throw new Exception("Vui lòng nhập số lượng thuốc");
                if (cbxDanhMucThuoc.SelectedItem == null)
                    throw new Exception("Vui lòng chọn danh mục thuốc");
                if (!(int.TryParse(txtSoLuong.Text,out int soLuong)))
                    throw new Exception("số lượng phải là số nguyên");
                if (soLuong < 0)
                    throw new Exception("số lượng phải > 0 ");
                if (!(double.TryParse(txtGiaThuoc.Text, out double giaBan)))
                    throw new Exception("giá bán phải là số thực");
                if (giaBan < 0)
                    throw new Exception("giá bán phải > 0 ");
                if (db.Thuocs.Any(t => t.MaThuoc == txtMaThuoc.Text))
                    throw new Exception("Mã thuốc đã tồn tại, vui lòng nhập mã khác.");
                DanhMucThuoc? danhMucThuoc = cbxDanhMucThuoc.SelectedItem as DanhMucThuoc;
                Thuoc thuoc = new Thuoc
                {
                    MaThuoc = txtMaThuoc.Text, 
                    TenThuoc = txtTenThuoc.Text,
                    SoLuong = soLuong,
                    GiaBan = giaBan,
                    MaDm = danhMucThuoc.MaDm
                };
                db.Thuocs.Add(thuoc);
                db.SaveChanges();

                LoadData();
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Warning",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            var querry = db.Thuocs.FirstOrDefault(x=>x.MaThuoc==txtMaThuoc.Text);
            if (querry != null)
            {
                try
                {


                    
                    if (string.IsNullOrWhiteSpace(txtTenThuoc.Text))
                        throw new Exception("Vui lòng nhập tên thuốc");
                    if (string.IsNullOrWhiteSpace(txtGiaThuoc.Text))
                        throw new Exception("Vui lòng nhập giá bán thuốc");
                    if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
                        throw new Exception("Vui lòng nhập số lượng thuốc");
                    if (cbxDanhMucThuoc.SelectedItem == null)
                        throw new Exception("Vui lòng chọn danh mục thuốc");
                    if (!(int.TryParse(txtSoLuong.Text, out int soLuong)))
                        throw new Exception("số lượng phải là số nguyên");
                    if (soLuong < 0)
                        throw new Exception("số lượng phải > 0 ");
                    if (!(double.TryParse(txtGiaThuoc.Text, out double giaBan)))
                        throw new Exception("giá bán phải là số thực");
                    if (giaBan < 0)
                        throw new Exception("giá bán phải > 0 ");
                    DanhMucThuoc? danhMucThuoc = cbxDanhMucThuoc.SelectedItem as DanhMucThuoc;
                    querry.MaThuoc = txtMaThuoc.Text;
                    querry.TenThuoc = txtTenThuoc.Text;
                    querry.GiaBan = double.Parse(txtGiaThuoc.Text);
                    querry.SoLuong = int.Parse(txtSoLuong.Text);
                    querry.MaDm = danhMucThuoc.MaDm;
                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Sửa thành công");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            var thongBao = MessageBox.Show("Bạn có muốn xoá thuốc", "Câu hỏi", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (thongBao == MessageBoxResult.Yes)
            {
                var querry = db.Thuocs.FirstOrDefault(x => x.MaThuoc == txtMaThuoc.Text);
                if (querry != null)
                {
                    db.Thuocs.Remove(querry);
                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Xoá thành công");
                }
            }
            
        }

        private void btnTimKiem_Click(object sender, RoutedEventArgs e)
        {
            var querry = from dmt in db.DanhMucThuocs
                         join thuoc in db.Thuocs on dmt.MaDm equals thuoc.MaDm
                         into danhMucThuocGroup
                         select new
                         {
                             MaDm = dmt.MaDm,
                             TenDm = dmt.TenDm,
                             ThanhTien = danhMucThuocGroup.Sum(h => h.SoLuong * h.GiaBan)
                         };
            TimKiem timKiem = new TimKiem();
            timKiem.dtTimKiem.ItemsSource = querry.ToList();
            timKiem.Show();
        }

        private void dataThuoc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataThongTin dataThongTin = (DataThongTin)dataThuoc.SelectedItem;
            if(dataThongTin != null )
            {
                txtMaThuoc.IsEnabled = false;
                txtMaThuoc.Text = dataThongTin.MaThuoc;
                txtTenThuoc.Text = dataThongTin.TenThuoc;
                txtSoLuong.Text = dataThongTin.SoLuong.ToString();
                txtGiaThuoc.Text = dataThongTin.GiaBan.ToString();
                cbxDanhMucThuoc.SelectedValue = dataThongTin.MaDm;
            } 
            else
            {
                MessageBox.Show("Dữ liệu rỗng");
                return;
            }    
              
        }
    }
}