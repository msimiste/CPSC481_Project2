﻿using SilverCityOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverCityOS
{
    public class Appetizers {

        private string name;
        private List<ucMenuItem> items;
        public Appetizers(MainWindow window, string name)
        {
            this.name = name;
            generate(window);
        }

        private void generate(MainWindow window)
        {
            items = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem((decimal)3.50, "Vegetable Spring Rolls (2)", "Pictures/BeefAndMushrooms.JPG", "Vegetable Spring Rolls", 1)),
                new  ucMenuItem (window, new MenuItem((decimal)6.50, "Vietnamese Spring Rolls (4)", "Pictures/testImage2.jpg", "Spring Rolls", 2)),
                new  ucMenuItem (window, new MenuItem((decimal)9.50, "Deep Fried Wonton", "Pictures/testImage3.jpg", "Wontons", 3)),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, "Deep Fried Chicken Wings", "Pictures/testImage4.jpg", "Chicken Wings", 4)),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, "Salt & Pepper Chicken Wings", "Pictures/testImage5.jpg", "Chicken Wings", 5)),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, "Dry Garlic Spareribs", "Pictures/testImage1.jpg", "Spare Ribs", 6)),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, "Salt & Pepper Spareribs", "Pictures/testImage2.jpg", "Spare Ribs", 7)),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, "Grilled Pork with Vegetable Dumplings(10)", "Pictures/testImage3.jpg", "Dumplings", 8))
            };
        }

        public List<ucMenuItem> getItemList(){
            
            return this.items;   
        }

        public string getName() { return this.name; }


    }
}
