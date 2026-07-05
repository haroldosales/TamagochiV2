using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagochi
{
    internal class Pokemon
    {
        public List<Abilities> abilities { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
        public string? name { get; set; }
        public int Alimentacao { get; set; }
        public int Humor { get; set; }
        public DateTime DataNascimento { get; set; }

        public class Abilities
        {
            public Ability Ability { get; set; }
            public bool is_hidden { get; set; }
        }
    }
}
