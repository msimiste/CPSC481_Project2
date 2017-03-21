using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverCityOS
{
   public class MenuSection
    {
        private Menu appetizers;

        public MenuSection(MainWindow window) {
            appetizers = new Menu(window);
        }

        public Menu getAppetizers() {
            return appetizers;
        }
    }
}
