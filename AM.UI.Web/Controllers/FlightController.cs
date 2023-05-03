using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AM.UI.Web.Controllers
{
    public class FlightController : Controller
    {
        IServiceFlight serviceFlight;
        IServicePlane servicePlane;
        public FlightController(IServiceFlight serviceFlight,IServicePlane servicePlane) {
            this.serviceFlight= serviceFlight;
            this.servicePlane= servicePlane;
        }
        // GET: FlightController
        public ActionResult Index()
        {
            var flights = this.serviceFlight.GetAll();
            return View(flights);
        }

        // GET: FlightController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult search(string departure, string destination)
        {
            if (departure != null)
            {
                var flights = serviceFlight.GetAll().Where(f => f.Departure.Contains(departure));
                return View("index", flights);

            }
            else
            {
                var flights = serviceFlight.GetAll().Where(f => f.Destination.Contains(destination));
                return View("index", flights);

            }
        }

            // GET: FlightController/Create
            public ActionResult Create()
        {
            ViewBag.Plane = new SelectList(servicePlane.GetAll(), "PlaneId", "Information");
            return View();
        }

        // POST: FlightController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Flight collection, IFormFile PilotFile)
        {
            try
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", PilotFile.FileName);
                var stream=new FileStream(path,FileMode.Create);
                PilotFile.CopyTo(stream);
                collection.Pilot = PilotFile.FileName;
                serviceFlight.Add(collection);
                serviceFlight.Commit();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FlightController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FlightController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
