using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{


    public class Fridge
    {
        public List<Shelf> Shelves = new List<Shelf>();

        public Fridge()
        { }

        public void AddShelf(Shelf shelf)
        {
            Shelves.Add(shelf);
        }
        public void ReadShelf(Shelf shelf)
        {
            Console.WriteLine(shelf.ToString());
        }
    }

    public class Shelf
    {
        //public List<Food> foods = new List<Food>();
        public List<Food> Foods { get; }
        public string name;
        public Shelf(string nam, List<Food> foodie)
        {
            Foods = foodie;
            name = nam;
        }

        public void AddFood(Food Ruokaa)
        {
            Foods.Add(Ruokaa);
            Ruokaa.ToString();
        }

        public void RemoveFood(Food Ruokaa)
        {
            Foods.Remove(Ruokaa);
        }

        public override string ToString()
        {
            return "Name: " + name;
        }
    }

    public class Food
    {
        public string Name = "sup";

        public Food() { }

        public Food(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name + " ";
        }
    }

    public class Drink : Food
    {
        public int volem = 4;
        public Drink() { }
        public Drink(string name) : base(name) { }

        public override string ToString()
        {
            return base.ToString() + volem;
        }

    }
    

    public abstract class Nisakas
    {
        public int Ika { get; set; }

        public abstract void Liiku();
        public abstract string ToString();
    }

    public class Human : Nisakas
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }

        public Human() { }
        public Human(int weight, int height, string name, int ika)
        {
            Weight = weight;
            Height = height;
            Name = name;
            Ika = ika;
        }

        public override void Liiku()
        {
            Console.WriteLine("Liikun");
        }

        public void Grow()
        {
            Ika++;
            Console.WriteLine("Ding!");
        }

        public override string ToString()
        {
            return Name + " " + Height + "cm " + Weight + "kg " + Ika + " Years";
        }
    }

    public class Baby : Human
    {
        public string Vaippa { get; set; }

        public Baby(int weight,int height, string name, int ika, string vaippa) : base(weight, height, name, ika)
        {
            Vaippa = vaippa;
        }
        public override void Liiku()
        {
            Console.WriteLine("Konttaan");
        }

        public override string ToString()
        {
            return base.ToString() + " " + Vaippa;
        }
    }

    public class GrownUp : Human
    {

        public string Auto { get; set; }

        public GrownUp(int weight, int height, string name, int ika, string auto) : base(weight, height, name, ika)
        {
            Auto = auto;
        }

        public override void Liiku()
        {
            Console.WriteLine("Kävelen");
        }

        public override string ToString()
        {
            return base.ToString() + " " + Auto;
        }
    }
}


