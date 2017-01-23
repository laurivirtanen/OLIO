using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Fridge
    {
        private List<Shelf> Shelves {get;}
        public Fridge() { }
    }

    public class Shelf
    {
        public List<Food> Foods { get; }
        public Shelf() { }
    }

    public abstract class Food
    {
        public string Name { get; set; }
        public string DoSomething()
        {
            string smthing = "This is food";
            Console.WriteLine("Testing");
            return smthing;
        }
    }

    public class Drink : Food
    {
        public int Volume { get; set; }
        public int Energy { get; set; }
        public Drink() { }
    }

    // remove | add food

    
}
