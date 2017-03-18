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
   public partial class MenuItem
    {
        private decimal price;
        private string description;
        private string imgPath;
        private string bigImgPath;
        private string name;
        private int number;
        BitmapImage bigImage;
        BitmapImage smallImage; 

        public MenuItem(decimal price, string description, string imgPath, string name, int number, string bigImgPath)
        {
            this.price = price;
            this.description = description;
            this.imgPath = imgPath;
            this.name = name;
            this.number = number;
            this.bigImgPath = bigImgPath;
            bigImage = new BitmapImage(new Uri(bigImgPath, UriKind.Relative));
            smallImage = new BitmapImage(new Uri(imgPath, UriKind.Relative));
        }     

        public decimal getPrice() { return this.price; }
        public string getDescription() { return this.description; }
        public string getImgPath() { return this.imgPath; }
        public string getName() { return this.name; }
        public int getNumber() { return this.number; }
        public BitmapImage getBigImg() { return this.bigImage; }
        public BitmapImage getSmallImg() { return this.smallImage; }
    }
}
