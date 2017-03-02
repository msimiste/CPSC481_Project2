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
    /// Interaction logic for Prompt.xaml
    /// </summary>
    public partial class Prompt : UserControl
    {
        private int code;

        public Prompt()
        {
            InitializeComponent();
            code = 0; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            code = 1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            code = 2;
        }

        public int getCode()
        {
            return code;
        }
    }
}
