using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kokoelmaluokat
{
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
