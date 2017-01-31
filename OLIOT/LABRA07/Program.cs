using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABRA07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Teht1();
            //Teht2();
            TEHT3();
        }

        static void Teht1()
        {
            StreamWriter outputFile = new StreamWriter(@"d:\k8455\test.txt", true);
            string userInput = " ";
            Console.WriteLine("type '----' to quit");

            while (userInput != "----")
            {
                
                try
                {
                    using(outputFile = File.AppendText(@"d:\k8455\test.txt")) {
                        Console.WriteLine("Give a text line (enter ends) :");
                        userInput = Console.ReadLine();
                        outputFile.WriteLine(userInput);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR");
                }
                finally
                {
                    if(outputFile != null)
                    {
                        outputFile.Close();
                    }
                }
            }
            
            
            try
            {
                string[] text = File.ReadAllLines(@"d:\k8455\test.txt");
                foreach (string s in text)
                {
                    Console.WriteLine(s);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
                throw;
            }
            outputFile.Close();

        }

        static void Teht2()
        {
            
            Dictionary<string,int> nimilista = new Dictionary<string,int>();
            int lines = 0;

            try
            {
                Console.WriteLine(File.Exists(@"d:\k8455\nimi.txt") ? "File exists.\n" : "File does not exist.\n");
                string[] text = File.ReadAllLines(@"d:\k8455\nimi.txt");


                foreach (string line in text)
                {
                    lines++;
                    if (nimilista.ContainsKey(line))
                    {
                        nimilista[line]++;
                    }
                    else { nimilista.Add(line, 1); }
                }

            }

            catch (Exception)
            {
                Console.WriteLine("sup");    
            }
            // AAKKOSTUS
            var list = nimilista.Keys.ToList();
            list.Sort();
            // AAKKOSTUS
            try
            { 
                foreach (var key in list)
                {
                    Console.WriteLine("Nimi {0} esiintyy {1} kertaa", key, nimilista[key]);
                }
                Console.WriteLine("\n");

                // normaalijärjestys
                foreach (KeyValuePair<string,int> kvp in nimilista)
                {
                    Console.WriteLine("Nimi {0} esiintyy {1} kertaa", kvp.Key, kvp.Value);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Foreach printtauksssa virhe");
            }
        }

        static void TEHT3()
        {
            /*
            Tee ohjelma, joka kysyy käyttäjältä lukuja(joko kokonaisluku tai reaaliluku) ja tallenna kokonaisluvut eri tiedostoon kuin reaaliluvut.
            Sovellus tulee lopettaa, jos käyttäjä ei syötä kokonais - tai reaalilukua.Tarkista tiedostojen sisältö jollain tekstieditorilla.
            Esimerkkitulostus:
            */
            StreamWriter reaali = new StreamWriter(@"d:\k8455\reaali.txt", true);
            StreamWriter kokonais = new StreamWriter(@"d:\k8455\kokonais.txt", true);
            bool test = true;

            while (test)
            {
                string line = Console.ReadLine();
                int number;
                double douu;
                
                bool res2 = double.TryParse(line, out douu);
                bool result = int.TryParse(line, out number);


                if (result)
                {
                    try
                    {
                        Console.WriteLine(File.Exists(@"d:\k8455\kokonais.txt") ? "File exists.\n" : "File does not exist.\n");
                        File.Open(@"d:\k8455\kokonais.txt", FileMode.Open, FileAccess.Read, FileShare.None);
                        
                        using (kokonais = File.AppendText(@"d:\k8455\kokonais.txt"))
                        {
                            Console.WriteLine("Give a text line (enter ends) :");
                            kokonais.WriteLine(number);
                        }

                    }
                    catch (Exception h)
                    {
                        Console.WriteLine(h.Message);
                    }
                }

                else if (res2)
                {
                    try
                    {
                        using (reaali = File.AppendText(@"d:\k8455\reaali.txt"))
                        {
                            Console.WriteLine("Give a text line (enter ends) :");
                            kokonais.WriteLine(douu);
                        }

                    }
                    catch (Exception s)
                    {
                        Console.WriteLine(s.Message);
                    }
                }
                else { Console.WriteLine("daa"); test = false; }
                
            }
            reaali.Close();
            kokonais.Close();
            


        }

    }
}
