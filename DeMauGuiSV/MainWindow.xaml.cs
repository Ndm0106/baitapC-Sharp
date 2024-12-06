using DeMauGuiSV.Models;
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

namespace DeMauGuiSV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SalesmanagementContext db = new SalesmanagementContext();
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
            LoadDataCombobox();
        }
        
        private void LoadDataCombobox()
        {
            cbxCategory.ItemsSource = db.Categories.ToList();
            cbxCategory.DisplayMemberPath = "CatName";
            cbxCategory.SelectedValuePath = "CatId";
        }
        private void LoadData()
        {
            var querry = from p in db.Products
                         where p.Quantity <= 150
                         orderby p.ProductName ascending
                         select new DataInfor
                         {
                             ProductName = p.ProductName,
                             Quantity = p.Quantity,
                             ProductId = p.ProductId,
                             UnitPrice = p.UnitPrice,
                             CatId = p.CatId,
                             Amount = p.UnitPrice* p.Quantity
                         };
            dataInfor.ItemsSource = querry.ToList();
        }
        

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtID.Text))
                    throw new Exception("Vui lòng nhập Id");
                if (string.IsNullOrWhiteSpace(txtName.Text))
                    throw new Exception("Vui lòng nhập name");
                if (string.IsNullOrWhiteSpace(txtQuantity.Text))
                    throw new Exception("Vui lòng nhập quantity");
                if (string.IsNullOrWhiteSpace(txtUnitPrice.Text))
                    throw new Exception("Vui lòng nhập unit price");
                if (cbxCategory.SelectedItem == null)
                    throw new Exception("Vui lòng chọn category");
                if (!(int.TryParse(txtQuantity.Text,out int quantity)) )
                    throw new Exception("Quantity phải là số");
                if(quantity < 0)
                    throw new Exception("Quantity phải là  số nguyên dương");
                if (!(int.TryParse(txtUnitPrice.Text, out int unitprice)))
                    throw new Exception("Unit Price phải là số");
                if (unitprice < 0)
                    throw new Exception("Unit Price phải là số nguyên dương");
                var querry = db.Products.Any(p => p.ProductId == txtID.Text);
                if (querry)
                    throw new Exception("Đã tồn tại ProductId");
                Category category = (Category)cbxCategory.SelectedItem;
                Product product = new Product
                {
                    ProductId = txtID.Text,
                    ProductName = txtName.Text,
                    Quantity = quantity,
                    UnitPrice = unitprice,
                    CatId = category.CatId,
                };
                db.Products.Add(product);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Insert complete");
                txtID.Clear();
                txtName.Clear();
                txtQuantity.Clear();
                txtUnitPrice.Clear();
                cbxCategory.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtID.Text))
                    throw new Exception("Vui lòng nhập Id");
                if (string.IsNullOrWhiteSpace(txtName.Text))
                    throw new Exception("Vui lòng nhập name");
                if (string.IsNullOrWhiteSpace(txtQuantity.Text))
                    throw new Exception("Vui lòng nhập quantity");
                if (string.IsNullOrWhiteSpace(txtUnitPrice.Text))
                    throw new Exception("Vui lòng nhập unit price");
                if (cbxCategory.SelectedItem == null)
                    throw new Exception("Vui lòng chọn category");
                if (!(int.TryParse(txtQuantity.Text, out int quantity)))
                    throw new Exception("Quantity phải là số");
                if (quantity < 0)
                    throw new Exception("Quantity phải là  số nguyên dương");
                if (!(int.TryParse(txtUnitPrice.Text, out int unitprice)))
                    throw new Exception("Unit Price phải là số");
                if (unitprice < 0)
                    throw new Exception("Unit Price phải là số nguyên dương");
                Category category = (Category)cbxCategory.SelectedItem;
                var product = db.Products.FirstOrDefault(p => p.ProductId == txtID.Text);
                if (product == null)
                    throw new Exception("Không tìm thấy sản phẩm để cập nhật.");
                product.ProductName = txtName.Text;
                product.Quantity = quantity;
                product.UnitPrice = unitprice;
                product.CatId = category.CatId;
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Update complete");
                txtID.Clear();
                txtName.Clear();
                txtQuantity.Clear();
                txtUnitPrice.Clear();
                cbxCategory.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var thongbao = MessageBox.Show("Bạn có muốn xoá product này","Xoá",MessageBoxButton.YesNo,MessageBoxImage.Question);
            if(thongbao == MessageBoxResult.Yes)
            {
                var querry = db.Products.FirstOrDefault(x=>x.ProductId == txtID.Text);
                if(querry != null)
                {
                    db.Products.Remove(querry);
                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Delete complete");
                }    
            }    
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var querry = from ct in db.Categories
                         join pd in db.Products on ct.CatId equals pd.CatId
                         into CategoriesGroup
                         select new
                         {
                             CatId = ct.CatId,
                             CatName = ct.CatName,
                             Amount = CategoriesGroup.Sum(x => x.Quantity * x.UnitPrice)
                         };
            Tim tim = new Tim();
            tim.dataTim.ItemsSource = querry.ToList();
            tim.Show();
        }
        private void dataInfor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            DataInfor datainfor = (DataInfor)dataInfor.SelectedItem;
            if(datainfor != null)
            {
                txtID.IsEnabled = false;
                txtID.Text = datainfor.ProductId;
                txtName.Text = datainfor.ProductName;
                txtQuantity.Text = datainfor.Quantity.ToString();
                txtUnitPrice.Text = datainfor.UnitPrice.ToString();
                cbxCategory.SelectedValue = datainfor.CatId;
            }    
        }
    }
}