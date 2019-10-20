using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using services.ManageCelestialObject;
using services.ManageUser;
using web_spaceways.Models;

namespace web_spaceways.Controllers
{
    public class CelestialObjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create(CelestialObject user)
        {
            CelestialObject celestialObject = new CelestialObject();
            celestialObject.Name = "teste";
         

            try
            {
                InsertCelestialObject insert = new InsertCelestialObject();
                insert.Inserir(celestialObject);

                return View();
                //return RedirectToAction(nameof(User));
            }
            catch
            {
                return View();
            }
        }



    }
}