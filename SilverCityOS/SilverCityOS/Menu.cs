using SilverCityOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverCityOS
{
    public class Menu {

        private List<ucMenuItem> appetizers;
        private List<ucMenuItem> soup;
        private List<ucMenuItem> beef;
        private List<ucMenuItem> chicken;
        private List<ucMenuItem> seafood;
        private List<ucMenuItem> vegetable;
        private List<ucMenuItem> hotplate;
        private List<ucMenuItem> rice;
        private List<ucMenuItem> noodle;
        private List<ucMenuItem> egg;
        private List<ucMenuItem> chopsuey;

        public Menu(MainWindow window)
        {
            generateAppetizers(window);
            generateSoup(window);
            generateBeef(window);
            generateChicken(window);
            generateSeafood(window);
            generateVegetable(window);
            generateHotplate(window);
            generateRice(window);
            generateNoodle(window);
            generateEgg(window);
            generateChopsuey(window);
        }

        private void generateAppetizers(MainWindow window)
        {
            appetizers = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem((decimal)3.50 , 1, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg", "Vegetable Spring Rolls", "Vegetable Spring Rolls (2)")),
                new  ucMenuItem (window, new MenuItem((decimal)6.50 , 2, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg", "Spring Rolls", "Vietnamese Spring Rolls (4)")),
                new  ucMenuItem (window, new MenuItem((decimal)9.50 , 3, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg", "Wontons", "Deep Fried Wonton")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 4, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg", "Chicken Wings", "Deep Fried Chicken Wings")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 5, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg", "Chicken Wings", "Salt & Pepper Chicken Wings")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 6, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg", "Spare Ribs", "Dry Garlic Spareribs")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 7, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg", "Spare Ribs", "Salt & Pepper Spareribs")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 8, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg", "Dumplings", "Grilled Pork with Vegetable Dumplings(10)"))
            };
        }

        private void generateSoup(MainWindow window)
        {
            soup = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem((decimal)3.50 , 1, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg", "Vegetable Spring Rolls", "Vegetable Spring Rolls (2)")),
                new  ucMenuItem (window, new MenuItem((decimal)6.50 , 2, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg", "Spring Rolls", "Vietnamese Spring Rolls (4)")),
                new  ucMenuItem (window, new MenuItem((decimal)9.50 , 3, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg", "Wontons", "Deep Fried Wonton")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 4, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg", "Chicken Wings", "Deep Fried Chicken Wings")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 5, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg", "Chicken Wings", "Salt & Pepper Chicken Wings")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 6, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg", "Spare Ribs", "Dry Garlic Spareribs")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 7, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg", "Spare Ribs", "Salt & Pepper Spareribs")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 8, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg", "Dumplings", "Grilled Pork with Vegetable Dumplings(10)"))
            };
        }

        private void generateBeef(MainWindow window)
        {
            beef = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem((decimal)3.50 , 1, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg", "Vegetable Spring Rolls", "Vegetable Spring Rolls (2)")),
                new  ucMenuItem (window, new MenuItem((decimal)6.50 , 2, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg", "Spring Rolls", "Vietnamese Spring Rolls (4)")),
                new  ucMenuItem (window, new MenuItem((decimal)9.50 , 3, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg", "Wontons", "Deep Fried Wonton")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 4, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg", "Chicken Wings", "Deep Fried Chicken Wings")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 5, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg", "Chicken Wings", "Salt & Pepper Chicken Wings")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 6, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg", "Spare Ribs", "Dry Garlic Spareribs")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 7, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg", "Spare Ribs", "Salt & Pepper Spareribs")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 8, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg", "Dumplings", "Grilled Pork with Vegetable Dumplings(10)"))
            };
        }

        private void generateChicken(MainWindow window)
        {
            chicken = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem((decimal)3.50 , 1, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg", "Vegetable Spring Rolls", "Vegetable Spring Rolls (2)")),
                new  ucMenuItem (window, new MenuItem((decimal)6.50 , 2, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg", "Spring Rolls", "Vietnamese Spring Rolls (4)")),
                new  ucMenuItem (window, new MenuItem((decimal)9.50 , 3, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg", "Wontons", "Deep Fried Wonton")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 4, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg", "Chicken Wings", "Deep Fried Chicken Wings")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 5, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg", "Chicken Wings", "Salt & Pepper Chicken Wings")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 6, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg", "Spare Ribs", "Dry Garlic Spareribs")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 7, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg", "Spare Ribs", "Salt & Pepper Spareribs")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 8, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg", "Dumplings", "Grilled Pork with Vegetable Dumplings(10)"))
            };
        }

        private void generateSeafood(MainWindow window)
        {
            seafood = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem((decimal)3.50 , 1, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg", "Vegetable Spring Rolls", "Vegetable Spring Rolls (2)")),
                new  ucMenuItem (window, new MenuItem((decimal)6.50 , 2, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg", "Spring Rolls", "Vietnamese Spring Rolls (4)")),
                new  ucMenuItem (window, new MenuItem((decimal)9.50 , 3, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg", "Wontons", "Deep Fried Wonton")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 4, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg", "Chicken Wings", "Deep Fried Chicken Wings")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 5, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg", "Chicken Wings", "Salt & Pepper Chicken Wings")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 6, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg", "Spare Ribs", "Dry Garlic Spareribs")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 7, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg", "Spare Ribs", "Salt & Pepper Spareribs")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 8, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg", "Dumplings", "Grilled Pork with Vegetable Dumplings(10)"))
            };
        }

        private void generateVegetable(MainWindow window)
        {
            vegetable = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem((decimal)3.50 , 1, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg", "Vegetable Spring Rolls", "Vegetable Spring Rolls (2)")),
                new  ucMenuItem (window, new MenuItem((decimal)6.50 , 2, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg", "Spring Rolls", "Vietnamese Spring Rolls (4)")),
                new  ucMenuItem (window, new MenuItem((decimal)9.50 , 3, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg", "Wontons", "Deep Fried Wonton")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 4, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg", "Chicken Wings", "Deep Fried Chicken Wings")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 5, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg", "Chicken Wings", "Salt & Pepper Chicken Wings")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 6, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg", "Spare Ribs", "Dry Garlic Spareribs")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 7, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg", "Spare Ribs", "Salt & Pepper Spareribs")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 8, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg", "Dumplings", "Grilled Pork with Vegetable Dumplings(10)"))
            };
        }

        private void generateHotplate(MainWindow window)
        {
            hotplate = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem((decimal)3.50 , 1, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg", "Vegetable Spring Rolls", "Vegetable Spring Rolls (2)")),
                new  ucMenuItem (window, new MenuItem((decimal)6.50 , 2, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg", "Spring Rolls", "Vietnamese Spring Rolls (4)")),
                new  ucMenuItem (window, new MenuItem((decimal)9.50 , 3, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg", "Wontons", "Deep Fried Wonton")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 4, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg", "Chicken Wings", "Deep Fried Chicken Wings")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 5, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg", "Chicken Wings", "Salt & Pepper Chicken Wings")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 6, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg", "Spare Ribs", "Dry Garlic Spareribs")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 7, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg", "Spare Ribs", "Salt & Pepper Spareribs")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 8, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg", "Dumplings", "Grilled Pork with Vegetable Dumplings(10)"))
            };
        }

        private void generateRice(MainWindow window)
        {
            rice = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem((decimal)3.50 , 1, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg", "Vegetable Spring Rolls", "Vegetable Spring Rolls (2)")),
                new  ucMenuItem (window, new MenuItem((decimal)6.50 , 2, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg", "Spring Rolls", "Vietnamese Spring Rolls (4)")),
                new  ucMenuItem (window, new MenuItem((decimal)9.50 , 3, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg", "Wontons", "Deep Fried Wonton")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 4, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg", "Chicken Wings", "Deep Fried Chicken Wings")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 5, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg", "Chicken Wings", "Salt & Pepper Chicken Wings")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 6, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg", "Spare Ribs", "Dry Garlic Spareribs")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 7, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg", "Spare Ribs", "Salt & Pepper Spareribs")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 8, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg", "Dumplings", "Grilled Pork with Vegetable Dumplings(10)"))
            };
        }

        private void generateNoodle(MainWindow window)
        {
            noodle = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem((decimal)3.50 , 1, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg", "Vegetable Spring Rolls", "Vegetable Spring Rolls (2)")),
                new  ucMenuItem (window, new MenuItem((decimal)6.50 , 2, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg", "Spring Rolls", "Vietnamese Spring Rolls (4)")),
                new  ucMenuItem (window, new MenuItem((decimal)9.50 , 3, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg", "Wontons", "Deep Fried Wonton")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 4, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg", "Chicken Wings", "Deep Fried Chicken Wings")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 5, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg", "Chicken Wings", "Salt & Pepper Chicken Wings")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 6, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg", "Spare Ribs", "Dry Garlic Spareribs")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 7, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg", "Spare Ribs", "Salt & Pepper Spareribs")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 8, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg", "Dumplings", "Grilled Pork with Vegetable Dumplings(10)"))
            };
        }

        private void generateEgg(MainWindow window)
        {
            egg = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem((decimal)3.50 , 1, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg", "Vegetable Spring Rolls", "Vegetable Spring Rolls (2)")),
                new  ucMenuItem (window, new MenuItem((decimal)6.50 , 2, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg", "Spring Rolls", "Vietnamese Spring Rolls (4)")),
                new  ucMenuItem (window, new MenuItem((decimal)9.50 , 3, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg", "Wontons", "Deep Fried Wonton")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 4, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg", "Chicken Wings", "Deep Fried Chicken Wings")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 5, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg", "Chicken Wings", "Salt & Pepper Chicken Wings")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 6, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg", "Spare Ribs", "Dry Garlic Spareribs")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 7, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg", "Spare Ribs", "Salt & Pepper Spareribs")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 8, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg", "Dumplings", "Grilled Pork with Vegetable Dumplings(10)"))
            };
        }

        private void generateChopsuey(MainWindow window)
        {
            chopsuey = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem((decimal)3.50 , 1, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg", "Vegetable Spring Rolls", "Vegetable Spring Rolls (2)")),
                new  ucMenuItem (window, new MenuItem((decimal)6.50 , 2, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg", "Spring Rolls", "Vietnamese Spring Rolls (4)")),
                new  ucMenuItem (window, new MenuItem((decimal)9.50 , 3, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg", "Wontons", "Deep Fried Wonton")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 4, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg", "Chicken Wings", "Deep Fried Chicken Wings")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 5, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg", "Chicken Wings", "Salt & Pepper Chicken Wings")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 6, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg", "Spare Ribs", "Dry Garlic Spareribs")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 7, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg", "Spare Ribs", "Salt & Pepper Spareribs")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 8, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg", "Dumplings", "Grilled Pork with Vegetable Dumplings(10)"))
            };
        }
        public List<ucMenuItem> getCategory(int category)
        {
            switch (category)
            {
                case 1:
                    return appetizers;
                case 2:
                    return soup;
                case 3:
                    return beef;
                case 4:
                    return chicken;
                case 5:
                    return seafood;
                case 6:
                    return vegetable;
                case 7:
                    return hotplate;
                case 8:
                    return rice;
                case 9:
                    return noodle;
                case 10:
                    return egg;
                case 11:
                    return chopsuey;
                default:
                    return appetizers;
            }
        }
        public List<ucMenuItem> getAppetizer() { return appetizers; }
        public List<ucMenuItem> getSoup() { return soup; }
        public List<ucMenuItem> getBeef() { return beef; }
        public List<ucMenuItem> getChicken() { return chicken; }
        public List<ucMenuItem> getSeafood() { return seafood; }
        public List<ucMenuItem> getVegetable() { return vegetable; }
        public List<ucMenuItem> getHotplate() { return hotplate; }
        public List<ucMenuItem> getRice() { return rice; }
        public List<ucMenuItem> getNoodle() { return noodle; }
        public List<ucMenuItem> getEgg() { return egg; }
        public List<ucMenuItem> getChopsuey() { return chopsuey; }
    }
}
