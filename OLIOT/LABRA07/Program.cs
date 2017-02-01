using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LABRA07
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            TEHT1();
            TEHT2();
            TEHT3();
            TEHT4();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void TEHT1()
        {

            StreamWriter outputFile = new StreamWriter(@"d:\k8455\test.txt", true);
            string userInput = " ";
            Console.WriteLine("type '----' to quit");
            outputFile.Close();
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
                catch (Exception x)
                {
                    Console.WriteLine(x.Message);
                }
                finally
                {
                   outputFile.Close();
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
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            finally
            {
                if(outputFile!= null)
                {
                    outputFile.Close();
                }
            }

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
                //AAKKOSTUS
                var list = nimilista.Keys.ToList();
                list.Sort();
                //AAKKOSTUS
           
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        static void TEHT3()
        {
            /*
            Tee ohjelma, joka kysyy käyttäjältä lukuja(joko kokonaisluku tai reaaliluku) ja tallenna kokonaisluvut eri tiedostoon kuin reaaliluvut.
            Sovellus tulee lopettaa, jos käyttäjä ei syötä kokonais - tai reaalilukua.Tarkista tiedostojen sisältö jollain tekstieditorilla.
            Esimerkkitulostus:
            */
            try
            {
            Console.WriteLine("Tehtävä 3 - Anna numero: ");
            StreamWriter reaali = new StreamWriter(@"d:\k8455\reaali.txt", true);
            StreamWriter kokonais = new StreamWriter(@"d:\k8455\kokonais.txt", true);
            reaali.Close();
            kokonais.Close();
            bool test = true;

            

            while (test)
            {
                string line = Console.ReadLine();
                int number;
                double dNumber;
                
                bool res2 = double.TryParse(line, out dNumber);
                bool result = int.TryParse(line, out number);


                if (result)
                {
                    using (kokonais = File.AppendText(@"d:\k8455\kokonais.txt"))
                    {
                        Console.WriteLine("Give a Number:");
                        kokonais.WriteLine(number);
                    }
                }

                else if (res2)
                {
                    using (reaali = File.AppendText(@"d:\k8455\reaali.txt"))
                    {
                        Console.WriteLine("Give a Number :");
                        reaali.WriteLine(dNumber);
                    }
                }
                else { Console.WriteLine("Not a number"); test = false; }
                
            }

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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void TEHT4()
        {
            try
            {
                TvOhjelma test = new TvOhjelma("Ohjelma1", "Kanava", "14:50", "15:00", "Mahtava ohjelma");
                TvOhjelma test2 = new TvOhjelma("hyvä ohjelma", "Kanava", "15:50", "16:00", "Mahtava ohjelma");
                TvOhjelma test3 = new TvOhjelma("laalaa ohjelma", "1", "22:50", "00:50", "Yöllinen ohjelma");

                List<TvOhjelma> ohjelmat = new List<TvOhjelma>();
                IFormatter formatter = new BinaryFormatter();

                //yksittäisen tallennus tiedostoon
                Stream writeStream = new FileStream(@"d:\k8455\Teht4.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(writeStream, test);
                writeStream.Close();
                
                ohjelmat.Add(test);
                ohjelmat.Add(test2);
                ohjelmat.Add(test3);


                //olio listan tallennus ja luku tiedostoon
                Stream writeMultiple = new FileStream(@"d:\k8455\myShows.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(writeMultiple, ohjelmat);
                writeMultiple.Close();
                Stream openStream = new FileStream(@"d:\k8455\myShows.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                List<TvOhjelma> readShows = (List<TvOhjelma>)formatter.Deserialize(openStream);
                openStream.Close();

                //listan luku tiedostosta
                foreach (TvOhjelma item in readShows)
                {
                    Console.WriteLine("Tv ohjelma - nimi: {0} Kanava: {1} Aloitusaika: {2} Lopetusaika: {3} Ohjelmakuvaus: {4}", item.Name, item.Channel, item.StartTime, item.EndTime, item.InfoText);
                }
            }
            catch (Exception s)
            {
                Console.WriteLine(s.Message);
            }
            }


        
    }
}
