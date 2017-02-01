using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABRA08_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Dicey();
                //Shopping();
                //Fishing();
                TEHT5();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Dicey()
        {
            try
            {
                Random rand = new Random();
                Dictionary<int, int> dices = new Dictionary<int, int>();
                int throws = 1000;
                int oneThrow = 0;
                float daaSum = 0f;


                Console.WriteLine("How many dice throws you wanna throw? ");

                string input = Console.ReadLine();
                int.TryParse(input, out throws);

                for (int i = 0; i < throws; i++)
                {
                    oneThrow = Dice.ThrowDice(rand);
                    if (dices.ContainsKey(oneThrow))
                    {
                        dices[oneThrow]++;
                    }
                    else { dices.Add(oneThrow, 1); }
                    daaSum += oneThrow;
                }

                float ka = daaSum / throws;
                Console.WriteLine(ka);

                // järjestys 1-6
                var list = dices.Keys.ToList();
                list.Sort();
                foreach (var key in list)
                {
                    Console.WriteLine("Luku {0} esiintyy {1} kertaa", key, dices[key]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Shopping()
        {
            try { 
            Product daa = new Product("Milk", 2.4f);
            List<Product> products = new List<Product>();
            products.Add(new Product("Beer", 1.5f));
            products.Add(new Product("Beer", 1.5f));
            products.Add(new Product("Cheese", 3.5f));
            products.Add(new Product("Coffee", 3.5f));
            products.Add(daa);
            ShoppingCart cart = new ShoppingCart(products);

            Console.WriteLine(cart.AllData(cart.products));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Fishing()
        {
            Location jkl = new Location("Jyväskylä", "Jyväs-järven pohjoiskolkka");
            Location place2 = new Location("Uurainen", "Puro");

            Fish fish1 = new Fish("Hauki", 100, 5.6f);
            List<Fish> fishes = new List<Fish>();
            List<Fish> pikes = new List<Fish>();

            Fisherman dude = new Fisherman("Lasse", 404040, jkl,fishes);
            Fish fish2 = new Fish("Hauki", 121, 6.5f);
            Fish fish3 = new Fish("Lohi", 81, 3.5f);
            Fish fish4 = new Fish("Ahven", 33, 0.5f);
            Fish fish0 = new Fish("aaaaaaaaaaaaaaaaaa", 33, 0.5f);
            fishes.Add(fish1);
            fishes.Add(fish2);
            
            pikes.Add(fish1);
            pikes.Add(fish2);
            Fisherman toka = new Fisherman("Kalastaja", 221541, place2, pikes);

            List<Fisherman> lista = new List<Fisherman>();
            lista.Add(toka);
            Console.WriteLine(toka.AddFish(fish0));

            Console.WriteLine(toka.ToString());
            Console.WriteLine(dude.ToString());

            FisherReg reg = new FisherReg(lista);
            Console.WriteLine(reg.ToString());
        }

        static void TEHT4()
        {
            try
            {
                Rectangle laatikko = new Rectangle(10, 20);
                Rectangle laatikko2 = new Rectangle(20, 30);
                Rectangle laatikko3 = new Rectangle(40, 50);
                Circle kirkle = new Circle(1);
                Circle kirkle2 = new Circle(2);
                Circle kirkle3 = new Circle(3);

                List<Shape> shapes = new List<Shape>();

                shapes.Add(kirkle);
                shapes.Add(kirkle2);
                shapes.Add(kirkle3);
                shapes.Add(laatikko);
                shapes.Add(laatikko2);
                shapes.Add(laatikko3);

                Shapes shaput = new Shapes(shapes);
                Console.WriteLine(shaput.ToString());
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }

        }

        static void TEHT5()
        {
            try { 
                double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };

                ArrayCalcs laskin = new ArrayCalcs(array);

                Console.WriteLine(laskin.ToString());

                double[] array2 = { };

                ArrayCalcs calc = new ArrayCalcs(array2);
                Console.WriteLine(calc.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }

        static void TEHT6()
        {
            Console.WriteLine("Please Start");
        }
    }
}
