using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Shapes;

namespace SilverCityOS
{
    /// <summary>
    /// Interaction logic for ItemInfo.xaml
    /// </summary>
    public partial class ItemInfo : Window
    {
        MainWindow window;
        MenuItem item;

        public ItemInfo(MenuItem item, MainWindow window)
        {
            InitializeComponent();
            this.window = window;
            this.item = item;
            itemImg.Source = new BitmapImage(new Uri(item.getImgPath(), UriKind.Relative));
            itemName.Content = "#"+ item.getNumber()+". "+item.getName();
            itemPrice.Content = item.getPrice().ToString("C",CultureInfo.CurrentCulture);
        }

        private void button_add(object sender, RoutedEventArgs e)
        {
            window.addToOrder(item);
            window.scrlViewerOrderItems.ScrollToBottom();
            window.sendCheck();
            DialogResult = false;
        }
    }
}
