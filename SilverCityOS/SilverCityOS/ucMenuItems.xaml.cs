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
    /// Interaction logic for ucMenuItems.xaml
    /// </summary>
    public partial class ucMenuItems : UserControl
    {
        public ucMenuItems()
        {
            InitializeComponent();
            fillItems();

           
        }

        private Border b = new Border { BorderThickness = new Thickness(0, 2, 0, 2), BorderBrush = Brushes.Black, };
        private Border imgBorder = new Border { BorderThickness = new Thickness(2), BorderBrush = Brushes.Black };
        private Int64 height = 250;
        private Button menuButton = new Button { Height = 100, Width = 100 };
        PathFigure myPath = new PathFigure { StartPoint = new Point(0.5, 0.0) };
        LineSegment myLine = new LineSegment { Point = new Point(0.5, 1.0) };
        private Path p = new Path { Data = Geometry.Parse("M0.5,0 L0.5,1 M0,0.5 L1,0.5"), StrokeThickness = 4, Stretch = Stretch.Fill, Stroke = Brushes.Green };
        private Image img = new Image { Height = 200, Width = 200, Source = new BitmapImage(new Uri("Pictures/bell.png", UriKind.Relative)) };
        private TextBox txtBox_ItemName = new TextBox { Height = 30, Width = 150, TextAlignment = TextAlignment.Center, FontWeight = FontWeights.Bold, FontSize = 22 };
        private TextBox txtBox_ItemPrice = new TextBox { Height = 30, Width = 150, TextAlignment = TextAlignment.Center, FontWeight = FontWeights.Bold, FontSize = 22 };
        private TextBox txtBox_ItemDescription = new TextBox { Height = 135, Width = 385, TextAlignment = TextAlignment.Center, FontWeight = FontWeights.Bold, TextWrapping = TextWrapping.Wrap, FontSize = 16 };


        private void fillItems() {
            ucMenuItemsCanvas.Height = height;
            menuButton.Content = p;
            menuButton.SetValue(Canvas.LeftProperty, 30.0);
            menuButton.SetValue(Canvas.TopProperty, 75.0);
            imgBorder.SetValue(Canvas.LeftProperty, 160.0);
            imgBorder.SetValue(Canvas.TopProperty, 15.0);
            img.SetValue(Canvas.LeftProperty, 160.0);
            img.SetValue(Canvas.TopProperty, 15.0);
            txtBox_ItemName.SetValue(Canvas.LeftProperty, 380.0);
            txtBox_ItemName.SetValue(Canvas.TopProperty, 50.0);
            txtBox_ItemPrice.SetValue(Canvas.LeftProperty, 615.0);
            txtBox_ItemPrice.SetValue(Canvas.TopProperty, 50.0);
            txtBox_ItemDescription.SetValue(Canvas.LeftProperty, 380.0);
            txtBox_ItemDescription.SetValue(Canvas.TopProperty, 80.0);


            ucMenuItemsCanvas.Children.Add(menuButton);
            imgBorder.Child = img;
            ucMenuItemsCanvas.Children.Add(imgBorder);
            ucMenuItemsCanvas.Children.Add(txtBox_ItemName);
            ucMenuItemsCanvas.Children.Add(txtBox_ItemPrice);
            ucMenuItemsCanvas.Children.Add(txtBox_ItemDescription);
        }

    }
}
