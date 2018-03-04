using System;
using System.Collections.Generic;
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

namespace Chap1
{
    /// <summary>
    /// Interaction logic for ProductsManagement.xaml
    /// </summary>
    public partial class ProductsManagement : Page
    {
        ProductsFactory factory; 
        public ProductsManagement()
        {
            InitializeComponent();
            factory = new ProductsFactory();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            dataGrid.ItemsSource = factory.FindProducts(textBox.Text);
        }
    }
}
