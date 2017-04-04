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
        private List<ucMenuItem> noodle;
        private List<ucMenuItem> egg;
        private List<ucMenuItem> chopsuey;
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
            generateNoodle(window);
            generateEgg(window);
            generateChopsuey(window);
            generateDrinks(window);
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
               new  ucMenuItem (window, new MenuItem((decimal)4.50 , 9, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg", "Wonton Soup","Soup")),
               new  ucMenuItem (window, new MenuItem((decimal)8.95 , 10, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg", "Wor Wonton Soup","Soup")),
               new  ucMenuItem (window, new MenuItem((decimal)8.95 , 11, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg", "Hot & Sour Soup","Soup")),
               new  ucMenuItem (window, new MenuItem((decimal)12.95, 12, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg", "Crab Meat & Fish Maw Soup","Soup")),
               new  ucMenuItem (window, new MenuItem((decimal)10.95, 13, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg", "Chicken & Cream Corn Soup","Soup")),
               new  ucMenuItem (window, new MenuItem((decimal)10.95, 14, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg", "Beef & Egg Drop in Thick Soup","Soup")),
               new  ucMenuItem (window, new MenuItem((decimal)13.95 , 15, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg","Hot & Sour Soup on Sizzling Rice", "Rice")),
               new  ucMenuItem (window, new MenuItem((decimal)13.95 , 16, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg","Shrimp & tomato on Sizzling Rice", "Rice")),
               new  ucMenuItem (window, new MenuItem((decimal)15.95 , 17, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg","Seafood & vegetable on Sizzling Rice", "Rice")),
               new  ucMenuItem (window, new MenuItem((decimal)13.95, 18, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg", "Beef & Mixed Vegetable on Sizzling Rice", "Rice")),
               new  ucMenuItem (window, new MenuItem((decimal)13.95, 19, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg", "Chicken & Mixed Vegetable on Sizzling Rice", "Rice")),
               new  ucMenuItem (window, new MenuItem((decimal)11.95, 20, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg", "Mixed Vegetable on Sizzling Rice", "Rice"))
            };
        }

        private void generateBeef(MainWindow window)
        {
            beef = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem((decimal)12.50 , 21, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg","Ginger Beef","Beef")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95 , 22, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg","Curried Beef","Beef")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95 , 23, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg","Beef with 2 Kinds of Mushroom","Beef")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 24, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg", "Beef with Black Bean Sauce","Beef")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 26, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg", "Beef with Tomatoes","Beef")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 25, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg", "Beef with Broccoli","Beef")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 27, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg", "Beef with Snow Peas","Beef")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 28, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg", "Beef with Mixed Vegetables","Beef")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95 , 29, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg","Beef with Chinese Broccoli","Beef")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 30, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg", "Beef with Ginger & Onion","Beef")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 31, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg", "Beef with Satay Sauce","Beef")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 32, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg", "Szechuan Syle Beef","Beef"))

            };
        }

        private void generateChicken(MainWindow window)
        {
            chicken = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem((decimal)12.50, 33, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg","Ginger Chicken","Chicken & Duck")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 34, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg","Sweet & Sour Chicken","Chicken & Duck")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 35, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg","Palace Style Chicken","Chicken & Duck")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 36, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg","Lemon Soo Gai (Chicken Breast)","Chicken & Duck")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 37, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg","Almond Soo Gai (Chicken Breast)","Chicken & Duck")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 38, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg","Diced Chicken & Cashews","Chicken & Duck")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 39, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg","Diced Chicken & Almond","Chicken & Duck")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 40, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg","Diced Chicken in Yellow Bean Sauce","Chicken & Duck")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 41, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg","Sliced Chicken & Veggie in Spicy Sauce","Chicken & Duck")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 42, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg","Sliced Chicken with Mixed Vegetables","Chicken & Duck")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 43, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg","Sliced Chicken with 2 kinds of Mushroom","Chicken & Duck")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 44, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg","SLiced Chicken in Black Bean Sauce","Chicken & Duck")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95,45, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg","Sliced Chicken in Curry Sauce","Chicken & Duck")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 46, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg","Sweet & Sour Chicken Balls","Chicken & Duck")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 47, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg","Sliced Chicken with Mushrooms","Chicken & Duck")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 48, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg","Crispy Chicken (Half)","Chicken & Duck")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 49, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg","Salt & Pepper Chicken","Chicken & Duck")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 50, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg","Hong Kong Style Diced Cripsy Chicken","Chicken & Duck")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 51, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg","Stir Fried Chicken w/Deep Fried Vegetables","Chicken & Duck")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 52, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg","Peking Duck","Chicken & Duck"))

            };
        }

        private void generateSeafood(MainWindow window)
        {
            seafood = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 61, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg","Ginger Squid","Seafood")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 62, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg","Curried Squid","Seafood")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 63, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg","Squid with Black Bean Sauce","Seafood")),
                new  ucMenuItem (window, new MenuItem((decimal)15.95, 64, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg","Prawns with Black Bean Sauce","Seafood")),
                new  ucMenuItem (window, new MenuItem((decimal)15.95, 65, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg","Deep Fried Crispy Prawns","Seafood")),
                new  ucMenuItem (window, new MenuItem((decimal)15.95, 66, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg","Prawns with Cashew Nuts","Seafood")),
                new  ucMenuItem (window, new MenuItem((decimal)15.95, 67, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg","Prawns with Snow Peas","Seafood")),
                new  ucMenuItem (window, new MenuItem((decimal)15.95, 68, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg","Pan Fried Prawns with Fresh Tomatoes","Seafood")),
                new  ucMenuItem (window, new MenuItem((decimal)15.95, 69, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg","Pan Fried Prawns with Mixed Vegetables","Seafood")),
                new  ucMenuItem (window, new MenuItem((decimal)15.95, 70, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg","Palace Style Prawns","Seafood")),
                new  ucMenuItem (window, new MenuItem((decimal)15.95, 71, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg","Sweet & Sour Prawns","Seafood")),
                new  ucMenuItem (window, new MenuItem((decimal)14.95, 72, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg","Salt & Pepper Squid","Seafood")),
                new  ucMenuItem (window, new MenuItem((decimal)17.50, 73, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg","Salt & Pepper Seafood","Seafood")),
                new  ucMenuItem (window, new MenuItem((decimal)15.95, 74, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg","Salt & Pepper Prawns","Seafood")),
                new  ucMenuItem (window, new MenuItem((decimal)14.95, 75, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg","Salt & Pepper Fish Filets","Seafood"))

            };
        }

        private void generateVegetable(MainWindow window)
        {
            vegetable = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 76, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg", "4 Kinds of Vegetables in Oyster Sauce","Vegetables")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 77, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg", "Stir Fried Mixed Vegetables","Vegetables")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 78, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg", "Mixed Vegetables in Black Bean Sauce","Vegetables")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 79, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg", "Stir Fried Chinese Broccoli in Garlic Sauce","Vegetables")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 80, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg", "Eight Precious Spicy Jewels","Vegetables")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 81, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg", "Dry Spicy Green Beans","Vegetables")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 82, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg", "Ma Po Tofu (with Pork)","Vegetables")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 83, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg", "Braised Tofu with Mixed Vegetables","Vegetables")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 83, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg", "Salt & Pepper Tofu","Vegetables"))
            };
        }

        private void generateHotplate(MainWindow window)
        {
            hotplate = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 85, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg","Shredded Beef with black Pepper Sauce","Hot Plate & Hot Pot")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 86, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg","Chicken with Black Pepper Sauce","Hot Plate & Hot Pot")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 87, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg","Shredded Beef with Black Bean Sauce","Hot Plate & Hot Pot")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 88, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg","Prawns & Scallop with Black Bean Sauce","Hot Plate & Hot Pot")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 89, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg","","Hot Plate & Hot Pot")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 90, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg","","Hot Plate & Hot Pot")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 91, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg","","Hot Plate & Hot Pot")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 92, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg","","Hot Plate & Hot Pot")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 93, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg","","Hot Plate & Hot Pot")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 94, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg","","Hot Plate & Hot Pot")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 95, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg","","Hot Plate & Hot Pot")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 96, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg","","Hot Plate & Hot Pot")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 97, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg","","Hot Plate & Hot Pot")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 98, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg","","Hot Plate & Hot Pot"))
            };
        }

        private void generateRice(MainWindow window)
        {
            rice = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem((decimal)10.25, 99, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg", "Chicken Fried Rice","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 100, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg","Salty Fish & Chicken Fried Rice","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)10.25, 101, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg","Pineapple Fried Rice","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)10.25, 102, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg","Beef Fried Rice","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)10.25, 103, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg","BBQ Pork Fried Rice","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)10.25, 104, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg","Shrimp Fried Rice","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)10.25, 105, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg","House Special Fried Rice","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)10.25, 106, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg","Fried Rice","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)10.25, 107, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg","Fried Rice","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal) 8.95, 108, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg","Fried Rice","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)13.95, 109, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg","Fried Rice","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)14.95, 110, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg","Fried Rice","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal) 1.95, 111, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg","Fried Rice","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 112, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg","","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 113, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg","","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)14.95, 114, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg","","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 115, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg","","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)14.95, 116, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg","","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 117, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg","","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 118, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg","","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 119, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg","","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 120, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg","","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal) 1.95, 121, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg","","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 122, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg","","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 123, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg","","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)14.95, 124, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg","","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)12.95, 125, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg","","Rice & Noodles")),
                new  ucMenuItem (window, new MenuItem((decimal)14.95, 126, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg","","Rice & Noodles"))
           };
        }

        private void generateNoodle(MainWindow window)
        {
            noodle = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 127, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg","Fresh Mushroom Egg Foo Yung","Chop Suey")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 128, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg","Chicken Egg Foo Yung","Chop Suey")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 129, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg","BBW Pork Egg Foo Yung","Chop Suey")),
                new  ucMenuItem (window, new MenuItem((decimal)11.95, 130, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg","Shrimp Egg Foo Yung","Chop Suey")),
                new  ucMenuItem (window, new MenuItem((decimal) 9.95, 131, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg","Plain Egg Foo Yung","Chop Suey")),
                new  ucMenuItem (window, new MenuItem((decimal) 9.95, 132, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg","Egg Foo Yung","Chop Suey")),
                new  ucMenuItem (window, new MenuItem((decimal) 9.95, 133, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg","Egg Foo Yung","Chop Suey")),
                new  ucMenuItem (window, new MenuItem((decimal) 9.95, 134, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg","Chop Suey","Chop Suey")),
                new  ucMenuItem (window, new MenuItem((decimal) 9.95, 135, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg","Chop Suey","Chop Suey")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 136, "Pictures/Menu/6.jpg", "Pictures/Menu/6s.jpg","Chop Suey","Chop Suey")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 137, "Pictures/Menu/7.jpg", "Pictures/Menu/7s.jpg","Chop Suey","Chop Suey")),
                new  ucMenuItem (window, new MenuItem((decimal)10.95, 138, "Pictures/Menu/8.jpg", "Pictures/Menu/8s.jpg","Chop Suey","Chop Suey"))
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

        private void generateDrinks(MainWindow window)
        {
            drinks = new List<ucMenuItem>()
            {
                new  ucMenuItem (window, new MenuItem((decimal)2.00 , 139, "Pictures/Menu/1.jpg", "Pictures/Menu/1s.jpg","Pop (Can)","Drinks")),
                new  ucMenuItem (window, new MenuItem((decimal)7.50 , 140, "Pictures/Menu/2.jpg", "Pictures/Menu/2s.jpg","Beer (Domestic)","Drinks")),
                new  ucMenuItem (window, new MenuItem((decimal)9.25 , 141, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg","Beer (Imported)","Drinks")),
                new  ucMenuItem (window, new MenuItem((decimal)8.95 , 142, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg","Wine (8oz Glass)","Drinks")),
                new  ucMenuItem (window, new MenuItem((decimal)13.25, 143, "Pictures/Menu/3.jpg", "Pictures/Menu/3s.jpg","Wine House Red/White 1/2 Bottle","Drinks")),
                new  ucMenuItem (window, new MenuItem((decimal)23.95, 144, "Pictures/Menu/4.jpg", "Pictures/Menu/4s.jpg","Wine House White Bottle","Drinks")),
                new  ucMenuItem (window, new MenuItem((decimal)23.95, 145, "Pictures/Menu/5.jpg", "Pictures/Menu/5s.jpg","Wine House Red Bottle","Drinks"))

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
                case 12:
                    return drinks;
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
        public List<ucMenuItem> getDrinks() { return drinks; }
    }
}
