using SilverCityOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverCityOS
{
    public class Appetizers : MenuSection {

        private string name;
        private List<ucMenuItem> items;
        public Appetizers(MainWindow window, string name)
        {
            this.name = name;           
            generate(window);
        }


        public void generate(MainWindow window)
        {
            items = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem((decimal)3.50, "Vegetable Spring Rolls (2)", "Pictures/BeefAndMushrooms_sm.JPG", "Vegetable Spring Rolls", 1, "Pictures/BeefAndMushrooms.jpg")),
                new  ucMenuItem (window, new MenuItem((decimal)6.50, "Vietnamese Spring Rolls (4)", "Pictures/testImage2_sm.jpg", "Spring Rolls", 2,"Pictures/testImage2.jpg")),
                new  ucMenuItem (window, new MenuItem((decimal)9.50, "Deep Fried Wonton", "Pictures/testImage3_sm.jpg", "Wontons", 3,"Pictures/testImage3.jpg")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, "Deep Fried Chicken Wings", "Pictures/testImage4_sm.jpg", "Chicken Wings", 4, "Pictures/testImage4.jpg")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, "Salt & Pepper Chicken Wings", "Pictures/testImage5_sm.jpg", "Chicken Wings", 5, "Pictures/testImage5.jpg")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, "Dry Garlic Spareribs", "Pictures/testImage1_sm.jpg", "Spare Ribs", 6,"Pictures/testImage1.jpg")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, "Salt & Pepper Spareribs", "Pictures/testImage2_sm.jpg", "Spare Ribs", 7,"Pictures/testImage2.jpg")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, "Grilled Pork with Vegetable Dumplings(10)", "Pictures/testImage3_sm.jpg", "Dumplings", 8, "Pictures/testImage3.jpg"))
            };
        }
       

        public List<ucMenuItem> getItemList(){
            
            return this.items;   
        }

        public string getName() { return this.name; }


    }
}
