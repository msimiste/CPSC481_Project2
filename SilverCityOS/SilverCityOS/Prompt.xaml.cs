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
using System.Windows.Shapes;

namespace SilverCityOS
{
    /// <summary>
    /// Interaction logic for Prompt.xaml
    /// </summary>
    public partial class Prompt : Window
    {
        enum type { normal, placeOrder, payBill};

        public Prompt(MainWindow window, String message, int mode)
        {
            InitializeComponent();
            this.message.Text = message;
            if (mode == (int)type.normal)
            {
                mainStack.Children.Remove(itemBorder);
            }
            else if(mode == (int)type.placeOrder){
                foreach(OrderedItem item in window.orderItems.Children)
                {
                    if (item.getCode() >= window.orderedNumber)
                    {
                        /*Label entry = new Label()
                        {
                            Content = item.getItem().getName(),
                            Padding = new Thickness(20, 2, 20, 2),
                            BorderBrush = Brushes.Black,
                            BorderThickness = new Thickness(0, 0, 0, 1)
                        };*/
                        OrderedItem entry = new OrderedItem(item.getItem(), window, window.orderNumber);
                        entry.main.Children.RemoveAt(0);
                        Viewbox view = new Viewbox();
                        view.Child = new Label() { Content = item.getItem().getNumber() };
                        Grid.SetRowSpan(view, 2);
                        entry.main.Children.Insert(0, view);
                        itemList.Children.Add(entry);
                    }
                }
            }
        }

        private void Button_Click_Okay(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
