using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;



namespace OLIOT
{
    public class Kirjahyllyteht6
    {
        public static void Kirjahylly()
        {
            List<Item> testing = new List<Item>();

            testing.Add(new Cd { Author = "Elvis", Name = "Levy 2", Placement = "Top left", Type = "CD", Year = 1957 });
            testing.Add(new Kirja { Author = "unknown", Name = "daa", PageNumber = 3, Placement = "left", Year = 5 });
            testing.Add(new Kirja { Author = "Tolkien", Name = "Lord of the rings", PageNumber = 1112, Placement = "Middle", Year = 1952 });
            testing.Add(new Cd { });

            foreach(var Item in testing)
            {
                Console.WriteLine(Item.OutPut());
            }


        }
    }
}
