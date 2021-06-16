using Microsoft.AspNetCore.Mvc;
using MvcOefFilm.Domain;
using MvcOefFilm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcOefFilm.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult LoadedFilm()
        {
            var film = new Film
            {
                Id = new Guid(),
                Taal = "Engels",
                Titel = "Harry Pooter",
                Director = "Jk just rollin",
                ProductionCompany = "Warner Bros",
                Duur = TimeSpan.FromHours(1.5),
                PublishDate = new DateTime(2000, 09,15)
            };
            var vm = new FilmViewModel
            {
                Taal = film.Taal,
                Titel = film.Titel,
                Director = film.Director,
                ProductionCompany = film.ProductionCompany,
                Duur = film.Duur,
                PublishDate = film.PublishDate,
            };
            return View(vm);
        }
    }
}
