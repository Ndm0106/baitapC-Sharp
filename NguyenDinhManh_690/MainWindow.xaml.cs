using NguyenDinhManh_690.Model;
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

namespace NguyenDinhManh_690
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private QlbanHangContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new QlbanHangContext();
            LoadCBX();
            LoadData();
        }
        private void LoadCBX()
        {
            cbxDanhMucHang.ItemsSource = db.DanhMucHangs.ToList();
            cbxDanhMucHang.DisplayMemberPath = "TenDm";
            cbxDanhMucHang.SelectedValuePath = "MaDm";

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //var querry = db.Hangs.Where(x=>x.SoLuongCon<=200).Select(x=> new
            //{
            //    x.MaHang,
            //    x.TenHang,
            //    x.SoLuongCon,
            //    x.MaDm,
            //    x.DonGiaBan,
            //    ThanhTien = x.SoLuongCon * x.DonGiaBan
            //}).OrderByDescending(x=>x.TenHang).ToList();  
            //dataQuanLy.ItemsSource = querry;
            LoadData();



        }
        private void LoadData()
        {
            //var querry = db.Hangs.Where(x => x.SoLuongCon <= 200).Select(x => new
            //{
            //    x.MaHang,
            //    x.TenHang,
            //    x.SoLuongCon,
            //    x.MaDm,
            //    x.DonGiaBan,
            //    ThanhTien = x.SoLuongCon * x.DonGiaBan
            //}).OrderByDescending(x => x.TenHang).ToList();
            //dataQuanLy.ItemsSource = querry;
            var querry = from hang in db.Hangs
                         where hang.SoLuongCon <= 200
                         orderby hang.TenHang descending
                         select new DataHienThi
                         {
                             MaHang = hang.MaHang,
                             MaDm = hang.MaDm,
                             TenHang = hang.TenHang,
                             SoLuongCon = hang.SoLuongCon,
                             DonGiaBan = hang.DonGiaBan,
                             ThanhTien = hang.SoLuongCon * hang.DonGiaBan
                         };
            dataQuanLy.ItemsSource = querry.ToList();
        }
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                string maHang = txtMaHang.Text;
                string tenHang = txtTenHang.Text;
                //int donGiaBan = int.Parse(txtDonGiaBan.Text);
                //int soLuongCon = int.Parse(txtSoLuongCon.Text);
                //string maDanhMuc = cbxDanhMucHang.SelectedValue.ToString();

                DanhMucHang? maDanhMuc = cbxDanhMucHang.SelectedItem as DanhMucHang;

                if (string.IsNullOrWhiteSpace(txtMaHang.Text))
                    throw new Exception("không để trống mã hàng");
                if (string.IsNullOrWhiteSpace(txtTenHang.Text))
                    throw new Exception("không để trống tên hàng");
                if (cbxDanhMucHang.SelectedItem == null)
                    throw new Exception("không để trống danh mục hàng");
                if (string.IsNullOrWhiteSpace(txtDonGiaBan.Text))
                    throw new Exception("không để trống đơn giá");
                if(!(int.TryParse(txtDonGiaBan.Text, out int donGiaBan)))
                    throw new Exception("đơn giá bán phải là một số");
                if(donGiaBan <= 0)
                    throw new Exception("đơn giá bán phải là một số thực lớn hơn 0");
                if (string.IsNullOrWhiteSpace(txtSoLuongCon.Text))
                    throw new Exception("không để trống số lượng");
                if (!(int.TryParse(txtSoLuongCon.Text, out int soLuongCon)))
                    throw new Exception("số lượng phải là một số");
                if (soLuongCon <= 0)
                    throw new Exception("số lượng phải là một số thực lớn hơn 0");
                Hang hang = new Hang
                {
                    MaHang = maHang,
                    TenHang = tenHang,
                    DonGiaBan = donGiaBan,
                    SoLuongCon = soLuongCon,
                    MaDm = maDanhMuc.MaDm
                };
                db.Hangs.Add(hang);
                db.SaveChanges();
                LoadData();

                txtMaHang.Clear();
                txtTenHang.Clear();
                txtDonGiaBan.Clear();
                txtSoLuongCon.Clear();
                cbxDanhMucHang.SelectedIndex = -1;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var querry = db.Hangs.FirstOrDefault(x => x.MaHang == txtMaHang.Text);
                DanhMucHang? maDanhMuc = cbxDanhMucHang.SelectedItem as DanhMucHang;


                if (string.IsNullOrWhiteSpace(txtMaHang.Text))
                    throw new Exception("không để trống mã hàng");
                if (string.IsNullOrWhiteSpace(txtTenHang.Text))
                    throw new Exception("không để trống tên hàng");
                if (cbxDanhMucHang.SelectedItem == null)
                    throw new Exception("không để trống danh mục hàng");
                if (string.IsNullOrWhiteSpace(txtDonGiaBan.Text))
                    throw new Exception("không để trống đơn giá");
                if (!(int.TryParse(txtDonGiaBan.Text, out int donGiaBan)))
                    throw new Exception("đơn giá bán phải là một số");
                if (donGiaBan <= 0)
                    throw new Exception("đơn giá bán phải là một số thực lớn hơn 0");
                if (string.IsNullOrWhiteSpace(txtSoLuongCon.Text))
                    throw new Exception("không để trống số lượng");
                if (!(int.TryParse(txtSoLuongCon.Text, out int soLuongCon)))
                    throw new Exception("số lượng phải là một số");
                if (soLuongCon <= 0)
                    throw new Exception("số lượng phải là một số thực lớn hơn 0");

                if (querry != null)
                {
                    querry.TenHang = txtTenHang.Text;
                    querry.SoLuongCon = soLuongCon;
                    querry.DonGiaBan = donGiaBan;
                    querry.MaDm = maDanhMuc.MaDm;
                    db.SaveChanges();
                    LoadData();


                    txtMaHang.Clear();
                    txtTenHang.Clear();
                    txtDonGiaBan.Clear();
                    txtSoLuongCon.Clear();
                    cbxDanhMucHang.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            var thongBaoXoa = MessageBox.Show("Xác nhận xoá hàng đang chọn ?","Warning",MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (thongBaoXoa == MessageBoxResult.Yes)
            {
                var querry = db.Hangs.FirstOrDefault(x => x.MaHang == txtMaHang.Text);
                if(querry != null)
                {
                    db.Hangs.Remove(querry);
                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Xoá thành công");

                }  
            }
        }
        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            var danhMucList = from danhMuc in db.DanhMucHangs
                              join hang in db.Hangs on danhMuc.MaDm equals hang.MaDm into danhMucHangGroup
                              select new
                              {
                                   MaDm = danhMuc.MaDm,
                                   TenDm = danhMuc.TenDm,
                                   TongSoTien = danhMucHangGroup.Sum(h => h.SoLuongCon * h.DonGiaBan)
                              };
            Window2 window2 = new Window2();
            window2.dataTim.ItemsSource = danhMucList.ToList();
            window2.Show();
        }

        private void dataQuanLy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //DataHienThi dataDuocChon = dataQuanLy.SelectedItem as DataHienThi;
            DataHienThi dataDuocChon = (DataHienThi)dataQuanLy.SelectedItem;
            if (dataDuocChon != null)
            {
                txtMaHang.Text = dataDuocChon.MaHang;
                txtMaHang.IsEnabled = false;
                txtTenHang.Text = dataDuocChon.TenHang;
                txtDonGiaBan.Text = dataDuocChon.DonGiaBan.ToString();
                txtSoLuongCon.Text = dataDuocChon.SoLuongCon.ToString();
                cbxDanhMucHang.SelectedValue = dataDuocChon.MaDm;
            }
        }
    }
}