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

namespace My_PortA
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
        private void Produktoversigt_Click(object sender, RoutedEventArgs e)
        {
            HomePageGrid.Visibility = Visibility.Collapsed;
            MainFrame.Visibility = Visibility.Visible;
            MainFrame.Navigate(new My_PortA.View.ProductPage());

        }
        public void VisHovedMenu()
        {
            MainFrame.Visibility = Visibility.Collapsed;
            HomePageGrid.Visibility = Visibility.Visible;

        }

       
    }
}