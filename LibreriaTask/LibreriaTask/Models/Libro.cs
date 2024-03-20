using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaTask.Models
{
    internal class Libro
    {
        public int Id { get; set; }
        public string? Titolo { get; set; }
        public string? AnnoPub { get; set; }
        public bool IsDisponibile { get; set; }
    }


}
