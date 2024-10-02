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

namespace Bai9._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadAvailableBooks();
        }
        private void LoadAvailableBooks()
        {
            listAvailableBooks.Items.Add("Công nghệ thực tại ảo");
            listAvailableBooks.Items.Add("Đảm bảo chất lượng phần mềm");
            listAvailableBooks.Items.Add("Giải thuật di truyền và ứng dụng");
            listAvailableBooks.Items.Add("Hệ chuyên gia");
            listAvailableBooks.Items.Add("Lập trình hướng đối tượng");
            listAvailableBooks.Items.Add("Lập trình trên Windows");
            // Thêm các sách khác...
        }
        private void MoveToSelected(object sender, RoutedEventArgs e)
        {
            if (listAvailableBooks.SelectedItem != null)
            {
                listSelectedBooks.Items.Add(listAvailableBooks.SelectedItem);
                listAvailableBooks.Items.Remove(listAvailableBooks.SelectedItem);
            }
        }

        // Chuyển tất cả các sách từ danh sách có sẵn sang danh sách đã chọn
        private void MoveAllToSelected(object sender, RoutedEventArgs e)
        {
            foreach (var item in listAvailableBooks.Items)
            {
                listSelectedBooks.Items.Add(item);
            }
            listAvailableBooks.Items.Clear();
        }

        // Chuyển một sách từ danh sách đã chọn trở lại danh sách có sẵn
        private void MoveToAvailable(object sender, RoutedEventArgs e)
        {
            if (listSelectedBooks.SelectedItem != null)
            {
                listAvailableBooks.Items.Add(listSelectedBooks.SelectedItem);
                listSelectedBooks.Items.Remove(listSelectedBooks.SelectedItem);
            }
        }

        // Chuyển tất cả các sách từ danh sách đã chọn trở lại danh sách có sẵn
        private void MoveAllToAvailable(object sender, RoutedEventArgs e)
        {
            foreach (var item in listSelectedBooks.Items)
            {
                listAvailableBooks.Items.Add(item);
            }
            listSelectedBooks.Items.Clear();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            var thongbao = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButton.YesNo);
            if(thongbao == MessageBoxResult.Yes)
                this.Close();

        }
    }
}