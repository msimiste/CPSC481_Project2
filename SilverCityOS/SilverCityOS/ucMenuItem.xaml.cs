﻿using System;
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

        Balloon bAdd, bImage;

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
            itemPriceBack.Content = "." + price[1];
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

        public void showBalloons()
        {
            hideBalloons();
            if (this.IsHitTestVisible)
            {
                if (bAdd == null)
                {
                    bAdd = new Balloon(btnAdd, "Press this button to add an item to the order list", BalloonType.Help, true, false);
                    
                }
                if (bImage == null)
                {
                    bImage = new Balloon(btnImage, "Press this button to view a larger image", BalloonType.Help, true, false);
                    Point pd = btnImage.PointToScreen(new Point(0d, 0d));
                    bImage.Left = pd.X + 100;
                    bImage.Top = pd.Y + 50;
                    bImage.PathPointRight.Visibility = Visibility.Hidden;
                    bImage.PathPointLeft.Visibility = Visibility.Visible;
                }
                bAdd.Show();
                bImage.Show();
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
                if (bImage != null)
                {
                    bImage.Hide();
                }
            }
        }
    }
}

