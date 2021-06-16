using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcOefFilm.Models
{
    public class FilmViewModel
    {
        public string Titel { get; set; }
        public string Director { get; set; }
        public string Taal { get; set; }
        public string ProductionCompany { get; set; }

        public TimeSpan Duur { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
