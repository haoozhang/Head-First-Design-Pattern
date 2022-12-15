package Menus;

public class MenuItem
{
    public String Name;

    public String Description;

    public boolean Vegetarian;

    public double Price;

    public MenuItem(String name, String description, boolean vegetarian, double price)
    {
        Name = name;
        Description = description;
        Vegetarian = vegetarian;
        Price = price;
    }

    public String getName() {
        return Name;
    }

    public String getDescription() {
        return Description;
    }

    public boolean isVegetarian() {
        return Vegetarian;
    }

    public double getPrice() {
        return Price;
    }
}
