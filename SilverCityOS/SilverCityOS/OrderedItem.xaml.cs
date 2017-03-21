﻿using System;
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

        public OrderedItem(MenuItem item, MainWindow window, int code)
        {
            this.code = code;
            this.window = window;
            this.item = item;
            InitializeComponent();
           // qty.Text = code.ToString();
            itemName.Text = item.getName();
            itemPrice.Text = "$"+item.getPrice().ToString("0.00");
            itemNum.Text = "#"+item.getNumber().ToString();
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
            main.Background = Brushes.LightGray;
            button.IsEnabled = false;
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
    }
}