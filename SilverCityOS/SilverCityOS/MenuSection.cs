using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverCityOS
{
   public class MenuSection
    {
        private Appetizers appetizers;

        public MenuSection(MainWindow window) {
            appetizers = new Appetizers(window, "Appetizers");
        }

        public Appetizers getAppetizers() {
            return appetizers;
        }
    }
}
