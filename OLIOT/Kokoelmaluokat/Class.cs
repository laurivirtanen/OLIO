using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kokoelmaluokat
{

    class Card
    {
        private int value;
        private string suit;
        public int Value { get { return value; } }
        public string Suit { get { return suit; } }
        public Card(int val, string st)
        {
            value = val;
            suit = st;
        }

        public override string ToString()
        {
            switch (value)
            {
                
                    
                case 11:
                    return "Jack of " + suit;
                   
                case 12:
                    return "Queen of " + suit;
                    
                case 13:
                    return "King of " + suit;
                case 14:
                    return "Ace of " + suit;

                default:
                    return value + " of " + suit;
            }
        }
    }

    class Deck
    {
        
        private List<Card> cards;
        public List<Card> CardList { get { return cards; } }
        public Deck()
        {
            cards = new List<Card>();

        }

        public List<Card> Fill()
        {
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            int x = 0;
            foreach (var suit in suits)
            {
                for (int i = 2; i < 15; i++)
                {
                    cards.Add(new Card(i, suits[x]));
                }
                x++;
            }
            return cards;
        }

        public List<Card> Shuffle()
        {

            //30k shuffles
            for (int i = 0; i < 100000; i++)
            {
                Random rand = new Random();
                int max = 52;
                List<Card> cardss = new List<Card>();
                while (max > 0)
                {
                    int RnG = rand.Next(0, max);
                    cardss.Add(cards[RnG]);
                    cards.Remove(cards[RnG]);
                    max--;
                }

                cards = cardss;

                //every 20k "shuffle" lets user know
                if (i % 20000 == 0) { Console.WriteLine("loading..."); }
                /* BUG TESTING REMOVE
                if (i % 5000 == 0)
                {
                    Console.WriteLine("\n\n");
                    foreach (var item in cards)
                    {
                        Console.WriteLine(item.ToString());
                    }

                } */
            }
           
            return cards;
        }
        //hand sorting, doesnt belong here
        public Card[] Sorting(Card[] handu)
        {

            Array.Sort(handu, delegate (Card card, Card card2)
            {
                return card.Suit.CompareTo(card2.Suit);
            });
            Array.Sort(handu, delegate (Card card, Card card2)
            {
                return card.Value.CompareTo(card2.Value);
            });
            Array.Reverse(handu);
            return handu;
        }

    }



    /// <summary>
    /// This class contains person properties
    /// </summary>
    class Henkilo
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Hetu { get; set; }

        public Henkilo(string enimi,string snimi, string hetu)
        {
            Etunimi = enimi;
            Sukunimi = snimi;
            Hetu = hetu;
        }

        public override string ToString()
        {
            return Etunimi + " " + Sukunimi + " - " + Hetu; 
        }
    }
    
    /// <summary>
    /// This class contains persons stuffs
    /// </summary>
    class Henkilot
    {

        //properties
        private List<Henkilo> henkilot;

        public List<Henkilo> HenkiloLista { get { return henkilot; } } 

        public Henkilot()
        {
            henkilot = new List<Henkilo>();
        }

        public void LisaaHenkilo(Henkilo hlo)
        {
            henkilot.Add(hlo);
        }

        public Henkilo HaeHenkilo(int index)
        {
            if (index < henkilot.Count)
            {
                return henkilot.ElementAt(index);
            }
            else
            {
                return null;
            }
        }

        public Henkilo HaeHenkiloHetulla(string hetu)
        {
            foreach (Henkilo henkilo in henkilot)
            {
                if(henkilo.Hetu == hetu)
                {
                    return henkilo;
                }
            }

            Console.WriteLine("ERROR");
            return null;
        }
        
    }      
        
        
                     
    class Player
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }
        public int Number { get; set; }
    }


    class Team
    {
        public string Name { get; set; }
        public string City { get; set; }
        public List<Player> Players { get; }

        public Team(string name, string city, List<Player> players)
        {
            Name = name;
            City = city;
            Players = players;
            GetPlayers(Name);
        }

        public void GetPlayers(string joukkue)
        {
            foreach (Player player in Players)
            {
                Players.Add(player);
            }
        }
    }


    class Cd
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        List<string> Songs { get; }

        public Cd (string name, string artist, List<string> songs)
        {
            Name = name;
            Artist = artist;
            Songs = songs;
        }
        int x = 1;
        public override string ToString()
        {

            string s = "CD - DATA\n\nArtist: " + Artist + " Name: " + Name + "\n\n";

            foreach (string song in Songs)
            {
                s += "\t"+x+"|" + song + "\n";
                x++;
            }
            
            return s;
        }


    }
}
