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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int orderNumber = 0;
        int orderedNumber = 0;
        private bool CallWaiterStatus = false;
        Rectangle cover;

        public MainWindow()
        {
            InitializeComponent();
            setupCover();
            mainGrid.Children.Remove(cover);
            sViewer_Stackpanel.Children.Add(new Welcome());
            calculatePrice();
        }

        private void btnAppetizers_Click(object sender, RoutedEventArgs e)
        {
            setScrollComponents();
        }

        private void btnCallWaiterClick(object sender, RoutedEventArgs e)
        {
            if (CallWaiterStatus)
            {
                btnCallWaiter.Background = Brushes.Transparent;
                waiterTextbox.Text = "Call Waiter";
                btnCallWaiter.ToolTip = new ToolTip { Content = "Click to Call Waiter" };
                btnCallWaiter.BorderBrush = new SolidColorBrush(Colors.Black);
                CallWaiterStatus = false;
            }
            else if (!CallWaiterStatus)
            {
                btnCallWaiter.Background = new SolidColorBrush(Colors.Yellow);
                waiterTextbox.Text = "Cancel Call Waiter";
                btnCallWaiter.ToolTip = new ToolTip { Content = "Click Again To Cancel Call to Waiter" };
                //btnCallWaiter.BorderBrush = new SolidColorBrush(Colors.Yellow);
                CallWaiterStatus = true;
            }
        }

        private void setScrollComponents()
        {  
            Appetizers appetizers = new Appetizers(this, "Appetizers");
            //sViewer_Stackpanel.Children.Add(new TextBox { VerticalContentAlignment = VerticalAlignment.Center, TextAlignment=TextAlignment.Center,FontSize = 33, Text = appetizers.getName(), Height = 100.0, Width = sViewer_Stackpanel.Width });
            lblCategories.Content = appetizers.getName();
            sViewer_Stackpanel.Children.Clear();
            foreach (var item in appetizers.getItemList())
            {
                Border b = new Border { BorderThickness = new Thickness(0, 2, 0, 2), BorderBrush = Brushes.Black, };

                b.Child = item;
                sViewer_Stackpanel.Children.Add(b);
            }
        }

        private void btnSpecialNote_Click(object sender, RoutedEventArgs e)
        {
            Prompt prompt = new Prompt("Waiter will be here shortly to address your concern");
            mainGrid.Children.Add(cover);
            bool? hi = prompt.ShowDialog();
            System.Console.WriteLine(hi);
            mainGrid.Children.Remove(cover);

        }

        private void btnDineIn_Click(object sender, RoutedEventArgs e)
        {
            Prompt prompt = new Prompt("Order as DINE-IN?");
            mainGrid.Children.Add(cover);
            bool? hi = prompt.ShowDialog();
            mainGrid.Children.Remove(cover);
            if(hi == true)
            {
                foreach(OrderedItem item in orderItems.Children)
                {
                    if(item.getCode() >= orderedNumber)
                    {
                        item.sent(true);
                    }
                }
                orderedNumber = orderNumber;
            }
        }

        private void btnTakeOut_Click(object sender, RoutedEventArgs e)
        {
            Prompt prompt = new Prompt("Order as Takeout?");
            mainGrid.Children.Add(cover);
            bool? hi = prompt.ShowDialog();
            mainGrid.Children.Remove(cover);
            if (hi == true)
            {
                foreach (OrderedItem item in orderItems.Children)
                {
                    if (item.getCode() >= orderedNumber)
                    {
                        item.sent(false);
                    }
                }
                orderedNumber = orderNumber;
            }
        }

        private void btnHelp_Click(object sender, RoutedEventArgs e)
        {
            mainGrid.Children.Add(cover);
            new HelpInfo().ShowDialog();
            mainGrid.Children.Remove(cover);
        }

        private void btnPayBill_Click(object sender, RoutedEventArgs e)
        {
            Prompt prompt = new Prompt("Call Bill and Reset?");
            mainGrid.Children.Add(cover);
            bool? hi = prompt.ShowDialog();
            mainGrid.Children.Remove(cover);
            if (hi == true)
            {
                sViewer_Stackpanel.Children.Clear();
                lblCategories.Content = "SILVER CITY RESTAURANT";
                sViewer_Stackpanel.Children.Add(new Welcome());
                orderItems.Children.Clear();
                calculatePrice();
            }
        }

        private void btnSoup_Click(object sender, RoutedEventArgs e)
        {
            
        }

        public void deleteFromOrder(int code)
        {
            orderItems.Children.RemoveAt(code);
            foreach(OrderedItem item in orderItems.Children)
            {
                if(item.getCode() >= code)
                {
                    item.decCode();
                }
            }
            orderNumber--;
            calculatePrice();
        }

        public void addToOrder(MenuItem item)
        {
            orderItems.Children.Add(new OrderedItem(item, this, orderNumber));
            orderNumber++;
            calculatePrice();
        }

        public void viewItem(MenuItem item)
        {
            ItemInfo view = new ItemInfo(item);
            view.ShowDialog();
        }

        public Rectangle getCover()
        {
            return cover;
        }

        private void calculatePrice()
        {
            decimal subtotal = 0;
            foreach (OrderedItem item in orderItems.Children)
            {
                subtotal += item.getItem().getPrice();
            }
            decimal tax = subtotal * (decimal)0.05;
            decimal total = subtotal + tax;
            lblSTotal.Content = "Subtotal: $" + subtotal.ToString("0.00");
            lblTax.Content = "Tax: $" + tax.ToString("0.00");
            lblTotal.Content = "Total: $" + total.ToString("0.00");

        }

        private void setupCover()
        {
            cover = new Rectangle()
             {
                 Opacity = 0.7,
                 Fill = Brushes.Black
             };
            Grid.SetColumnSpan(cover, 3);
        }
    }
}
