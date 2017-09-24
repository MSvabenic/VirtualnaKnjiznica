using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VirtualnaKnjižnica.Models;
using VirtualnaKnjižnica.ViewModels;

namespace VirtualnaKnjižnica.Controllers
{
    public class AutorController : Controller
    {
        private ApplicationDbContext _context;

        public AutorController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult DodajAutora()
        {
            var viewModel = new AutorViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult DodajAutora(AutorViewModel viewModel)
        {
            var autor = new Autor
            {
                AutorIme = viewModel.Ime,
                AutorPrezime = viewModel.Prezime
            };
            _context.Autor.Add(autor);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}