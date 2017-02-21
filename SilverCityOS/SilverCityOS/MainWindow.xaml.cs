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
        private bool CallWaiterStatus = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAppetizers_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCallWaiterClick(object sender, RoutedEventArgs e)
        {
            if (CallWaiterStatus)
            {
                btnCallWaiter.Background = Brushes.Transparent;
                btnCallWaiter.ToolTip = new ToolTip { Content = "Click to Call Waiter" };
                btnCallWaiter.BorderBrush = new SolidColorBrush(Colors.Black);
                CallWaiterStatus = false;
            }
            else if (!CallWaiterStatus)
            {
                btnCallWaiter.Background = new SolidColorBrush(Colors.Yellow);
                btnCallWaiter.ToolTip = new ToolTip { Content = "Click Again To Cancel Call to Waiter" };
                btnCallWaiter.BorderBrush = new SolidColorBrush(Colors.Yellow);
                CallWaiterStatus = true;
            }
        }
    }
}
