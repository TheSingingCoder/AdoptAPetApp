using AdoptAPet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdoptAPet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Animal> Animals = Singleton.Instance.Animals;
            Animals.Sort((x, y) => string.Compare(x.Name, y.Name));
            return View(Animals);
        }
        public ActionResult IndexBySpecies(string animalType)
        {
            List<Animal> Animals = Singleton.Instance.Animals;
            List<Animal> OneType = Animals.Where(a => a.AnimalType == animalType).ToList();
            return View(OneType);
        }
        public ActionResult CatDetails(int id)
        {
            List<Animal> Animals = Singleton.Instance.Animals;
            Animal Animal = Animals.Where(a => a.Id == id).FirstOrDefault();
            return View(Animal);
        }
        public ActionResult DogDetails(int id)
        {
            List<Animal> Animals = Singleton.Instance.Animals;
            Animal Animal = Animals.Where(a => a.Id == id).FirstOrDefault();
            return View(Animal);
        }
        public ActionResult ReptileDetails(int id)
        {
            List<Animal> Animals = Singleton.Instance.Animals;
            Animal Animal = Animals.Where(a => a.Id == id).FirstOrDefault();
            return View(Animal);
        }
        public ActionResult SmallAnDetails(int id)
        {
            List<Animal> Animals = Singleton.Instance.Animals;
            Animal Animal = Animals.Where(a => a.Id == id).FirstOrDefault();
            return View(Animal);
        }
        //See Add New Animals
        public ActionResult NewReptile()
        {
            return View();
        }
        public ActionResult NewCat()
        {
            return View();
        }
        public ActionResult NewDog()
        {
            return View();
        }
        public ActionResult NewSmallAnimal()
        {
            return View();
        }
        //Save New Animal
        [HttpPost]
        public ActionResult NewReptile(string name, string breed, int age, string image, string gender, string bio, string housing)
        {
            List<Animal> Animals = Singleton.Instance.Animals;
            Animals.Add(new Reptile(breed, name, age, image, gender, bio, housing));
            return RedirectToAction("SpeciesByIndex", "Reptile");
        }
        [HttpPost]
        public ActionResult NewCat(string name, string breed, int age, string image, string gender, string bio, bool otherCats)
        {
            List<Animal> Animals = Singleton.Instance.Animals;
            Animals.Add(new Cat(breed, name, age, image, gender, bio, otherCats));
            return RedirectToAction("SpeciesByIndex", "Cat");
        }

        [HttpPost]
        public ActionResult NewDog(string name, string breed, int age, string image, string gender, string bio, string toy)
        {
            List<Animal> Animals = Singleton.Instance.Animals;
            Animals.Add(new Dog(breed, name, age, image, gender, bio, toy));
            string animal = "Dog";
            return RedirectToAction("SpeciesByIndex", new {animalType = animal});
        }
        [HttpPost]
        public ActionResult NewSmallAnimal(string name, string breed, int age, string image, string gender, string bio, string housing)
        {
            List<Animal> Animals = Singleton.Instance.Animals;
            Animals.Add(new SmallAnimal(breed, name, age, image, gender, bio, housing));
            return RedirectToAction("SpeciesByIndex", "SmallAnimal");
        }
        //See Edit Animal
        public ActionResult EditSmallAnimal(int id)
        {
            List<Animal> Animals = Singleton.Instance.Animals;
            SmallAnimal OneAnimal = Animals.Where(a => a.Id == id).Cast<SmallAnimal>().FirstOrDefault();
            return View(OneAnimal);
        }
        public ActionResult EditCat(int id)
        {
            List<Animal> Animals = Singleton.Instance.Animals;
            Cat OneAnimal = Animals.Where(a => a.Id == id).Cast<Cat>().FirstOrDefault();
            return View(OneAnimal);
        }
        public ActionResult EditDog(int id)
        {
            List<Animal> Animals = Singleton.Instance.Animals;
            Dog OneAnimal = Animals.Where(a => a.Id == id).Cast<Dog>().FirstOrDefault();
            return View(OneAnimal);
        }
        public ActionResult EditReptile(int id)
        {
            List<Animal> Animals = Singleton.Instance.Animals;
            Reptile OneAnimal = Animals.Where(a => a.Id == id).Cast<Reptile>().FirstOrDefault();
            return View(OneAnimal);
        }
        //Save Edit Animal
        //public ActionResult EditSmallAnimal(string name, string breed, int age, string image, )
        [HttpPost]
        public ActionResult UpdateSmallAnimal(int id, string name, string breed, int age, string image, string gender, string bio, string housing)
        {
            List<Animal> Animals = Singleton.Instance.Animals;
            SmallAnimal ThisAnimal = Animals.Where(a => a.Id == id).Cast<SmallAnimal>().FirstOrDefault();
            ThisAnimal.Name = name;
            ThisAnimal.Breed = breed;
            ThisAnimal.Age = age;
            ThisAnimal.Image = image;
            ThisAnimal.Gender = gender;
            ThisAnimal.Bio = bio;
            ThisAnimal.Housing = housing;
            return RedirectToAction("SmallAnDetails", new { id = id});
        }
        [HttpPost]
        public ActionResult UpdateDog(int id, string name, string breed, int age, string image, string gender, string bio, string toy)
        {
            List<Animal> Animals = Singleton.Instance.Animals;
            Dog ThisAnimal = Animals.Where(a => a.Id == id).Cast<Dog>().FirstOrDefault();
            ThisAnimal.Name = name;
            ThisAnimal.Breed = breed;
            ThisAnimal.Age = age;
            ThisAnimal.Image = image;
            ThisAnimal.Gender = gender;
            ThisAnimal.Bio = bio;
            ThisAnimal.FavoriteToy = toy;
            return RedirectToAction("DogDetails", new { id = id });
        }
        public ActionResult UpdateCat(int id, string name, string breed, int age, string image, string gender, string bio, bool otherCats)
        {
            List<Animal> Animals = Singleton.Instance.Animals;
           Cat ThisAnimal = Animals.Where(a => a.Id == id).Cast<Cat>().FirstOrDefault();
            ThisAnimal.Name = name;
            ThisAnimal.Breed = breed;
            ThisAnimal.Age = age;
            ThisAnimal.Image = image;
            ThisAnimal.Gender = gender;
            ThisAnimal.Bio = bio;
            ThisAnimal.OtherCats = otherCats;
            return RedirectToAction("CatDetails", new { id = id });
        }
        [HttpPost]
        public ActionResult UpdateReptile(int id, string name, string breed, int age, string image, string gender, string bio, string housing)
        {
            List<Animal> Animals = Singleton.Instance.Animals;
            Reptile ThisAnimal = Animals.Where(a => a.Id == id).Cast<Reptile>().FirstOrDefault();
            ThisAnimal.Name = name;
            ThisAnimal.Breed = breed;
            ThisAnimal.Age = age;
            ThisAnimal.Image = image;
            ThisAnimal.Gender = gender;
            ThisAnimal.Bio = bio;
            ThisAnimal.Housing = housing;
            return RedirectToAction("ReptileDetails", new { id = id });
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

    
