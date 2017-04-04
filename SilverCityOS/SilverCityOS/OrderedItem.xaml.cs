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
    /// Interaction logic for OrderedItem.xaml
    /// </summary>
    public partial class OrderedItem : UserControl
    {
        int code;
        MainWindow window;
        MenuItem item;
        Balloon bAdd;


        public OrderedItem(MenuItem item, MainWindow window, int code)
        {
            this.code = code;
            this.window = window;
            this.item = item;
            InitializeComponent();          
            itemName.Text = item.getNumber()+". "+item.getName();
            itemPrice.Text = item.getPrice().ToString("C",CultureInfo.CurrentCulture);
        }

        public int getCode()
        {
            return code;
        }

        public void decCode()
        {
            code--;
        }

        public void sent(bool dineIn)
        {
            border.Background = Brushes.LightGray;
            main.Children.Remove(buttonAdd);
            Grid.SetColumn(itemName, 0);
            Grid.SetColumnSpan(itemName, 2);
            itemName.Padding = new Thickness(10, 0, 0, 0);
            Image mode;
            if (dineIn)
            {
                mode = new Image() { Source = new BitmapImage(new Uri("Pictures/ScreenElement/DineIn.png", UriKind.Relative)) };
            }
            else
            {
                mode = new Image() { Source = new BitmapImage(new Uri("Pictures/ScreenElement/TakeOut2.png", UriKind.Relative)) };
            }
            Grid.SetColumn(mode, 2);
            underPrice.Children.Add(mode);
        }

        public MenuItem getItem()
        {
            return item;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            window.deleteFromOrder(code);
            window.sendCheck();
        }


        public void showBalloons()
        {
            hideBalloons();
            if (this.IsHitTestVisible)
            {
                if (bAdd == null)
                {
                    bAdd = new Balloon(buttonAdd, "Press this button to remove an Item from the Order list", BalloonType.Help, false, false);
                }
                bAdd.Show();
            }

        }

        public void hideBalloons()
        {
            if (this.IsHitTestVisible)
            {
                if (bAdd != null)
                {
                    bAdd.Hide();
                }
               
            }
        }
    }
}
