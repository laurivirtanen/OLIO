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

            Drink Milk = new Drink("Milk");
            List<Food> Drinksies = new List<Food>();
            //List<Drink> Drinks = new List<Drink>();
            Fridge Fridgi = new Fridge();
            Shelf Shelfie = new Shelf("thing", Drinksies);
            
            Shelfie.AddFood(Milk);
            Fridgi.AddShelf(Shelfie);



            foreach (var Food in Fridgi.Shelves)
            {
                Console.WriteLine(Food.ToString());
                Console.WriteLine("daa");
            }


        }
    }
}
