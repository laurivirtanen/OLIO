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

        public string AddFish(Fish f)
        {
            string s = "Added fish: " + f.ToString();
            Fishes.Add(f);
            return s;
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

    abstract public class Shape
    {
        public string Name { get; set; }
        public List<Shape> Shapes { get; }
        abstract public double Area();
        abstract public double Circumference();
    }

    class Shapes
    {
        public List<Shape> shappes { get; }

        public Shapes(List<Shape> s)
        {
            shappes = s;
        }

        public override string ToString()
        {
            string s = "";
            foreach (Shape sd in shappes)
            {
                s += sd.ToString() + "\n";
            }
            return s;
        }
    }

    class Circle : Shape
    {
        double radius;
        double area;
        double circumference;

        public Circle(double r)
        {
            radius = r;
            Area();
            Circumference();
        }
        public override double Area()
        {
            area = Math.PI * (radius * radius);
            return area;
        }
        public override double Circumference()
        {
            circumference = 2 * Math.PI * radius;
            return circumference;
        }

        public override string ToString()
        {
            return "Circle Radius=" +radius+ " Area=" + area.ToString("F2") + " Circumference=" + circumference.ToString("F2");
        }
    }

    class Rectangle : Shape
    {
        double width;
        double height;
        double area;
        double circumference;

        public Rectangle(double w,double h)
        {
            width = w;
            height = h;
            Area();
            Circumference();
        }

        public override double Area()
        {
            area = width * height;
            return area;
        }
        public override double Circumference()
        {
            circumference = (width + height) * 2.00d;
            return circumference;
        }

        public override string ToString()
        {
            return "Rectangle Width=" + width + " Height=" + height + " Area=" + area.ToString("F2") + " Circumference=" + circumference.ToString("F2");
        }
    }

    public class ArrayCalcs
    {

        double sum;
        double avg;
        double min;
        double max;

        public ArrayCalcs(double[] sup)
        {
           sum = Sum(sup);
           avg = Avg(sup);
           min = Min(sup);
           max = Max(sup);

        }

        public static double Sum(double[] daa)
        {

            double a = 0;
            foreach (double d in daa)
            {
                a += d;
            }
            return a;
        }
        public static double Avg(double[] daa)
        {
            double a = 0;
            int b = 0;

            foreach (double d in daa)
            {
                a += d;
                b++;
            }
            
            return (a/b);
        }
        public static double Min(double[] daa)
        {
            Array.Sort(daa);
            return daa[0];
        }
        public static double Max(double[] daa)
        {
            Array.Sort(daa);
            Array.Reverse(daa);
            return daa[0];
        }

        public override string ToString()
        {
            return "Sum = " + sum.ToString("F2") + "\nAve = " + avg.ToString("F2") + "\nMin = " + min.ToString("F2") + "\nMax = " + max.ToString("F2");
        }
    }

    class InvoiceItem
    {

    }
}
