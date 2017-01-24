using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{

    public class Player
    {
        public int Age { get; set; }
        public string Name { get; set; }
        private bool HasBag = false;
        public Bag Baggy { get; set; }

        public Player(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public void AddBag(Bag bag)
        {
            if (HasBag == false) { 
                Baggy = bag;
                HasBag = true;
            }
            else
                Console.WriteLine("Already have a bag");
        }

        

        public override string ToString()
        {
            string s = "Player: " + Name + " Age: " + Age + "\n";
            if(HasBag == true)
            {
                s += Baggy.ToString();
            }

            return s;
        }

    }

    public class Bag
    {
        public string Name { get; set; }
        private int maxCapacity = 6;
        private int curCapacity = 0;

        public List<Disc> Discs { get;}

        public Bag ()
        {
            Discs = new List<Disc>();
        }

        public void AddDisc(Disc disc)
        {
            if(curCapacity < maxCapacity)
            {
                Discs.Add(disc);
                curCapacity++;
                Console.WriteLine("Disc {0} added to the bag {1}", disc.ToString(), Name);
                

            }
            else
            {
                Console.WriteLine("Your bag is full");
            }
        }

        public override string ToString()
        {
            string s = "Bag: " + Name;
            foreach (Disc d in Discs)
            {
                if (d != null) s += "\n" + d.ToString();
            }

            return s;
        }

    }

    public class Disc
    {
        public string Model { get; set; }
        public string Name { get; set; }
        public int[] Stats = new int[4];

        public Disc(string names,string mod, int a, int b ,int c, int d)
        {
            Name = names;
            Model = mod;
            Stats[0] = a;
            Stats[1] = b;
            Stats[2] = c;
            Stats[3] = d;
        }

        public override string ToString()
        {
            return Name + " " + Model + " Speed:" + Stats[0] + " Glide:" + Stats[1] + " Turn:" + Stats[2] + " Fade:" + Stats[3];
        }


    }


    // 2 TEHTÄVÄ!-<<-<-<- 2 TEHTÄVÄ!-<<-<-<- 
    public class Fridge
    {
        public string Name { get; set; }
        public List<Shelf> Shelves = new List<Shelf>();

        public Fridge()
        { }

        public void AddShelf(Shelf shelf)
        {
            Shelves.Add(shelf);
        }


        public override string ToString()
        {
            string daa = "Name: " + Name;
            foreach (Shelf shelf in Shelves)
            {
                if (shelf != null) daa += "\n-" + shelf.ToString();
            }
            return daa;
        }

    }

    public class Shelf
    {
        //public List<Food> foods = new List<Food>();
        public List<Food> Foods { get; }
        public string Name { get; set; }
        public Shelf(string name, List<Food> foodie)
        {
            Foods = foodie;
            Name = name;
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
            string daa = "Name: " + Name;
            foreach(Food f in Foods)
            {
                if (f != null) daa += "\n-" + f.ToString();
            }
            return daa;
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
        public int volem = 250;
        public Drink() { }
        public Drink(string name) : base(name) { }

        public override string ToString()
        {
            return base.ToString() + volem + "ml";
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


