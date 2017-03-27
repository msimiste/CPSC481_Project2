using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
        public int orderNumber = 0;
        public int orderedNumber = 0;
        private bool CallWaiterStatus = false;
        Rectangle cover;
        TextBox sendCover;
        TextBox payCover;
        enum section { Appetizers, Soup, Beef, Chicken, Seafood, Vegetable, Hotplate, Rice, Noodle, Egg, Chopsuey };
        public enum type { normal, takeOut, dineIn, payBill};
        Menu menu;
        bool helpMode = false;


        public MainWindow()
        {
            InitializeComponent();
            menu = new Menu(this);
            setupCover();
            setupStart();
        }
        
        //To setup on start and reset
        private void setupStart()
        {
            orderNumber = 0;
            orderedNumber = 0;
            sViewer_Stackpanel.Children.Clear();
            orderItems.Children.Clear();
            lblCategories.Content = "SILVER CITY RESTAURANT";
            stkPanel_OrderPanel.Opacity = 0;
            stkPanel_OrderPanel.IsHitTestVisible = false;
            sViewer_Stackpanel.Children.Add(new Welcome());
            Grid.SetColumnSpan(middleSec, 2);
            sectionCheck(new Button());
            sendCheck();
            calculatePrice();
        }

        //private void btnCallWaiterClick(object sender, RoutedEventArgs e)
        //{
        //    if (CallWaiterStatus)
        //    {
        //        btnCallWaiter.Background = new SolidColorBrush(Colors.AntiqueWhite);
        //        waiterTextbox.Text = "CALL WAITER";
        //        waiterTextbox.FontSize = 35;
        //        waiterTextbox.Height = 100;
        //        btnCallWaiter.ToolTip = new ToolTip { Content = "Click to Call Waiter" };
        //        btnCallWaiter.BorderBrush = new SolidColorBrush(Colors.Black);
        //        CallWaiterStatus = false;
        //    }
        //    else if (!CallWaiterStatus)
        //    {
        //        btnCallWaiter.Background = new SolidColorBrush(Colors.Yellow);
        //        waiterTextbox.Text = "CANCEL CALL WAITER";
        //        waiterTextbox.FontSize = 30;
        //        waiterTextbox.Height = 140;
        //        btnCallWaiter.ToolTip = new ToolTip { Content = "Click Again To Cancel Call to Waiter" };
        //        CallWaiterStatus = true;
        //    }
        //}

        private void setScrollComponents(Menu menu, int category)
        {
            Grid.SetColumnSpan(middleSec, 1);
            stkPanel_OrderPanel.Opacity = 1;
            stkPanel_OrderPanel.IsHitTestVisible = true;
            sViewer_Stackpanel.Children.Clear();
            foreach (var item in menu.getCategory(category))
            {
                sViewer_Stackpanel.Children.Add(item);
            }
            //mainGrid.Children.Add(downArrowCover);
        }

        private void btnSpecialNote_Click(object sender, RoutedEventArgs e)
        {
            Prompt prompt = new Prompt(this, "Waiter will be here shortly to address your concern", (int)type.normal);
            mainGrid.Children.Add(cover);
            bool? hi = prompt.ShowDialog();
            System.Console.WriteLine(hi);
            mainGrid.Children.Remove(cover);

        }

        private void btnDineIn_Click(object sender, RoutedEventArgs e)
        {
            Prompt prompt = new Prompt(this, "Order as DINE-IN?", (int)type.dineIn);
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
            sendCheck();
        }

        private void btnTakeOut_Click(object sender, RoutedEventArgs e)
        {
            Prompt prompt = new Prompt(this, "Order as Takeout?", (int)type.takeOut);
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
            sendCheck();
        }

        private void btnHelp_Click(object sender, RoutedEventArgs e)
        {
           // mainGrid.Children.Add(cover);          
            // new HelpInfo().ShowDialog();
            setHelpBoxes();
            //mainGrid.Children.Remove(cover);
        }

        private void btnPayBill_Click(object sender, RoutedEventArgs e)
        {
            Prompt prompt = new Prompt(this, "Call Bill and Reset?", (int)type.payBill);
            mainGrid.Children.Add(cover);
            bool? hi = prompt.ShowDialog();
            mainGrid.Children.Remove(cover);
            if (hi == true)
            {
                setupStart();
            }
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

        public void sendCheck()
        {
            if (orderedNumber < orderNumber)
            {
                if (!orderControlGrid.Children.Contains(payCover))
                {
                    orderControlGrid.Children.Add(payCover);
                }
                if (orderControlGrid.Children.Contains(sendCover))
                {
                    orderControlGrid.Children.Remove(sendCover);
                }
                //btnDineIn.IsEnabled = true;
                //btnTakeOut.IsEnabled = true;
                //btnPayBill.IsEnabled = false;
            }
            else
            {
                if (!orderControlGrid.Children.Contains(sendCover))
                {
                    orderControlGrid.Children.Add(sendCover);
                }
                if (orderControlGrid.Children.Contains(payCover))
                {
                    orderControlGrid.Children.Remove(payCover);
                }
                //btnDineIn.IsEnabled = false;
                //btnTakeOut.IsEnabled = false;
                //btnPayBill.IsEnabled = true;
            }
            //To Disable All At Start
            if (orderNumber == 0)
            {
                if (!orderControlGrid.Children.Contains(sendCover))
                {
                    orderControlGrid.Children.Add(sendCover);
                }
                if (!orderControlGrid.Children.Contains(payCover))
                {
                    orderControlGrid.Children.Add(payCover);
                }
                //btnPayBill.IsEnabled = false;
            }
        }

        private void sectionCheck(Button toDisable)
        {
            foreach (Button section in controlSections.Children)
            {
                section.IsEnabled = true;
            }
            toDisable.IsEnabled = false;
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
            lblSTotal.Content = "Subtotal: " + subtotal.ToString("C", CultureInfo.CurrentCulture);
            lblTax.Content = "Tax: " + tax.ToString("C", CultureInfo.CurrentCulture);
            lblTotal.Content = "Total: " + total.ToString("C", CultureInfo.CurrentCulture);

        }

        private void setupCover()
        {
            cover = new Rectangle()
             {
                 Opacity = 0.7,
                 Fill = Brushes.Black
             };
            Grid.SetColumnSpan(cover, 3);

            sendCover = new TextBox()
            {
                Text = "To Place an Order, Please Add New Items Onto Order List",
                FontSize = 20,
                TextWrapping = TextWrapping.Wrap,
                VerticalAlignment = VerticalAlignment.Stretch,
                VerticalContentAlignment = VerticalAlignment.Center,
                HorizontalContentAlignment = HorizontalAlignment.Center,
                BorderBrush = Brushes.Black,
                BorderThickness = new Thickness(1),
                Margin = new Thickness(5, 12, 5, 0),
                Padding = new Thickness(10),
                Background = new SolidColorBrush() { Color = Colors.White, Opacity = 0.9 }
            };
            Grid.SetColumnSpan(sendCover, 2);


            payCover = new TextBox()
            {
                Text = "To Pay Bill, Please Make Sure All Items are Placed in Order",
                FontSize = 20,
                TextWrapping = TextWrapping.Wrap,
                VerticalAlignment = VerticalAlignment.Stretch,
                VerticalContentAlignment = VerticalAlignment.Center,
                HorizontalContentAlignment = HorizontalAlignment.Center,
                BorderBrush = Brushes.Black,
                BorderThickness = new Thickness(1),
                Margin = new Thickness(5, 0, 5, 0),
                Padding = new Thickness(10),
                Background = new SolidColorBrush() { Color = Colors.White, Opacity = 0.9 }
            };
            Grid.SetColumnSpan(payCover, 2);
            Grid.SetRow(payCover, 1);
        }

        private void OnScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            var scrollViewer = (ScrollViewer)sender;
            if (scrollViewer.VerticalOffset == scrollViewer.ScrollableHeight)
            {
                if (mainGrid.Children.Contains(downArrowCover))
                {
                    mainGrid.Children.Remove(downArrowCover);
                }
            }else
            {
                if (!mainGrid.Children.Contains(downArrowCover))
                {
                    mainGrid.Children.Add(downArrowCover);
                }
            }
                
        }

        private void btnAppetizers_Click(object sender, RoutedEventArgs e)
        {
            lblCategories.Content = "APPETIZERS";
            setScrollComponents(menu, (int)section.Appetizers);
            sectionCheck((Button)sender);
        }

        private void btnSoup_Click(object sender, RoutedEventArgs e)
        {
            lblCategories.Content = "SOUPS & SIZZLING RICE";
            setScrollComponents(menu, (int)section.Soup);
            sectionCheck((Button)sender);
        }

        private void btnBeef_Click(object sender, RoutedEventArgs e)
        {
            lblCategories.Content = "BEEF";
            setScrollComponents(menu, (int)section.Beef);
            sectionCheck((Button)sender);
        }

        private void btnChicken_Click(object sender, RoutedEventArgs e)
        {
            lblCategories.Content = "CHICKEN & DUCK";
            setScrollComponents(menu, (int)section.Chicken);
            sectionCheck((Button)sender);
        }

        private void btnSeafood_Click(object sender, RoutedEventArgs e)
        {
            lblCategories.Content = "SEAFOOD";
            setScrollComponents(menu, (int)section.Seafood);
            sectionCheck((Button)sender);
        }

        private void btnVegie_Click(object sender, RoutedEventArgs e)
        {
            lblCategories.Content = "VEGETABLES";
            setScrollComponents(menu, (int)section.Vegetable);
            sectionCheck((Button)sender);
        }

        private void btnHot_Click(object sender, RoutedEventArgs e)
        {
            lblCategories.Content = "HOT PLATE & HOT POTS";
            setScrollComponents(menu, (int)section.Hotplate);
            sectionCheck((Button)sender);
        }

        private void btnRice_Click(object sender, RoutedEventArgs e)
        {
            lblCategories.Content = "FRIED RICE & FRIED NOODLES";
            setScrollComponents(menu, (int)section.Rice);
            sectionCheck((Button)sender);
        }

        private void btnEgg_Click(object sender, RoutedEventArgs e)
        {
            lblCategories.Content = "EGG FOO YOUNG & CHOP SUEY";
            setScrollComponents(menu, (int)section.Noodle);
            sectionCheck((Button)sender);
        }

        private void btnDrink_Click(object sender, RoutedEventArgs e)
        {
            lblCategories.Content = "DRINKS";
            setScrollComponents(menu, (int)section.Noodle);
            sectionCheck((Button)sender);
        }

        private void setHelpBoxes() {
            if (helpMode == false) { helpMode = true; }
            else { helpMode = false; }

            var popups = Utilities.FindVisualChildren<Popup>(this);
            foreach (Popup pu in popups) {
                pu.IsOpen = helpMode;
            }                     
        }

    }
}
