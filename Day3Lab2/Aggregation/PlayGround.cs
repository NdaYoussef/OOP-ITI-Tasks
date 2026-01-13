using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class PlayGround
    {
        public string Name { get; set; }

        public Players[] Players = new Players[2];

        public PlayGround(string name)
        {
            Name = name; 
        }


        public void PlayersEntered(Players[] players)
        {
            Players = players;
        }

        public void ShowPlayers()
        {
            Console.WriteLine($"show Players in {Name}:");
            foreach (var player in Players)
            {
                Console.WriteLine($"- {player.Name}, {player.Age} years old");
            }
        }
    }
}
