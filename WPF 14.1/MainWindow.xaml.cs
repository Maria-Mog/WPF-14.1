using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_14._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Картошка",
                PpoductImage = "Data/1.png",
                ProductPrice = 55.25,
                Category = Сategorys.Food
            });
            products.Add(new Product()
            {
                ProductName = "Мясо",
                PpoductImage = "Data/2.png",
                ProductPrice = 420.80,
                Category = Сategorys.Food
            }); products.Add(new Product()
            {
                ProductName = "Рис",
                PpoductImage = "Data/3.png",
                ProductPrice = 82.00,
                Category = Сategorys.Food
            });
            products.Add(new Product()
            {
                ProductName = "Блендер",
                PpoductImage = "Data/4.png",
                ProductPrice = 4560.00,
                Category = Сategorys.Appliances
            }); products.Add(new Product()
            {
                ProductName = "Фен",
                PpoductImage = "Data/5.png",
                ProductPrice = 3244.00,
                Category = Сategorys.Appliances
            });
            lstBox.ItemsSource = products;
        }
    }
}
