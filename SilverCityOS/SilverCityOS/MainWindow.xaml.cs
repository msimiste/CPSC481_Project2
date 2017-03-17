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
        private bool CallWaiterStatus = false;
        List<ucMenuSection> menuSections = new List<ucMenuSection>();
        ucMenuSection test;
        public MainWindow()
        {
            var screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            var screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            InitializeComponent();
            mainGrid.Children.Remove(cover);
            sViewer_Stackpanel.Children.Add(new Welcome());
            calculatePrice();
            Appetizers apps = new Appetizers(this,"Appetizers");
            ucMenuSection appetizers = new ucMenuSection(apps);
            test = appetizers;
            menuSections.Add(appetizers);        
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
            sViewer_Stackpanel.Children.Clear();
            sViewer_Stackpanel.Children.Add(test);
           
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
                foreach(OrderedItem item in stkPanel_OrderItems.Children)
                {
                    item.sent();
                }
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
                foreach (OrderedItem item in stkPanel_OrderItems.Children)
                {
                    item.sent();
                }
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
                //sViewer_Stackpanel.Children.Clear();
                lblCategories.Content = "SILVER CITY RESTAURANT";
               // sViewer_Stackpanel.Children.Add(new Welcome());
                stkPanel_OrderItems.Children.Clear();
                calculatePrice();
            }
        }

        private void btnSoup_Click(object sender, RoutedEventArgs e)
        {
            
        }

        public void deleteFromOrder(int code)
        {
            stkPanel_OrderItems.Children.RemoveAt(code);
            foreach(OrderedItem item in stkPanel_OrderItems.Children)
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
            stkPanel_OrderItems.Children.Add(new OrderedItem(item, this, orderNumber));
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
            foreach (OrderedItem item in stkPanel_OrderItems.Children)
            {
                subtotal += item.getItem().getPrice();
            }
            decimal tax = subtotal * (decimal)0.05;
            decimal total = subtotal + tax;
            lblSTotal.Content = "Subtotal: $" + subtotal.ToString("0.00");
            lblTax.Content = "Tax: $" + tax.ToString("0.00");
            lblTotal.Content = "Total: $" + total.ToString("0.00");

        }
    }
}
