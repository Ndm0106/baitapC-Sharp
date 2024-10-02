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

namespace Bai9._5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Drink
        {
            public string Name { get; set; }
            public string Image { get; set; }
            public bool IsSelected { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent();
            var drinks = new List<Drink>
            {
                new Drink { Name = "Nước cam tươi", Image = "E:\\VisualStudioC#\\Bai9_PhieuGiaoBaiTap\\Bai9.5\\Image\\orange_juice.jpg" },
                new Drink { Name = "Nước kiwi ép", Image = "E:\\VisualStudioC#\\Bai9_PhieuGiaoBaiTap\\Bai9.5\\Image\\kiwi_juice.png" },
                new Drink { Name = "Nước soài ép", Image = "E:\\VisualStudioC#\\Bai9_PhieuGiaoBaiTap\\Bai9.5\\Image\\mango_juice.png" },
                new Drink { Name = "Sữa tươi tiệt trùng", Image = "E:\\VisualStudioC#\\Bai9_PhieuGiaoBaiTap\\Bai9.5\\Image\\milk.png" },
                new Drink { Name = "Cà phê Espresso", Image = "E:\\VisualStudioC#\\Bai9_PhieuGiaoBaiTap\\Bai9.5\\Image\\espresso.png" }
            };

            // Liên kết danh sách với ListBox
            DrinkListBox.ItemsSource = drinks;
        }
        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            // Lấy danh sách đồ uống được chọn
            var selectedDrinks = DrinkListBox.Items.Cast<Drink>().Where(d => d.IsSelected).Select(d => d.Name);

            // Hiển thị thông báo
            if (selectedDrinks.Any())
            {
                MessageBox.Show("Bạn đã chọn: " + string.Join("; ", selectedDrinks), "Thông báo");
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đồ uống nào.", "Thông báo");
            }
        }

    }

}