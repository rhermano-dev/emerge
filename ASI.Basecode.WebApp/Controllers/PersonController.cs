using ASI.Basecode.Data.Models;
using ASI.Basecode.Services.Interfaces;
using ASI.Basecode.Services.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ASI.Basecode.WebApp.Controllers
{
    public class PersonController : Controller
    {
        public IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        public IActionResult Index()
        {
            var list = _personService.GetPersonList();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PersonModel person)
        {
            _personService.AddPersonData(person);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            PersonModel person = _personService.GetPersonList().Where(x => x.Id == id).FirstOrDefault();
            return View(person);
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            PersonModel person = _personService.GetPersonById(id);
            return View(person);
        }

        [HttpPost]
        public IActionResult Edit(PersonModel person)
        {
            _personService.EditPersonData(person);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(string id)
        {
            _personService.DeletePersonData(id);

            return RedirectToAction("Index");
        }
    }
}
