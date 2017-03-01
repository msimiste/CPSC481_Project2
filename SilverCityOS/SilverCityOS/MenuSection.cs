using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverCityOS
{
   public class MenuSection
    {
        private string sectionName;
        private List<ucMenuItem> items = new List<ucMenuItem>();

        public MenuSection(string name) {
            this.sectionName = name;
        }

        public void addItem(ucMenuItem item) {
            this.items.Add(item);
        }
    }
}
