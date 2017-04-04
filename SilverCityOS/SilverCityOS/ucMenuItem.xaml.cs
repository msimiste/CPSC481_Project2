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
            itemImg.Source = new BitmapImage(new Uri(item.getImgPath(), UriKind.Relative));
            itemNumber.Text = item.getNumber().ToString() + ". ";
            itemName.Text = item.getName();
            if (item.isSpicy())
            {
                itemName.Text = item.getName() + " 🌶";
                itemName.Foreground = Brushes.Red;
                itemNumber.Foreground = Brushes.Red;
            }
            string[] price = item.getPrice().ToString("C", CultureInfo.CurrentCulture).Split('.');
            itemPriceFront.Content = price[0];
            itemPriceBack.Content = "."+price[1];
            mainGrid.Children.Remove(addClicked);
        }

        private async void button_add(object sender, RoutedEventArgs e)
        {
            window.addToOrder(item);
            window.scrlViewerOrderItems.ScrollToBottom();
            window.sendCheck();
            if (!mainGrid.Children.Contains(addClicked))
            {
                mainGrid.Children.Add(addClicked);
                await Task.Delay(50);
                mainGrid.Children.Remove(addClicked);
            }
        }

        private void img_click(object sender, RoutedEventArgs e)
        {
            ItemInfo desc = new ItemInfo(item, window);
            window.mainGrid.Children.Add(window.getCover());
            desc.ShowDialog();
            window.mainGrid.Children.Remove(window.getCover());
        }

    }
}
