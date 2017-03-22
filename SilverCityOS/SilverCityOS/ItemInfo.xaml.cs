using System;
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
using System.Windows.Shapes;

namespace SilverCityOS
{
    /// <summary>
    /// Interaction logic for ItemInfo.xaml
    /// </summary>
    public partial class ItemInfo : Window
    {
        public ItemInfo(MenuItem item)
        {
            InitializeComponent();
            //itemImg.Source = item.getBigImg();           
            itemName.Content = "Item #"+ item.getNumber();
            itemPrice.Content = item.getPrice().ToString("C",CultureInfo.CurrentCulture);
            itemDesc.Text = item.getName() +"\n"+ item.getDescription();
        }
    }
}
