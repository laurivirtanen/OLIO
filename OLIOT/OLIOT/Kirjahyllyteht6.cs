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
            List<Kirja> Kirjahylly = new List<Kirja>();
            List<Cd> Kirjahylly2 = new List<Cd>();

            Kirjahylly2.Add(new Cd { Author = "Elvis",Name = "Musiikkia", Placement = "Top left", Type = "CD", Year = 1957 });
            Kirjahylly.Add(new Kirja { Author = "unknown", Name = "daa", PageNumber = 3, Placement = "left", Year = 5 });
            Kirjahylly.Add(new Kirja { Author = "Tolkien", Name = "Lord of the rings", PageNumber = 1112, Placement = "Middle", Year = 1952 });

            foreach(var Kirja in Kirjahylly)
            {
                Console.WriteLine(Kirja.OutPut());
            }
            foreach (var Cd in Kirjahylly2)
            {
                Console.WriteLine(Cd.OutPut());
            }


        }
    }
}
