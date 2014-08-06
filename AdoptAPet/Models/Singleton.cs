using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdoptAPet.Models
{
    public class Singleton
    {
        private static Singleton _instance;
        public static Singleton Instance { get {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }}
        public List<Animal> Animals;
        public List<Dog> Dogs;
        public List<Cat> Cats;
        public List<Reptile> Reptiles;
        public List<SmallAnimal> SmallAnimals;
        public static int IdCount;
        private Singleton()
        {
            IdCount = 1;
            Animals = new List<Animal>();
            Dogs = new List<Dog>();
            Cats = new List<Cat>();
            Reptiles = new List<Reptile>();
            SmallAnimals = new List<SmallAnimal>();
            Dogs.Add(new Dog("Beagle", "Robby", 2, "/Images/Dog3.jpg", "Male", "Robby's looking for a loving family", "Tennis Ball"));
            Cats.Add(new Cat("American Long Hair", "Bailey", 4, "/Images/Cat1.jpg", "Male", "All Bailey wants is a soft pillow and an occasional milk saucer", true));
            Reptiles.Add(new Reptile("Bearded Dragon", "Toothy", 3, "Images/Lizard.jpg","Female", "Toothy won't grow large and will make a great pet. Need a little handling and patience.", "Medium Tank and Heat Lamp"));
            SmallAnimals.Add(new SmallAnimal("Rabbit", "Tiki", 1, "/Images/Bunny1.jpg", "Female", "Tiki's loving eating carrots and hopping in circles", "Medium Cag. Can be kept outdoors, weather permitting"));
            Dogs.Add(new Dog("Golden Retriever", "Douglas", 2, "/Images/Dog1.jpg", "Male", "Loves walks in the park and kids", "rubber bone"));
            Cats.Add(new Cat("Maine Coon", "Simon", 1, "/Images/Cat2.jpg", "Male", "Loves having a full house, great with kids", true));
            Reptiles.Add(new Reptile("Ball Python", "Gregor", 9, "/Images/Snake1.jpg", "Male", "I am a friendly wonderful first pet snake. Would be great for younger reptile lovers. I do like to eat live food, though.", "Large Tanka and heat lamp"));
            SmallAnimals.Add(new SmallAnimal("Rabbit", "Peony", 1, "/Images/Bunny2.jpg", "Female", "Loves eating carrots", "Medium cage , shoud be indoors"));
            Reptiles.Add(new Reptile("Ball Python", "Lucy", 5, "/Images/Snake2.jpg", "Female", "Loves sun bathing", "Medium tank"));
            SmallAnimals.Add(new SmallAnimal("Guniea Pig", "Lance", 2, "/Images/Gunieapig.jpg", "Male", "Although he's young, he knows what he wants - and he definitely wants to be the BPOC (Big Pig on Campus). He would do very well with a docile older piggy who doesn't mind letting another pig get the attention. And Lance will definitely grab for attention - he will let you know when it's time to give him veggies, time for floor time, snuggle time…in other words, he likes to run the show. He is a very sweet pig with people. If you have a lonely older piggy in need of a friend, Lance is a great candidate!", "Medium cage, great for running around the house"));
            Cats.Add(new Cat("Siamese", "Sansa", 4, "/Images/Cat3.jpg", "Female", "Loves cuddling on the couch and tuna fish", false));
            Dogs.Add(new Dog("Boxer", "Nimeria", 2, "/Images/Dog2.jpg", "Female", "Faithful ", "Shoes"));

            Animals.AddRange(Dogs);
            Animals.AddRange(Cats);
            Animals.AddRange(Reptiles);
            Animals.AddRange(SmallAnimals);
        }
    }
}