using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Bottom
    {
        private string place = "Unknown";
        public string Name { get; set; }
        public int Year { get; set; }
        public string Placement
        {
            get { return place; }
            set { place = value; }
        }

        public Bottom()
        {

        }
        public Bottom(string name, string plc, int y)
        {
            place = plc;
            Name = name;
            Year = y;
        }

    }

    public class Kirja : Bottom
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
        
        public string OutPut()
        {
            return "Author: " + Author + " Name: " + Name +  " Year Published: " + Year + " Pages: " + PageNumber + " Place in the shelf: " + Placement;
        }

    }


    public class Cd : Bottom
    {
        public string Type { get; set; } // movie,cd, dvd etc.
        public string Author { get; set; }

        public Cd() { }

        public string OutPut()
        {
            return "Author: " + Author + " Name: " + Name + " Year Published: " + Year + " Type: " + Type + " Place in the shelf: " + Placement;
        }
    }

}
