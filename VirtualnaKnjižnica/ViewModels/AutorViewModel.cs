using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VirtualnaKnjižnica.ViewModels
{
    public class AutorViewModel
    {
        [Required]
        public string Ime { get; set; }

        [Required]
        public string Prezime { get; set; }
    }
}