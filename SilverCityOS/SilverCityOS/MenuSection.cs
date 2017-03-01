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
        private List<MenuItem> items = new List<MenuItem>();

        public MenuSection(string name) {
            this.sectionName = name;
        }

        public void addItem(MenuItem item) {
            this.items.Add(item);
        }
    }
}
