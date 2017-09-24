using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VirtualnaKnjižnica.Models
{
    [Table("Autor")]
    public class Autor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte AutorId { get; set; }

        public string AutorIme { get; set; }

        public string AutorPrezime { get; set; }
    }
}
