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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SilverCityOS
{
    /// <summary>
    /// Interaction logic for ucMenuItem.xaml
    /// </summary>
    public partial class ucMenuItem : UserControl
    {
        MenuItem item;
        MainWindow window;

        public ucMenuItem(MainWindow window, MenuItem item)
        {
            InitializeComponent();
            this.item = item;
            this.window = window;
            setUp();
        } 

        private void setUp()
        {
            itemImg.Source = new BitmapImage(new Uri(item.getSImgPath(), UriKind.Relative));
            itemNumber.Text = item.getNumber().ToString() + ". ";
            itemName.Text = item.getName();
            string[] price = item.getPrice().ToString("C", CultureInfo.CurrentCulture).Split('.');
            itemPriceFront.Content = price[0];
            itemPriceBack.Content = "."+price[1];
        }

        private void button_add(object sender, RoutedEventArgs e)
        {
            window.addToOrder(item);
            window.scrlViewerOrderItems.ScrollToBottom();
            window.sendCheck();
        }

        private void img_click(object sender, RoutedEventArgs e)
        {
            ItemInfo desc = new ItemInfo(item);
            window.mainGrid.Children.Add(window.getCover());
            desc.ShowDialog();
            window.mainGrid.Children.Remove(window.getCover());
        }
    }
}
