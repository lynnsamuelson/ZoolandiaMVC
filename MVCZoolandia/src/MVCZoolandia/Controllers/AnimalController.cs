using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MVCZoolandia.Models;
using MVCZoolandia.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCZoolandia.Controllers
{
    public class AnimalController : Controller
    {
        private ZoolandiaContext dbContext { get; set; }
        public AnimalController(ZoolandiaContext context)
        {
            dbContext = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {

            var animals = (from an in dbContext.Animal
                                      join ha in dbContext.Habitat
                                      on an.HabitatId equals ha.HabitatId
                                      join em in dbContext.Employee
                                      on ha.HabitatId equals em.EmployeeId
                                      orderby an.Name
                                      select new AnimalViewModel
                                      {
                                          Name = an.Name,
                                          HabitatType = ha.Type,
                                          EmployeeFirstName = em.FirstName
                                          
                                      }).ToList();
           AnimalHabitatViewModel animalDetails = new AnimalHabitatViewModel
            {
                Animals = animals
            };


            return View(animalDetails);
           
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(AnimalHabitatViewModel animalDetails)
        {
            //using (DataStoreContext _context = new DataStoreContext())
            //{
                if (ModelState.IsValid)
                {
                    Animal animal = new Animal
                    {
                        Name = animalDetails.AnimalName,
                        Food = animalDetails.AnimalFood
                    };
                    dbContext.Animal.Add(animal);
                    dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(animalDetails);
            }

        //}
    }
}
