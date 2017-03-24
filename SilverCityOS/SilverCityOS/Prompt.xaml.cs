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
        MainWindow window;

        public Prompt(MainWindow window, String message, int mode)
        {
            InitializeComponent();
            this.window = window;
            this.message.Text = message;
            //Normal message Prompt
            if (mode == (int)MainWindow.type.normal)
            {
                mainStack.Children.Remove(middleSec);
                mainGrid.Children.Remove(closeButton);
            }
            //To Format for Take Out Prompt
            else if (mode == (int)MainWindow.type.takeOut) {
                modePic.Source = new BitmapImage(new Uri("Pictures/ScreenElement/TakeOut2.png", UriKind.Relative));
                rightStack.Children.Remove(showBill);
                generateItemList(window, false);
            }
            //To Format for Dine in Prompt
            else if (mode == (int)MainWindow.type.dineIn)
            {
                modePic.Source = new BitmapImage(new Uri("Pictures/ScreenElement/DineIn.png", UriKind.Relative));
                rightStack.Children.Remove(showBill);
                generateItemList(window, false);
            }
            //Format for Pay Bill Prompt
            else if (mode == (int)MainWindow.type.payBill)
            {
                modePic.Source = new BitmapImage(new Uri("Pictures/ScreenElement/PayBill.png", UriKind.Relative));
                itemListScroll.Height = 50;
                //Showing the price
                rightStack.Children.Add(new Label() { FontSize = 30, Padding = new Thickness(0, 0, 30, 0), Margin = new Thickness(0), HorizontalAlignment = HorizontalAlignment.Stretch, HorizontalContentAlignment = HorizontalAlignment.Right, Content = window.lblSTotal.Content, VerticalContentAlignment = VerticalAlignment.Bottom });
                rightStack.Children.Add(new Label() { FontSize = 30, Padding = new Thickness(0, 0, 30, 0), Margin = new Thickness(0), HorizontalAlignment = HorizontalAlignment.Stretch, HorizontalContentAlignment = HorizontalAlignment.Right, Content = window.lblTax.Content });
                rightStack.Children.Add(new Label() { FontSize = 30, Padding = new Thickness(0, 0, 0, 0), Margin = new Thickness(30, 0, 30, 0), HorizontalAlignment = HorizontalAlignment.Stretch, HorizontalContentAlignment = HorizontalAlignment.Right, Content = window.lblTotal.Content, FontWeight = FontWeights.Bold, BorderThickness = new Thickness(0, 2, 0, 2), BorderBrush = Brushes.Black});
            }
        }

        private void Button_Click_Okay(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void generateItemList(MainWindow window, bool payBill)
        {
            itemList.Children.Clear();
            foreach (OrderedItem item in window.orderItems.Children)
            {
                if (item.getCode() >= window.orderedNumber || payBill)
                {
                    /*Label entry = new Label()
                    {
                        Content = item.getItem().getName(),
                        Padding = new Thickness(20, 2, 20, 2),
                        BorderBrush = Brushes.Black,
                        BorderThickness = new Thickness(0, 0, 0, 1)
                    };*/
                    OrderedItem entry = new OrderedItem(item.getItem(), window, window.orderNumber) { Height = 50 };
                    entry.border.Height = 50;
                    entry.main.Height = 50;
                    Grid.SetRowSpan(entry.itemPrice, 2);
                    entry.itemPrice.FontSize = 25;
                    entry.main.Children.RemoveAt(0);
                    //Viewbox view = new Viewbox();
                    //view.Child = new Label() { Content = item.getItem().getNumber() };
                    //Grid.SetRowSpan(view, 2);
                    //entry.main.Children.Insert(0, view);
                    Grid.SetColumn(entry.itemName, 0);
                    Grid.SetColumnSpan(entry.itemName, 2);
                    entry.main.Background = Brushes.Transparent;
                    itemList.Children.Add(entry);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Show item list on the left
            showBill.IsEnabled = false;
            //middleSec.Children.RemoveAt(0);
            rightStack.Children.Remove(itemListScroll);
            rightStack.Children.Insert(1, new Rectangle() { Height = 50, Opacity = 0 });
            middleSec.Children.Add(new Rectangle() { Fill = Brushes.White, Opacity = 0.8 });
            middleSec.Children.Add(itemListScroll);
            itemListScroll.Background = Brushes.Transparent;
            itemList.Background = Brushes.Transparent;
            itemListScroll.Height = 275;
            generateItemList(window, true);
            
        }
    }
}
