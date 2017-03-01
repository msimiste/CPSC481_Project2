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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SilverCityOS
{
    /// <summary>
    /// Interaction logic for ucMenuItem.xaml
    /// </summary>
    public partial class ucMenuItem : UserControl
    {

        private decimal price;
        private string description;
        private String imgPath;
        private string name;
        private Int64 number;


        private Border b = new Border { BorderThickness = new Thickness(0, 2, 0, 2), BorderBrush = Brushes.Black, };
        private Border imgBorder = new Border { BorderThickness = new Thickness(2), BorderBrush = Brushes.Black };
        private Int64 height = 250;
        private Button menuButton = new Button { Height = 100, Width = 100 };
        PathFigure myPath = new PathFigure { StartPoint = new Point(0.5, 0.0) };
        LineSegment myLine = new LineSegment { Point = new Point(0.5, 1.0) };
        private Path p = new Path { Data = Geometry.Parse("M0.5,0 L0.5,1 M0,0.5 L1,0.5"), StrokeThickness = 4, Stretch = Stretch.Fill, Stroke = Brushes.Green };
        private TextBox txtBox_ItemName = new TextBox { Height = 30, Width = 150, TextAlignment = TextAlignment.Center, FontWeight = FontWeights.Bold, FontSize = 12 };
        private TextBox txtBox_ItemPrice = new TextBox { Height = 30, Width = 150, TextAlignment = TextAlignment.Center, FontWeight = FontWeights.Bold, FontSize = 22 };
        private TextBox txtBox_ItemDescription = new TextBox { Height = 135, Width = 385, TextAlignment = TextAlignment.Center, FontWeight = FontWeights.Bold, TextWrapping = TextWrapping.Wrap, FontSize = 16 };
        private Image img;

        public ucMenuItem(decimal price, string description, string imgPath, string name, Int64 number)
        {
            InitializeComponent();
            this.price = price;
            this.description = description;
            this.imgPath = imgPath;
            this.name = name;
            this.number = number;
            img = new Image { Height = 200, Width = 200, Source = new BitmapImage(new Uri(imgPath, UriKind.Relative)) };
            setUp();
        } 

        private void setUp()
        {
            ucMenuItemCanvas.Height = height; 
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
            imgBorder.Child = img;
            txtBox_ItemDescription.Text = this.description;
            txtBox_ItemName.Text = this.name;
            txtBox_ItemPrice.Text = price.ToString("C", CultureInfo.CurrentCulture);

            ucMenuItemCanvas.Children.Add(menuButton);
            ucMenuItemCanvas.Children.Add(imgBorder);
            ucMenuItemCanvas.Children.Add(txtBox_ItemDescription);
            ucMenuItemCanvas.Children.Add(txtBox_ItemPrice);
            ucMenuItemCanvas.Children.Add(txtBox_ItemName);
        }


        public decimal getPrice() { return this.price; }
        public string getDescription() { return this.description; }
        public string getImgPath() { return this.imgPath; }
        public string getName() { return this.name; }
        public Int64 getNumber() { return this.number; }

        public Button getMenuButton()
        {
            return this.menuButton;
        }

        public Border getImgBorder()
        {
            return this.imgBorder;
        }

        public TextBox getItemTxtBox()
        {

            return txtBox_ItemName;
        }
        public TextBox getPriceTxtBox()
        {
            return txtBox_ItemPrice;
        }
        public TextBox getDescTxtBox()
        {
            return txtBox_ItemDescription;
        }
    }
}
