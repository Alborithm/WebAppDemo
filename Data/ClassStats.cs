using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data
{
    public class ClassStats
    {
        [Key]
        public string Class { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public float Strength { get; set; }
        public float Agility { get; set; }
        public float Magic { get; set; }
    }
}