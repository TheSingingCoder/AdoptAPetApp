using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdoptAPet.Models
{
    public class Reptile : Animal
    {
        public string Housing;
        public Reptile(string breed, string name, int age, string image, string gender, string bio, string housing)
        {
            Breed = breed;
            Name = name;
            Age = age;
            Image = image;
            Gender = gender;
            Bio = bio;
            Housing = housing;
            Species = Animal.Type.Reptile;
            Id = Singleton.IdCount;
            Singleton.IdCount++;
            AnimalType = "Reptile";
        }
    }
}