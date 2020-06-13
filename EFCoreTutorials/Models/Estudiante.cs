using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTutorials.Models
{
    public class Estudiante
    {
        public int estudianteId { get; set; }
        public string nombre { get; set; }
        public string  grado { get; set; }
        public string profesor { get; set; }
    }
}
