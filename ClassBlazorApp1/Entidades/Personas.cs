using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassBlazorApp1.Entidades
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }
        public string Nombres { get; set; }
        public int Edad { get; set; }


        public Personas()
        {
            PersonaId = 0;
            Nombres = string.Empty;
        }
    }
    
}
