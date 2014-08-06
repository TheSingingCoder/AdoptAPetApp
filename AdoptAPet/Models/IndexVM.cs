using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdoptAPet.Models
{
    public class IndexVM
    {
        public List<Dog> Dogs = new List<Dog>();
        public List<Cat> Cats = new List<Cat>();
        public List<Reptile> Reptiles = new List<Reptile>();
        public List<SmallAnimal> SmallAnimals = new List<SmallAnimal>();
    }
}