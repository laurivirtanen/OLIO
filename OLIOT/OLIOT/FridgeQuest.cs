using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace OLIOT
{
    public class FridgeQuest
    {
        public static void Fridging()
        {

            Drink Drink1 = new Drink("Milk");
            Food Food1 = new Food("Meat");
            List<Food> Drinks = new List<Food>();
            List<Food> Meats = new List<Food>();
            Drinks.Add(Drink1);
            Meats.Add(Food1);
            Fridge Fridgi = new Fridge();

            Shelf Shelfie = new Shelf("Bottom Shelf",Drinks);
            Shelf topShelf = new Shelf("Top Shelf",Meats);

            Fridgi.AddShelf(Shelfie);
            Fridgi.AddShelf(topShelf);
           
            Console.WriteLine(Fridgi.ToString());
        }
    }
}
