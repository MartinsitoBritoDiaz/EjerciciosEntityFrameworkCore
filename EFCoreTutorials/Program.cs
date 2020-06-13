using System;
using System.Collections.Generic;
using System.Linq;
using EFCoreTutorials.DAL;
using EFCoreTutorials.Models;
using EFCoreTutorials.Pruebas;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace EFCoreTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicios ejercicio = new Ejercicios();

            /*var grado = new Grado()
            {
                nombre = "Segundo",
                Seccion = "Primaria"
            };

            var direccionEstudiante = new DireccionEstudiante()
            {
                ciudad = "S.F.C.M.",
                provincia = "Duarte",
                pais = "R.D."
            };*/

            Console.WriteLine("\n\t**---Ejercicios---**");

            //ejercicio.CrearEstudiante();
            //ejercicio.ConsultarEstudiante();
            //ejercicio.ConsultarGrado();
            //ejercicio.InsertarEstudiantes();
            //ejercicio.ActualizarEstudiantes();
            //ejercicio.EliminarEstudiante();
            ///ejercicio.InsertarDatosRelacionados();


            //Estado sin cambios
            /*using (var context = new Contexto())
            {
                // retrieve entity 
                var estudiante = context.Estudiantes.First();
                DisplayStates(context.ChangeTracker.Entries());
            }*/


            //Añadir estado
            /*using (var context = new Contexto())
            {
                context.Add(new Estudiante() {
                    nombre = "Martinsito",
                    apellido = "Brito",
                    altura = 6,
                    peso = 250,
                    fechaNacimiento = DateTime.Now,
                    Grado = grado,

                    Direccion = direccionEstudiante,
                     });
                DisplayStates(context.ChangeTracker.Entries());
            }*/


            //Estado modificado
            /*using (var context = new Contexto())
            {
                var estudiante = context.Estudiantes.First();
                estudiante.apellido = "Apellido cambiado";
                DisplayStates(context.ChangeTracker.Entries());
            }*/


            //Estado eliminado
            /*using (var context = new Contexto())
            {
                var estudiante = context.Estudiantes.First();
                context.Estudiantes.Remove(estudiante);
                DisplayStates(context.ChangeTracker.Entries());
            }*/


            Console.WriteLine("\nFin");
        }

        private static void DisplayStates(IEnumerable<EntityEntry> entries)
        {
            foreach (var entry in entries)
            {
                Console.WriteLine($"Entity: {entry.Entity.GetType().Name},State: { entry.State.ToString()} ");
            }
        }

    }
}
