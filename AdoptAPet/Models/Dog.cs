using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdoptAPet.Models
{
    public class Dog : Animal
    {
        public string FavoriteToy;
        public Dog(string breed, string name, int age, string image, string gender, string bio, string favoriteToy)
        {
            Breed = breed;
            Name = name;
            Age = age;
            Image = image;
            Gender = gender;
            Bio = bio;
            FavoriteToy = favoriteToy;
            Species = Animal.Type.Dog;
            Id = Singleton.IdCount;
            Singleton.IdCount++;
            AnimalType = "Dog";
        }
    }
}