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
    /// Interaction logic for ucMenuSection.xaml
    /// </summary>
    public partial class ucMenuSection : UserControl
    {
        private MenuSection section;
        public ucMenuSection(MenuSection s)
        {
            this.section = s;
            InitializeComponent();
            addMenuItems();
        }

        private void addMenuItems() {
            TextBox box = new TextBox {VerticalAlignment = VerticalAlignment.Top, VerticalContentAlignment = VerticalAlignment.Center, TextAlignment = TextAlignment.Center, FontSize = 33, Text = section.getName(), Height = 100.0, Width = sViewer_Stackpanel.Width };
            ucMainGrid.Children.Add(box);
            Grid.SetRow(box, 0);
                //sViewer_Stackpanel.Children.Add(new TextBox { VerticalContentAlignment = VerticalAlignment.Center, TextAlignment = TextAlignment.Center, FontSize = 33, Text = section.getName(), Height = 100.0, Width = sViewer_Stackpanel.Width });
            // lblCategories.Content = section.getName();
            foreach (ucMenuItem mi in section.getItemList()) {
                sViewer_Stackpanel.Children.Add(mi);
            }
        }
    }
}
