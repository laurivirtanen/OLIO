using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABRA08_
{
    class Product
    {
        public string Name { get; set; }
        public float Value { get; set; }

        public Product(string name, float val)
        {
            Name = name;
            Value = val;
        }

        public override string ToString()
        {
            return "- Product: " + Name + "  " + Value + " e" ; 
        }
    }

    class ShoppingCart
    {
        public List<Product> products { get; }
        public ShoppingCart(List<Product> prod)
        {
            products = prod;
        }

        public string AllData(List<Product> prod)
        {
            string cartData = "All products in shopping cart: \n";
            foreach (Product p in prod)
            {
                cartData += p.ToString();
                cartData += "\n";
            }
            return cartData;
        }
    }

    class Fish
    {
        public string Species { get; set; }
        public float Length { get; set; }
        public float Weight { get; set; }
        public Fish(string s, float l, float w)
        {
            Species = s;
            Length = l;
            Weight = w;
        }

        public override string ToString()
        {
            return "-species: " + Species + " " + Length + " cm" + " " + Weight + " kg\n";
        }


    }

    class Fisherman
    {
        public string Name { get; set; }
        public int Phone { get; set; }
        public Location Local { get; }
        public List<Fish> Fishes { get; }
        public Fisherman(string n, int p, Location l, List<Fish> f)
        {
            Name = n;
            Phone = p;
            Local = l;
            Fishes = f;
        }

        public List<Fish> AddFish(Fish f)
        {
            Fishes.Add(f);
            return Fishes;
        }

        //REMOVE FROM FISHLIST
        public List<Fish> RemFish(Fish f)
        {
            if (Fishes.Contains(f))
            {
                Fishes.Remove(f);
                return Fishes;
            }
            return Fishes;
        }

        public override string ToString()
        {
            string s;
            s = "Fisher : " + Name + " has following fishes:\n";
            foreach (Fish f in Fishes)
            {
                s+= "\n"+f.ToString();
                s+=Local.ToString();
                s += "\n\n";
            }
            return s;
        }
    }

    class Location
    {
        public string Name { get; set; }
        public string Place { get; set; }

        public Location (string na, string plc)
        {
            Name = na;
            Place = plc;
        }

        public override string ToString()
        {
            return "-Location: " + Name  + "\n" + "-Place: " + Place;
        }
    }

    class FisherReg
    {
        public List<Fisherman> Fishermen { get; }

        public FisherReg() { }
        public FisherReg(List<Fisherman> fismen)
        {
            Fishermen = fismen;
        }
        public List<Fisherman> AddFisher(Fisherman fi)
        {
            Fishermen.Add(fi);
            return Fishermen;
        }

        public override string ToString()
        {
            string s = "";
            foreach (Fisherman f in Fishermen)
            {
                s += f.ToString();
            }
            return s;
        }

    }

}
