using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreTutorials.Models
{
    public class Estudiante
    {
        [Key]
        public int estudianteId { get; set; }
        [Required(ErrorMessage ="Debe de introducir este campo")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Debe de introducir este campo")]
        public string apellido { get; set; }
        
        [Required(ErrorMessage ="Debe de introducir este campo")]
        public DateTime fechaNacimiento { get; set; }
        
        [Required(ErrorMessage ="Debe de introducir este campo")]
        public byte[] photo { get; set; }
        
        [Required(ErrorMessage ="Debe de introducir este campo")]
        public decimal altura { get; set; }
        
        [Required(ErrorMessage ="Debe de introducir este campo")]
        public float peso { get; set; }
        
        public DireccionEstudiante Direccion { get; set; }

        public int GradoId { get; set; }

        [ForeignKey("GradoId")]
        public virtual Grado Grado { get; set; }



        //Estas columnas las utilice en los primeros ejercicios
        /*
        public int estudianteId { get; set; }
        public string nombre { get; set; }
        public string  grado { get; set; }
        public string profesor { get; set; }
        */
    }
}
