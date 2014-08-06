using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdoptAPet.Models
{
    public abstract class Animal
    {
        public string Breed { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Image { get; set; }
        public string Gender { get; set; }
        public string Bio { get; set; }
        public int Id { get; set; }
        public Type Species { get; set; }
        public enum Type { Cat = 1, Dog = 2, Reptile = 3, SmallAnimal = 4};
        public string  AnimalType;
    }
}