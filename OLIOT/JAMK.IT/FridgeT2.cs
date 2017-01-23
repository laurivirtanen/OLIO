using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Test {
    class Fridge
    {
        private List<Shelf> Shelves {get;set;}
    }

    class Shelf
    {
        public List<Food> Foods { get; set; }
    }

    abstract class Food
    {
        public string Name { get; set; }
        public string DoSomething()
        {
            string smthing = "This is food";
            Console.WriteLine("Testing");
            return smthing;

        }
    }
    class Drink : Food
    {
        public int Volume { get; set; }
        public int Energy { get; set; }
        
        public Drink() { }
    }
    }
}
