using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kokoelmaluokat
{
    class Kokoelmat
    {

        public static void TestaaHenkiloRekisteri()
        {
            Henkilot Listaus = new Henkilot();
            Henkilo Lasse = new Henkilo("Lasse", "Mortensen", "222");
            Henkilo hlo = new Henkilo("Daa", "daa", "222-d3y4e");
            Henkilo hlo1 = new Henkilo("hfhx", "hhee", "zdhr-d3y4e");
            Henkilo hlo2 = new Henkilo("awfraw", "gzz", "322-d3y4e");
            Henkilo hlo3 = new Henkilo("Dafaffaa", "dwwa", "dzr-d3y4e");

            Listaus.LisaaHenkilo(Lasse);
            Listaus.LisaaHenkilo(hlo);
            Listaus.LisaaHenkilo(hlo1);
            Listaus.LisaaHenkilo(hlo2);
            Listaus.LisaaHenkilo(hlo3);


            foreach (Henkilo h in Listaus.HenkiloLista)
            {
                Console.WriteLine("Henkilö: {0}",h.ToString());
            }

            //TODO kysy käyttäjältä hetu ja haetaan sitä vastaan henkilö näytölle
            Console.WriteLine("Anna hetu: ");
            Console.WriteLine(Listaus.HaeHenkiloHetulla(Console.ReadLine()));
            
            Console.WriteLine("\n\n");

        }


        public static void Deck()
        {
           
            const int suits = 4;
            string[] Suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[,] CardDeck = new string[4, 13];
            string[] Shuffling = new string[52];
            int[,] Cards = new int[4,13];

            Stack Cardss = new Stack();

            int x = 0;
            for (int i = 0; i < suits; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    
                    Cards[i,j] = j+1;
                    CardDeck[i,j] = (Cards[i, j] + " of " + Suits[i]);
                    Cardss.Push(CardDeck[i, j]);
                    Shuffling[x] = (Cards[i, j] + " of " + Suits[i]);
                    x++;
                }
            }

            Shuffler(Shuffling);
            Stack daa = new Stack(Shuffling);
            
            foreach (Object card in daa)
            {
                Console.WriteLine(card);

            }
        }

        static string[] Shuffler(string[] Shuffling)
        {
            Random rand = new Random();
            string temp;
            int RnG;
            int RnG2;

            for (int i = 0; i < 215515; i++)
            {
                RnG = rand.Next(0, 52);
                RnG2 = rand.Next(0, 52);
                temp = Shuffling[RnG];
                Shuffling[RnG] = Shuffling[RnG2];
                Shuffling[RnG2] = temp;
            }

            return Shuffling;
        }












        public static void Levy()
        {
            List<string> Songs = new List<string>();
            Songs.Add("Laalaa, 4:43");
            Songs.Add("daadaa, 3:43");
            Songs.Add("hei, 7:43");
            Songs.Add("laulu, 6:43");
            Songs.Add("Shudder Before the Beautiful, 6:29");
            Songs.Add("Weak Fantasy, 5:23");
            Songs.Add(" 4:45");
            Songs.Add("Is an Empty Hope, 5:34");
            Songs.Add("Decades in the Sun, 6:37");
            Songs.Add("Walden, 4:38");
            Songs.Add("Forms Most Beautiful, 5:07");
            Songs.Add("Ruh, 5:15");
            Songs.Add(", 4:45");
            Songs.Add("Eyes of Sharbat Gula, 6:03");
            Songs.Add("The Greatest Show on Earth, 24:00");

            Cd Levy = new Cd("levy", "artisti", Songs);

            Console.WriteLine(Levy.ToString());
        }
    }
}
