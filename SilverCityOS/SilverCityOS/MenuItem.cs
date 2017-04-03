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
        private int number;
        private string imgPath;
        private string name;
        bool spicy;
        
        public MenuItem(bool spicy, decimal price, int number, string imgPath, string name)
        {
            this.spicy = spicy;
            this.price = price;
            this.number = number;
            this.imgPath = imgPath;
            this.name = name;
        }

        public bool isSpicy() { return this.spicy; }
        public decimal getPrice() { return this.price; }
        public int getNumber() { return this.number; }
        public string getImgPath() { return this.imgPath; }
        public string getName() { return this.name; }
    }
}
