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
        Rectangle cover;
        TextBox sendCover;
        TextBox payCover;
        enum section { Appetizers, Soup, Beef, Chicken, Seafood, Vegetable, Hotplate, Rice, Egg, Drinks };
        public enum type { normal, takeOut, dineIn, payBill };
        Menu menu;
        bool helpMode = false;
        bool pastMainScreen = false;
        List<Balloon> helpBalloons;

        public MainWindow()
        {
            InitializeComponent();
            menu = new Menu(this);
            setupCover();
            setupStart();

        }

        //To setup on start and resetf
        private void setupStart()
        {
            orderNumber = 0;
            orderedNumber = 0;
            pastMainScreen = false;
            mainGrid.Children.Remove(upArrowCover);
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

        private void setScrollComponents(Menu menu, int category)
        {
            scrlViewer_MenuItems.ScrollToTop();
            Grid.SetColumnSpan(middleSec, 1);
            stkPanel_OrderPanel.Opacity = 1;
            stkPanel_OrderPanel.IsHitTestVisible = true;
            sViewer_Stackpanel.Children.Clear();
            foreach (var item in menu.getCategory(category))
            {
                sViewer_Stackpanel.Children.Add(item);
            }            
        }

        private void btnSpecialNote_Click(object sender, RoutedEventArgs e)
        {
            
            Prompt prompt = new Prompt(this, "Press OK to call your server for a dietary concern", (int)type.normal);
            mainGrid.Children.Add(cover);
            bool? hi = prompt.ShowDialog();
            System.Console.WriteLine(hi);
            mainGrid.Children.Remove(cover);

        }

        private void btnDineIn_Click(object sender, RoutedEventArgs e)
        {

            Prompt prompt = new Prompt(this, "Pressing OK will place your order as DINE-IN", (int)type.dineIn);
            mainGrid.Children.Add(cover);
            bool? hi = prompt.ShowDialog();
            mainGrid.Children.Remove(cover);
            if (hi == true)
            {
                foreach (OrderedItem item in orderItems.Children)
                {
                    if (item.getCode() >= orderedNumber)
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
            Prompt prompt = new Prompt(this, "Pressing OK will place your order as TAKE-OUT ", (int)type.takeOut);
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
           new HelpInfo().ShowDialog();
           mainGrid.Children.Remove(cover);
        }

        private void btnHelp1_Click(object sender, RoutedEventArgs e)
        {
            setHelpBoxes();
        }

        private void btnPayBill_Click(object sender, RoutedEventArgs e)
        {
            Prompt prompt = new Prompt(this, "⚠ Pressing OK will generate your ⚠ bill and clear your order", (int)type.payBill);
            mainGrid.Children.Add(cover);
            bool? hi = prompt.ShowDialog();
            mainGrid.Children.Remove(cover);
            if (hi == true)
            {
                setupStart();
                pastMainScreen = false;
            }
        }

        public void deleteFromOrder(int code)
        {
            orderItems.Children.RemoveAt(code);
            foreach (OrderedItem item in orderItems.Children)
            {
                if (item.getCode() >= code)
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
            ItemInfo view = new ItemInfo(item, this);
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
                btnDineIn.IsEnabled = true;
                btnTakeOut.IsEnabled = true;
                btnPayBill.IsEnabled = false;
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
                btnDineIn.IsEnabled = false;
                btnTakeOut.IsEnabled = false;
                btnPayBill.IsEnabled = true;
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
                btnPayBill.IsEnabled = false;
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
            mainGrid.Children.Remove(upArrowCover);
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
                Background = new SolidColorBrush() { Color = Colors.White, Opacity = 0.9 },
                IsHitTestVisible = false
            };
            Grid.SetColumnSpan(sendCover, 2);


            payCover = new TextBox()
            {
                Text = "To Pay Bill, Please Make an order by adding items to the order list and pressing Dine-In or Take-Out",
                FontSize = 20,
                TextWrapping = TextWrapping.Wrap,
                VerticalAlignment = VerticalAlignment.Stretch,
                VerticalContentAlignment = VerticalAlignment.Center,
                HorizontalContentAlignment = HorizontalAlignment.Center,
                BorderBrush = Brushes.Black,
                BorderThickness = new Thickness(1),
                Margin = new Thickness(5, 0, 5, 0),
                Padding = new Thickness(10),
                Background = new SolidColorBrush() { Color = Colors.White, Opacity = 0.9 },
                IsHitTestVisible = false
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
            }
            else if (scrollViewer.VerticalOffset == 0)
            {
                if (mainGrid.Children.Contains(upArrowCover)) { mainGrid.Children.Remove(upArrowCover); }
                if (!mainGrid.Children.Contains(downArrowCover)) { mainGrid.Children.Add(downArrowCover); }

            }
            else
            {
                if (!mainGrid.Children.Contains(downArrowCover))
                {
                    mainGrid.Children.Add(downArrowCover);
                }
                if (!mainGrid.Children.Contains(upArrowCover))
                {
                    mainGrid.Children.Add(upArrowCover);
                }
            }

            if (helpMode)
            {
                var scrollBalloons = Utilities.FindVisualChildren<ucMenuItem>(scrollViewer);


                foreach (ucMenuItem b in scrollBalloons)
                {
                    b.hideBalloons();
                }

                foreach (ucMenuItem b in scrollBalloons)
                {
                    var position = b.btnAdd.TransformToAncestor(this.scrlViewer_MenuItems).Transform(new Point(0, 0));
                    position.Y = position.Y - 250;           
                                     
                    if (-position.Y < b.ActualHeight && position.Y < scrollViewer.Height - 100)
                    {
                        b.showBalloons();
                        break;
                    }
                }


            }
        }


        private void btnAppetizers_Click(object sender, RoutedEventArgs e)
        {
            pastMainScreen = true;
            lblCategories.Content = "APPETIZERS";
            setScrollComponents(menu, (int)section.Appetizers);
            sectionCheck((Button)sender);
        }

        private void btnSoup_Click(object sender, RoutedEventArgs e)
        {
            pastMainScreen = true;
            lblCategories.Content = "SOUPS & SIZZLING RICE";
            setScrollComponents(menu, (int)section.Soup);
            sectionCheck((Button)sender);
        }

        private void btnBeef_Click(object sender, RoutedEventArgs e)
        {
            pastMainScreen = true;
            lblCategories.Content = "BEEF";
            setScrollComponents(menu, (int)section.Beef);
            sectionCheck((Button)sender);
        }

        private void btnChicken_Click(object sender, RoutedEventArgs e)
        {
            pastMainScreen = true;
            lblCategories.Content = "CHICKEN & DUCK";
            setScrollComponents(menu, (int)section.Chicken);
            sectionCheck((Button)sender);
        }

        private void btnSeafood_Click(object sender, RoutedEventArgs e)
        {
            pastMainScreen = true;
            lblCategories.Content = "PORK & SEAFOOD";
            setScrollComponents(menu, (int)section.Seafood);
            sectionCheck((Button)sender);
        }

        private void btnVegie_Click(object sender, RoutedEventArgs e)
        {
            pastMainScreen = true;
            lblCategories.Content = "VEGETABLES";
            setScrollComponents(menu, (int)section.Vegetable);
            sectionCheck((Button)sender);
        }

        private void btnHot_Click(object sender, RoutedEventArgs e)
        {
            pastMainScreen = true;
            lblCategories.Content = "HOT PLATE & HOT POTS";
            setScrollComponents(menu, (int)section.Hotplate);
            sectionCheck((Button)sender);
        }

        private void btnRice_Click(object sender, RoutedEventArgs e)
        {
            pastMainScreen = true;
            lblCategories.Content = "FRIED RICE & FRIED NOODLES";
            setScrollComponents(menu, (int)section.Rice);
            sectionCheck((Button)sender);
        }

        private void btnEgg_Click(object sender, RoutedEventArgs e)
        {
            pastMainScreen = true;
            lblCategories.Content = "EGG FOO YOUNG & CHOP SUEY";
            setScrollComponents(menu, (int)section.Egg);
            sectionCheck((Button)sender);
        }

        private void btnDrink_Click(object sender, RoutedEventArgs e)
        {
            pastMainScreen = true;
            lblCategories.Content = "DRINKS";
            setScrollComponents(menu, (int)section.Drinks);
            sectionCheck((Button)sender);
        }

        private void ordItemsChanged(object sender, ScrollChangedEventArgs e)
        {
            if (helpMode)
            {
                var scrollViewer = (ScrollViewer)sender;
                var orderedBalloons = Utilities.FindVisualChildren<OrderedItem>(this.scrlViewerOrderItems);

                foreach (OrderedItem ordI in orderedBalloons)
                {
                    ordI.hideBalloons();
                }

                foreach (OrderedItem ordI in orderedBalloons)
                {
                    var position = ordI.TransformToAncestor(this.scrlViewerOrderItems).Transform(new Point(0, 0));                             

                    if (-position.Y < ordI.ActualHeight && position.Y < scrollViewer.Height)
                    {
                        ordI.showBalloons();
                        break;
                    }
                }
            }
        }

        private void setHelpBoxes()
        {
            if (helpBalloons == null)
            {
                setupHelpBalloons();
            }

            if ((helpMode == false) && (pastMainScreen == true))
            { helpMode = true; }
            else { helpMode = false; }
            

            foreach (Balloon bal in helpBalloons)
            {
                if (helpMode)      { bal.Show(); }
                else
                { bal.Visibility = Visibility.Collapsed; }

            }            
          

            var scrollBalloons = Utilities.FindVisualChildren<ucMenuItem>(this.scrlViewer_MenuItems);
            var orderedBalloons = Utilities.FindVisualChildren<OrderedItem>(this.scrlViewerOrderItems);

            foreach (ucMenuItem b in scrollBalloons)
            {
                b.hideBalloons();
            }

            foreach (OrderedItem ordI in orderedBalloons)
            {
                ordI.hideBalloons();
            }


            if (helpMode)
            {
                foreach (ucMenuItem b in scrollBalloons)
                {
                    var position = b.btnAdd.TransformToAncestor(this.scrlViewer_MenuItems).Transform(new Point(0, 0));
                    position.Y = position.Y - 250;                   

                    if (-position.Y < b.ActualHeight && position.Y < this.scrlViewer_MenuItems.Height - 100)
                    {
                        b.showBalloons();
                        break;
                    }
                }     
                                
                foreach (OrderedItem ordI in orderedBalloons)
                {
                    var position = ordI.TransformToAncestor(this.scrlViewerOrderItems).Transform(new Point(0, 0));

                    if (-position.Y < ordI.ActualHeight && position.Y < this.scrlViewerOrderItems.Height)
                    {
                        ordI.showBalloons();
                        break;
                    }
                }
            }            
        }

        private void setupHelpBalloons()
        {
            helpBalloons = new List<Balloon>();
            Balloon balloon_waiter = new Balloon(btnCallWaiter, "Press this button to request/cancel server assistance", BalloonType.Help, false, false);
            Balloon balloon_help = new Balloon(btnHelp, "Press this button to view/remove help balloons", BalloonType.Help, false, false);
            Balloon balloon_dietary = new Balloon(btnSpecialNote, "Press this button to address dietary/allergy concerns", BalloonType.Help, false, false);
            Balloon balloon_dineIn = new Balloon(btnDineIn, "Press this button to place an order for Dine-In", BalloonType.Help, false, false);
            Balloon balloon_takeout = new Balloon(btnTakeOut, "Press this button to place an order for Take-Out", BalloonType.Help, false, false);
            Balloon balloon_payBill = new Balloon(btnPayBill, "Press this button to request your bill", BalloonType.Help, false, false);

            //place the call waiter help balloon
            Point pd = btnCallWaiter.PointToScreen(new Point(0d, 0d));
            balloon_waiter.Left = pd.X + 300;
            balloon_waiter.Top = pd.Y;
            balloon_waiter.PathPointBottomLeft.Visibility = Visibility.Visible;
            balloon_waiter.PathPointRight.Visibility = Visibility.Hidden;
            balloon_waiter.PathPointLeft.Visibility = Visibility.Hidden;

            //place the help menu help balloon
            pd = btnHelp.PointToScreen(new Point(0d, 0d));                     
            balloon_help.Top = pd.Y - 50;
            balloon_help.PathPointRight.Visibility = Visibility.Hidden;
            balloon_help.PathPointLeft.Visibility = Visibility.Hidden;
            balloon_help.PathPointBottomLeft.Visibility = Visibility.Visible;

            pd = btnSpecialNote.PointToScreen(new Point(0d, 0d));                       
            balloon_dietary.Top = pd.Y - 80;
            balloon_dietary.Left = pd.X - 20;
            balloon_dietary.PathPointRight.Visibility = Visibility.Hidden;
            balloon_dietary.PathPointLeft.Visibility = Visibility.Hidden;
            balloon_dietary.PathPointBottomRight.Visibility = Visibility.Visible;


            //place the dine in balloon
            pd = btnDineIn.PointToScreen(new Point(0d, 0d));           
            balloon_dineIn.Left = pd.X - 200;
            balloon_dineIn.Top = pd.Y - 50;
            balloon_dineIn.PathPointRight.Visibility = Visibility.Hidden;
            balloon_dineIn.PathPointLeft.Visibility = Visibility.Hidden;
            balloon_dineIn.PathPointBottomRight.Visibility = Visibility.Visible;

            pd = btnTakeOut.PointToScreen(new Point(0d, 0d));            

            pd = btnPayBill.PointToScreen(new Point(0d, 0d));
            balloon_payBill.Left = pd.X - 200;
            balloon_payBill.Top = pd.Y - 30;
            balloon_payBill.PathPointRight.Visibility = Visibility.Hidden;
            balloon_payBill.PathPointLeft.Visibility = Visibility.Hidden;
            balloon_payBill.PathPointBottomRight.Visibility = Visibility.Visible;

            helpBalloons.Add(balloon_takeout);
            helpBalloons.Add(balloon_help);
            helpBalloons.Add(balloon_dietary);
            helpBalloons.Add(balloon_dineIn);
            helpBalloons.Add(balloon_waiter);
            helpBalloons.Add(balloon_payBill);

        }
    }
}
