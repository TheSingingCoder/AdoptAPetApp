using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdoptAPet.Models
{
    public class SmallAnimal : Animal
    {
        public string Housing;
        public SmallAnimal(string breed, string name, int age, string image, string gender, string bio, string housing)
        {
            Breed = breed;
            Name = name;
            Age = age;
            Image = image;
            Gender = gender;
            Bio = bio;
            Housing = housing;
            Species = Animal.Type.SmallAnimal;
            Id = Singleton.IdCount;
            Singleton.IdCount++;
            AnimalType = "SmallAnimal";
        }
    }
}