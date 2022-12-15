// Composition Pattern

using CompositePattern;
using CompositePattern.Components;

MenuComponent pancakeHouseMenu = new Menu("Pancake House Menu", "Breakfast");
MenuComponent dinerMenu = new Menu("Diner Menu", "Lunch");
MenuComponent dessertMenu = new Menu("Dessert Menu", "dessert");

MenuComponent allMenus = new Menu("All Menus", "Root");
allMenus.Add(pancakeHouseMenu);
allMenus.Add(dinerMenu);
            
pancakeHouseMenu.Add(new MenuItem(
    "Regular Pancake Breakfast", "fired eggs, sausage", false, 2.99));
pancakeHouseMenu.Add(new MenuItem(
    "Blueberry Pancakes", "fresh blueberry", true, 1.99));
pancakeHouseMenu.Add(new MenuItem(
    "K&B Breakfast", "scrambled eggs, toast", true, 3.99));
            
dinerMenu.Add(new MenuItem(
    "Soup of day", "potato salard", true, 3.29));
dinerMenu.Add(new MenuItem(
    "Hot dog", "hot dog with cheese", false, 4.99));
dinerMenu.Add(new MenuItem(
    "Vegetarian BLT", "tomato with wheat", true, 2.49));
            
dessertMenu.Add(new MenuItem(
    "Apple Pie", "ice cream", true, 0.99));
            
dinerMenu.Add(dessertMenu);

Waitress waitress = new Waitress(allMenus);
            
// waitress.PrintMenu();
waitress.PrintVegetarianMenu();