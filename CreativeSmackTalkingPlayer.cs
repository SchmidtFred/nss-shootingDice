using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> Taunts { get; set; } = new List<string>() { "Neener Neener"};

        public override int Roll()
        {
            Console.WriteLine($"{Name} says \"{Taunts[new Random().Next(Taunts.Count)]}\" before rolling.");
            return base.Roll();
        }
    }
}