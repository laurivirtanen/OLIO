using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace OLIOT
{
    class teht4
    {
        public static void teht4s()
        {

            Player Lasse = new Player(15, "Lasse");
            
            Bag Testy = new Bag();
            Testy.Name = "Mahtava Bägi";
            Lasse.AddBag(Testy);
            Disc Leopard = new Disc("Innova","Leopard", 6, 4, -2, 1);
            Disc Grovee = new Disc("Innova", "Groove", 13, 6, 2, 2);


            Testy.AddDisc(Leopard); Testy.AddDisc(Grovee);
            
            Console.WriteLine(Lasse.ToString());



        }


    }
}
