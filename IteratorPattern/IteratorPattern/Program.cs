// Iterator Pattern

using IteratorPattern.Menus;

namespace IteratorPattern
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            IMenu pancakeHouseMenu = new PancakeHouseMenu();
            IMenu dinerMenu = new DinerMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);
            
            waitress.PrintMenu();
        }
    }
}