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
        enum section { Appetizers, Soup, Beef, Chicken, Seafood, Vegetable, Hotplate, Rice, Noodle, Egg, Chopsuey };
        enum type { normal, placeOrder, payBill};
        Menu menu;
        bool helpMode = false;


        public MainWindow()
        {
            InitializeComponent();
            menu = new Menu(this);
            setupCover();
            sViewer_Stackpanel.Children.Add(new Welcome());
            calculatePrice();
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
                CallWaiterStatus = true;
            }
        }

        private void setScrollComponents(Menu menu, int category)
        {  
            sViewer_Stackpanel.Children.Clear();
            foreach (var item in menu.getCategory(category))
            {
                sViewer_Stackpanel.Children.Add(item);
            }
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
            Prompt prompt = new Prompt(this, "Order as DINE-IN?", (int)type.placeOrder);
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
            Prompt prompt = new Prompt(this, "Order as Takeout?", (int)type.placeOrder);
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
            mainGrid.Children.Add(cover);          
            // new HelpInfo().ShowDialog();
            setHelpBoxes();
            mainGrid.Children.Remove(cover);
        }

        private void btnPayBill_Click(object sender, RoutedEventArgs e)
        {
            Prompt prompt = new Prompt(this, "Call Bill and Reset?", (int)type.payBill);
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
                btnDineIn.IsEnabled = true;
                btnTakeOut.IsEnabled = true;
            }
            else
            {
                btnDineIn.IsEnabled = false;
                btnTakeOut.IsEnabled = false;
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
            lblSTotal.Content = "Subtotal: $" + subtotal.ToString("C", CultureInfo.CurrentCulture);
            lblTax.Content = "Tax: $" + tax.ToString("C", CultureInfo.CurrentCulture);
            lblTotal.Content = "Total: $" + total.ToString("C", CultureInfo.CurrentCulture);

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


        private void btnAppetizers_Click(object sender, RoutedEventArgs e)
        {
            lblCategories.Content = "Appetizers";
            setScrollComponents(menu, (int)section.Appetizers);
            sectionCheck((Button)sender);
        }

        private void btnSoup_Click(object sender, RoutedEventArgs e)
        {
            lblCategories.Content = "Soups & Sizzling Rice";
            setScrollComponents(menu, (int)section.Soup);
            sectionCheck((Button)sender);
        }

        private void btnBeef_Click(object sender, RoutedEventArgs e)
        {
            lblCategories.Content = "Beef";
            setScrollComponents(menu, (int)section.Beef);
            sectionCheck((Button)sender);
        }

        private void btnChicken_Click(object sender, RoutedEventArgs e)
        {
            lblCategories.Content = "Chicken & Duck";
            setScrollComponents(menu, (int)section.Chicken);
            sectionCheck((Button)sender);
        }

        private void btnSeafood_Click(object sender, RoutedEventArgs e)
        {
            lblCategories.Content = "Seafood";
            setScrollComponents(menu, (int)section.Seafood);
            sectionCheck((Button)sender);
        }

        private void btnVegie_Click(object sender, RoutedEventArgs e)
        {
            lblCategories.Content = "Vegetables";
            setScrollComponents(menu, (int)section.Vegetable);
            sectionCheck((Button)sender);
        }

        private void btnHot_Click(object sender, RoutedEventArgs e)
        {
            lblCategories.Content = "Hot Plates & Hot Pots";
            setScrollComponents(menu, (int)section.Hotplate);
            sectionCheck((Button)sender);
        }

        private void btnRice_Click(object sender, RoutedEventArgs e)
        {
            lblCategories.Content = "Fried Rice";
            setScrollComponents(menu, (int)section.Rice);
            sectionCheck((Button)sender);
        }

        private void btnNoodle_Click(object sender, RoutedEventArgs e)
        {
            lblCategories.Content = "Fried Noodle";
            setScrollComponents(menu, (int)section.Noodle);
            sectionCheck((Button)sender);
        }

        private void btnEgg_Click(object sender, RoutedEventArgs e)
        {
            lblCategories.Content = "Egg Foo Young";
            setScrollComponents(menu, (int)section.Egg);
            sectionCheck((Button)sender);
        }

        private void btnChopSuey_Click(object sender, RoutedEventArgs e)
        {
            lblCategories.Content = "Chop Suey";
            setScrollComponents(menu, (int)section.Chopsuey);
            sectionCheck((Button)sender);
        }

        private void btnAboutUs_Click(object sender, RoutedEventArgs e)
        {
            lblCategories.Content = "Appetizers";
            setScrollComponents(menu, (int)section.Appetizers);
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
