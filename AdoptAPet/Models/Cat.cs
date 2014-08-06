using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdoptAPet.Models
{
    public class Cat : Animal
    {
        public bool OtherCats;
        public Cat(string breed, string name, int age, string image, string gender, string bio, bool otherCats)
        {
            Name = name;
            Breed = breed;
            Age = age;
            Image = image;
            Gender = gender;
            Bio = bio;
            OtherCats = otherCats;
            Species = Animal.Type.Cat;
            Id = Singleton.IdCount;
            Singleton.IdCount++;
            AnimalType = "Cat";
        }
    }
}