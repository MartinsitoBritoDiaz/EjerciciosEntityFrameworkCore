using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreTutorials.Models
{
    public class Grado
    {
        [Key]
        public int gradoId { get; set; }
        
        [Required(ErrorMessage ="Debe de introducir este campo")]
        public string nombre { get; set; }
        
        [Required(ErrorMessage ="Debe de introducir este campo")]
        public string Seccion { get; set; }

        public IList<Estudiante> estudiantes { get; set; }
    }
}
