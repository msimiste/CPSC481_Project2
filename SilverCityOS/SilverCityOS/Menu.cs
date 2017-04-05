using SilverCityOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverCityOS
{
    public class Menu
    {

        private List<ucMenuItem> appetizers;
        private List<ucMenuItem> soup;
        private List<ucMenuItem> beef;
        private List<ucMenuItem> chicken;
        private List<ucMenuItem> seafood;
        private List<ucMenuItem> vegetable;
        private List<ucMenuItem> hotplate;
        private List<ucMenuItem> rice;
        private List<ucMenuItem> egg;
        private List<ucMenuItem> drinks;

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
            generateEgg(window);
            generateDrinks(window);
        }



        private void generateAppetizers(MainWindow window)
        {
            appetizers = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem(false, (decimal)3.50 , 1, "Pictures/Menu/1.jpg", "Vegetable Spring Rolls (2)")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)6.50 , 2, "Pictures/Menu/2.jpg", "Vietnamese Spring Rolls (4)")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)9.50 , 3, "Pictures/Menu/3.jpg", "Deep Fried Wonton")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)10.95, 4, "Pictures/Menu/4.jpg", "Deep Fried Chicken Wings")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)11.95, 5, "Pictures/Menu/5.jpg", "Salt & Pepper Chicken Wings")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)11.95, 6, "Pictures/Menu/6.jpg", "Dry Garlic Spareribs")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)11.95, 7, "Pictures/Menu/7.jpg", "Salt & Pepper Spareribs")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)10.95, 8, "Pictures/Menu/8.jpg", "Grilled Pork Dumplings (10)"))
            };
        }

        private void generateSoup(MainWindow window)
        {
            soup = new List<ucMenuItem>()
            {
               new  ucMenuItem (window, new MenuItem(false, (decimal)4.50 , 9 , "Pictures/Menu/9.jpg" , "Wonton Soup")),
               new  ucMenuItem (window, new MenuItem(false, (decimal)8.95 , 10, "Pictures/Menu/10.jpg", "Wor Wonton Soup")),
               new  ucMenuItem (window, new MenuItem(true , (decimal)8.95 , 11, "Pictures/Menu/11.jpg", "Hot & Sour Soup")),
               new  ucMenuItem (window, new MenuItem(false, (decimal)12.95, 12, "Pictures/Menu/12.jpg", "Crab Meat & Fish Maw Soup")),
               new  ucMenuItem (window, new MenuItem(false, (decimal)10.95, 13, "Pictures/Menu/13.jpg", "Chicken & Cream Corn Soup")),
               new  ucMenuItem (window, new MenuItem(false, (decimal)10.95, 14, "Pictures/Menu/14.jpg", "Beef & Egg Drop Thick Soup")),
               new  ucMenuItem (window, new MenuItem(true , (decimal)13.95, 15, "Pictures/Menu/15.jpg", "Hot & Sour Soup Sizzling Rice")), 
               new  ucMenuItem (window, new MenuItem(false, (decimal)13.95, 16, "Pictures/Menu/16.jpg", "Shrimp & Tomato Sizzling Rice")),
               new  ucMenuItem (window, new MenuItem(false, (decimal)15.95, 17, "Pictures/Menu/17.jpg", "Seafood Sizzling Rice")),
               new  ucMenuItem (window, new MenuItem(false, (decimal)13.95, 18, "Pictures/Menu/18.jpg", "Beef Sizzling Rice")),
               new  ucMenuItem (window, new MenuItem(false, (decimal)13.95, 19, "Pictures/Menu/19.jpg", "Chicken Sizzling Rice")),
               new  ucMenuItem (window, new MenuItem(false, (decimal)11.95, 20, "Pictures/Menu/20.jpg", "Mixed Vegetable Sizzling Rice"))   
            };
        }

        private void generateBeef(MainWindow window)
        {
            beef = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem(true , (decimal)12.50, 21, "Pictures/Menu/21.jpg", "Ginger Beef")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)12.95, 22, "Pictures/Menu/22.jpg", "Curried Beef")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)12.95, 23, "Pictures/Menu/23.jpg", "Beef with 2 Kinds of Mushroom")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)12.95, 24, "Pictures/Menu/24.jpg", "Beef with Black Bean Sauce")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)12.95, 25, "Pictures/Menu/25.jpg", "Beef with Tomatoes")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)13.95, 26, "Pictures/Menu/26.jpg", "Beef with Broccoli")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)13.95, 27, "Pictures/Menu/27.jpg", "Beef with Snow Peas")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)13.95, 28, "Pictures/Menu/28.jpg", "Beef with Mixed Vegetables")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)13.95, 29, "Pictures/Menu/29.jpg", "Beef with Chinese Broccoli")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)13.95, 30, "Pictures/Menu/30.jpg", "Beef with Ginger & Onion")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)13.95, 31, "Pictures/Menu/31.jpg", "Beef with Satay Sauce")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)13.95, 32, "Pictures/Menu/32.jpg", "Szechuan Syle Beef"))

            };
        }

        private void generateChicken(MainWindow window)
        {
            chicken = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem(true , (decimal)12.50, 33, "Pictures/Menu/33.jpg", "Ginger Chicken")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)12.95, 34, "Pictures/Menu/34.jpg", "Sweet & Sour Chicken")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)12.95, 35, "Pictures/Menu/35.jpg", "Palace Style Chicken")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)12.95, 36, "Pictures/Menu/36.jpg", "Lemon Soo Gai   (Chicken Breast)")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)12.95, 37, "Pictures/Menu/37.jpg", "Almond Soo Gai   (Chicken Breast)")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)12.95, 38, "Pictures/Menu/38.jpg", "Diced Chicken & Cashews")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)12.95, 39, "Pictures/Menu/39.jpg", "Diced Chicken & Almond")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)12.95, 40, "Pictures/Menu/40.jpg", "Diced Chicken in Yellow Bean Sauce")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)12.95, 41, "Pictures/Menu/41.jpg", "Sliced Chicken in Spicy Sauce")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)12.95, 42, "Pictures/Menu/42.jpg", "Sliced Chicken with Mixed Vegetables")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)12.95, 43, "Pictures/Menu/43.jpg", "Sliced Chicken with 2 kinds of Mushroom")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)12.95, 44, "Pictures/Menu/44.jpg", "Sliced Chicken in Black Bean Sauce")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)12.95, 45, "Pictures/Menu/45.jpg", "Sliced Chicken in Curry Sauce")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)12.95, 46, "Pictures/Menu/46.jpg", "Sweet & Sour Chicken Balls")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)12.95, 47, "Pictures/Menu/47.jpg", "Sliced Chicken with Mushrooms")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)13.95, 48, "Pictures/Menu/48.jpg", "Crispy Chicken (Half)")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)12.50, 49, "Pictures/Menu/49.jpg", "Salt & Pepper Chicken")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)12.95, 50, "Pictures/Menu/50.jpg", "HK Style Diced Cripsy Chicken")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)12.95, 51, "Pictures/Menu/51.jpg", "Stir Fried Chicken with Vegetables")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)30.95, 52, "Pictures/Menu/52.jpg", "Peking Duck"))

            };
        }

        private void generateSeafood(MainWindow window)
        {
            seafood = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem(false, (decimal)13.95, 53, "Pictures/Menu/53.jpg", "Sweet & Sour Pork")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)13.95, 54, "Pictures/Menu/54.jpg", "Peking Style Pork Chops")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)13.95, 55, "Pictures/Menu/55.jpg", "HK Style Spicy Pork Chops")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)15.95, 56, "Pictures/Menu/56.jpg", "Salt & Pepper Pork Chops")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)15.95, 57, "Pictures/Menu/57.jpg", "Honey Garlic Spareribs")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)15.95, 58, "Pictures/Menu/58.jpg", "Sweet & Sour Spareribs")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)15.95, 59, "Pictures/Menu/59.jpg", "MuShu Pork Pan Cake Wraps")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)15.95, 60, "Pictures/Menu/60.jpg", "House Spicy Shredded Pork")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)13.95, 61, "Pictures/Menu/61.jpg", "Ginger Squid")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)13.95, 62, "Pictures/Menu/62.jpg", "Curried Squid")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)13.95, 63, "Pictures/Menu/63.jpg", "Squid with Black Bean Sauce")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)15.95, 64, "Pictures/Menu/64.jpg", "Prawns with Black Bean Sauce")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)15.95, 65, "Pictures/Menu/65.jpg", "Deep Fried Crispy Prawns")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)15.95, 66, "Pictures/Menu/66.jpg", "Prawns with Cashew Nuts")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)15.95, 67, "Pictures/Menu/67.jpg", "Prawns with Snow Peas")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)15.95, 68, "Pictures/Menu/68.jpg", "Pan Fried Tomatoes Prawns")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)15.95, 69, "Pictures/Menu/69.jpg", "Pan Fried Prawns with Vegetables")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)15.95, 70, "Pictures/Menu/70.jpg", "Palace Style Prawns")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)15.95, 71, "Pictures/Menu/71.jpg", "Sweet & Sour Prawns")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)14.95, 72, "Pictures/Menu/72.jpg", "Salt & Pepper Squid")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)17.50, 73, "Pictures/Menu/73.jpg", "Salt & Pepper Seafood")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)15.95, 74, "Pictures/Menu/74.jpg", "Salt & Pepper Prawns")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)14.95, 75, "Pictures/Menu/75.jpg", "Salt & Pepper Fish Filets"))

            };
        }

        private void generateVegetable(MainWindow window)
        {
            vegetable = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem(false, (decimal)10.95, 76, "Pictures/Menu/76.jpg", "Vegetables in Oyster Sauce")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)10.95, 77, "Pictures/Menu/77.jpg", "Stir Fried Mixed Vegetables")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)10.95, 78, "Pictures/Menu/78.jpg", "Vegetables in Black Bean Sauce")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)11.95, 79, "Pictures/Menu/79.jpg", "Chinese Broccoli in Garlic Sauce")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)10.95, 80, "Pictures/Menu/80.jpg", "Eight Precious Spicy Jewels")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)12.95, 81, "Pictures/Menu/81.jpg", "Dry Spicy Green Beans")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)11.95, 82, "Pictures/Menu/82.jpg", "Ma Po Tofu (with Pork)")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)11.95, 83, "Pictures/Menu/83.jpg", "Braised Tofu with Mixed Vegetables")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)10.95, 83, "Pictures/Menu/84.jpg", "Salt & Pepper Tofu"))
            };
        }

        private void generateHotplate(MainWindow window)
        {
            hotplate = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem(true , (decimal)13.95, 85, "Pictures/Menu/85.jpg", "Beef in Black Pepper Sauce")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)13.95, 86, "Pictures/Menu/86.jpg", "Chicken in Black Pepper Sauce")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)13.95, 87, "Pictures/Menu/87.jpg", "Beef with Black Bean Sauce")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)17.50, 88, "Pictures/Menu/88.jpg", "Prawns & Scallop in Black Bean Sauce")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)17.50, 89, "Pictures/Menu/89.jpg", "Seafood in Black Bean Sauce")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)15.95, 90, "Pictures/Menu/90.jpg", "Prawns in Szechuan Sauce")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)13.95, 91, "Pictures/Menu/91.jpg", "Sliced Chicken in Szechuan Sauce")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)13.95, 92, "Pictures/Menu/92.jpg", "Duck & Eggplant in Szechuan Sauce")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)14.95, 93, "Pictures/Menu/93.jpg", "Shrimp, Meat, Tofu Hotpot")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)14.95, 94, "Pictures/Menu/94.jpg", "Szechuan Seafood Hot Pot")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)14.95, 95, "Pictures/Menu/95.jpg", "Tofu Fish Filet Hot Pot")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)13.95, 96, "Pictures/Menu/96.jpg", "Chicken with Ginger & Onion Hot Pot")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)13.95, 97, "Pictures/Menu/97.jpg", "Beef with Ginger & Onion Hotpot")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)10.95, 98, "Pictures/Menu/98.jpg", "Vegetables & Vermicelli Hot Pot"))
            };
        }

        private void generateRice(MainWindow window)
        {
            rice = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem(false, (decimal)10.25, 99 , "Pictures/Menu/99.jpg" , "Chicken Fried Rice")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)12.95, 100, "Pictures/Menu/100.jpg", "Salty Fish & Chicken Fried Rice")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)10.25, 101, "Pictures/Menu/101.jpg", "Pineapple Fried Rice")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)10.25, 102, "Pictures/Menu/102.jpg", "Beef Fried Rice")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)10.25, 103, "Pictures/Menu/103.jpg", "BBQ Pork Fried Rice")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)10.25, 104, "Pictures/Menu/104.jpg", "Shrimp Fried Rice")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)10.25, 105, "Pictures/Menu/105.jpg", "House Special Fried Rice")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)10.25, 106, "Pictures/Menu/106.jpg", "Mushroom Fried Rice")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)10.25, 107, "Pictures/Menu/107.jpg", "Mixed Vegetable Fried Rice")),
                new  ucMenuItem (window, new MenuItem(false, (decimal) 8.95, 108, "Pictures/Menu/108.jpg", "Plain Fried Rice")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)13.95, 109, "Pictures/Menu/109.jpg", "Seafood Fried Rice")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)14.95, 110, "Pictures/Menu/110.jpg", "Fook Kin Style Fried Rice")),
                new  ucMenuItem (window, new MenuItem(false, (decimal) 1.95, 111, "Pictures/Menu/111.jpg", "Steamed Rice")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)11.95, 112, "Pictures/Menu/112.jpg", "Mixed Vegetable Chow Mein")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)11.95, 113, "Pictures/Menu/113.jpg", "Chicken Chow Mein")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)14.95, 114, "Pictures/Menu/114.jpg", "Seafood Chow Mein")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)12.95, 115, "Pictures/Menu/115.jpg", "Cantonese Chow Mein")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)14.95, 116, "Pictures/Menu/116.jpg", "House Special Chow Mein")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)11.95, 117, "Pictures/Menu/117.jpg", "Szechuan Style Thick Noodles")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)11.95, 118, "Pictures/Menu/118.jpg", "Satay Beef Thick Noodles")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)11.95, 119, "Pictures/Menu/119.jpg", "Shanghai Style Thick Noodles")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)11.95, 120, "Pictures/Menu/120.jpg", "Singapore Style Vermicelli")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)11.95, 121, "Pictures/Menu/121.jpg", "House Style Vermicelli")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)11.95, 122, "Pictures/Menu/122.jpg", "Braised Duck Vermicelli")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)11.95, 123, "Pictures/Menu/123.jpg", "Beef Ho Fun")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)11.95, 124, "Pictures/Menu/124.jpg", "Satay Beef Ho Fun")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)11.95, 125, "Pictures/Menu/125.jpg", "Beef Ho Fun in Black Bean Sauce")),
                new  ucMenuItem (window, new MenuItem(true , (decimal)11.95, 126, "Pictures/Menu/126.jpg", "Shrimp & BBQ Pork Curry Ho Fun"))
           };
        }

        private void generateEgg(MainWindow window)
        {
            egg = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem(false, (decimal)10.95, 127, "Pictures/Menu/127.jpg", "Mushroom Egg Foo Yung")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)10.95, 128, "Pictures/Menu/128.jpg", "Chicken Egg Foo Yung")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)10.95, 129, "Pictures/Menu/129.jpg", "BBQ Pork Egg Foo Yung")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)11.95, 130, "Pictures/Menu/130.jpg", "Shrimp Egg Foo Yung")),
                new  ucMenuItem (window, new MenuItem(false, (decimal) 9.95, 131, "Pictures/Menu/131.jpg", "Plain Egg Foo Yung")),
                new  ucMenuItem (window, new MenuItem(false, (decimal) 9.95, 132, "Pictures/Menu/132.jpg", "Mushroom Chop Suey")),
                new  ucMenuItem (window, new MenuItem(false, (decimal) 9.95, 133, "Pictures/Menu/133.jpg", "Chicken Chop Suey")),
                new  ucMenuItem (window, new MenuItem(false, (decimal) 9.95, 134, "Pictures/Menu/134.jpg", "Beef Chop Suey")),
                new  ucMenuItem (window, new MenuItem(false, (decimal) 9.95, 135, "Pictures/Menu/135.jpg", "BBQ Pork Chop Suey")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)10.95, 136, "Pictures/Menu/136.jpg", "Shrimp Chop Suey"))
            };
        }

        private void generateDrinks(MainWindow window)
        {
            drinks = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem(false, (decimal)2.00 , 139, "Pictures/Menu/d1.jpg", "Pop (Can)")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)7.50 , 140, "Pictures/Menu/d2.jpg", "Beer (Domestic)")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)9.25 , 141, "Pictures/Menu/d3.jpg", "Beer (Imported)")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)8.95 , 142, "Pictures/Menu/d4.jpg", "Wine (8oz Glass)")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)23.95, 143, "Pictures/Menu/d5.jpg", "Wine House White Bottle")),
                new  ucMenuItem (window, new MenuItem(false, (decimal)23.95, 144, "Pictures/Menu/d6.jpg", "Wine House Red Bottle"))

            };

        }
        public List<ucMenuItem> getCategory(int category)
        {
            switch (category)
            {
                case 0:
                    return appetizers;
                case 1:
                    return soup;
                case 2:
                    return beef;
                case 3:
                    return chicken;
                case 4:
                    return seafood;
                case 5:
                    return vegetable;
                case 6:
                    return hotplate;
                case 7:
                    return rice;
                case 8:
                    return egg;
                case 9:
                    return drinks;
                default:
                    return appetizers;
            }
        }
    }
}
