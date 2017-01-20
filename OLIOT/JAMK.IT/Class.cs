using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Item
    {
        private string place = "Unknown";
        private string name = "Unknown";

        public string Name { get { return name; } set { name = value; } }

        public int Year { get; set; }
        public string Placement
        {
            get { return place; }
            set { place = value; }
        }

        public Item()
        {

        }
        public Item(string name, string plc, int y)
        {
            place = plc;
            Name = name;
            Year = y;
        }
        public virtual string OutPut()
        {
            return "Name: " + Name + " Year made: " + Year + " Place: " + Placement;
        }


    }

    public class Kirja : Item
    {
        public int PageNumber { get; set; }
        public string Author { get; set; }

        public Kirja()
        {

        }

        public Kirja(string auth, string name, int pnumb, string plc, int y ) : base(name, plc, y)
        {
            Author = auth;
            PageNumber = pnumb;
        }
        
        public override string OutPut()
        {
            return "Author: " + Author + " | Name: " + Name + " | Year Published: " + Year + " | Pages: " + PageNumber + " | Place in the shelf: " + Placement;
        }

    }


    public class Cd : Item
    {
        public string Type { get; set; } // movie,cd, dvd etc.
        public string Author { get; set; }

        public Cd() { }

        public override string OutPut()
        {
            return "Author: " + Author + " | Name: " + Name + " | Year Published: " + Year + " | Type: " + Type + " | Place in the shelf: " + Placement;
        }
    }

    public class Stuff
    {
        public string Model { get; set; }
        public string Name { get; set; }
        public Stuff() { }
        public Stuff(string mod, string name)
        {
            Model = mod;
            Name = name;
        }
        public virtual string PrintData()
        {
            return "Model: "+Model+" Name: " +Name;
        }
    }


    public class Vehicle : Stuff
    {
        public List<Tyre> Tyres { get; set; }
        public Vehicle() { }
        public Vehicle(string mod, string name, List<Tyre> tyres) : base(mod,name)
        {
            Tyres = tyres;
        }
        
        public override string PrintData()
        {
            return base.PrintData() + "Tyres: " + Tyres;
        }


    }

    public class Tyre: Stuff
    {
        public string TyreSize { get; set; }

        public Tyre() { }
        public Tyre(string mod, string name, string tyres) : base(mod,name) { tyres = TyreSize; }
    }

}
