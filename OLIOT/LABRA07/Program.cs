using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace LABRA07
{
    class Program
    {
        static void Main(string[] args)
        {
            TEHT1();
            TEHT2();
            TEHT3();
            TEHT4();
        }

        static void TEHT1()
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

        static void TEHT2()
        {
            
            Dictionary<string,int> nimilista = new Dictionary<string,int>();
            try
            {
                Console.WriteLine(File.Exists(@"d:\k8455\nimi.txt") ? "File exists.\n" : "File does not exist.\n");
                string[] text = File.ReadAllLines(@"d:\k8455\nimi.txt");


                foreach (string line in text)
                {
                    if (nimilista.ContainsKey(line))
                    {
                        nimilista[line]++;
                    }
                    else { nimilista.Add(line, 1); }
                }

            }

            catch (Exception h)
            {
                Console.WriteLine(h.Message);
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
            Console.WriteLine("Tehtävä 3 - Anna numero: ");
            StreamWriter reaali = new StreamWriter(@"d:\k8455\reaali.txt", true);
            StreamWriter kokonais = new StreamWriter(@"d:\k8455\kokonais.txt", true);
            bool test = true;
            reaali.Close();
            kokonais.Close();
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
                       
                        
                        using (kokonais = File.AppendText(@"d:\k8455\kokonais.txt"))
                        {
                            Console.WriteLine("Give a Number:");
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
                            Console.WriteLine("Give a Number :");
                            reaali.WriteLine(douu);
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


            // print contents

            Console.WriteLine("Contents of Integers: ");
            string[] text = File.ReadAllLines(@"d:\k8455\kokonais.txt");
            foreach (string s in text)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Contents of Doubles: ");

            string[] textDouble = File.ReadAllLines(@"d:\k8455\reaali.txt");
            foreach (string s in textDouble)
            {
                Console.WriteLine(s);
            }


        }

        static void TEHT4()
        {
            TvOhjelma test = new TvOhjelma("Ohjelma1", "Kanava", "14:50", "15:00", "Mahtava ohjelma");
            TvOhjelma test2 = new TvOhjelma("hyvä ohjelma", "Kanava", "15:50", "16:00", "Mahtava ohjelma");
            List<TvOhjelma> ohjelmat = new List<TvOhjelma>();
            IFormatter formatter = new BinaryFormatter();

            try
            {
                Stream writeStream = new FileStream(@"d:\k8455\Teht4.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(writeStream, test);
                writeStream.Close();
            }
            catch (Exception s)
            {
                Console.WriteLine(s.Message);
            }

            ohjelmat.Add(test);
            ohjelmat.Add(test2);
            try
            {
                Stream writeMultiple = new FileStream(@"d:\k8455\myShows.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(writeMultiple, ohjelmat);
                writeMultiple.Close();
                Stream openStrea = new FileStream(@"d:\k8455\myShows.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                List<TvOhjelma> readShows = (List<TvOhjelma>)formatter.Deserialize(openStrea);
                openStrea.Close();
                foreach (TvOhjelma item in readShows)
                {
                    Console.WriteLine("Tv ohjelma - nimi: {0} Kanava: {1} Aloitusaika: {2} Lopetusaika: {3} Ohjelmakuvaus: {4}", item.Name, item.Channel, item.StartTime, item.EndTime, item.InfoText);
                }
            }
            catch (Exception d)
            {
                Console.WriteLine(d.Message);
            }
           
            

            


        }
    }
}
