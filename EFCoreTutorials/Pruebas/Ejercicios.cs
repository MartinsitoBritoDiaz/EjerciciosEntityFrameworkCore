using EFCoreTutorials.DAL;
using EFCoreTutorials.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreTutorials.Pruebas
{
    public class Ejercicios
    {
        public void CrearEstudiante()
        {
            using (var context = new Contexto())
            {

                var estudiante = new Estudiante()
                {
                    nombre = "Martin",
                    //grado = "Tercero",
                    //profesor = "Marcos"
                };

                context.Estudiantes.Add(estudiante);
                context.SaveChanges();
            }
        }

        public void ConsultarEstudiante()
        {
            var context = new Contexto();
            var studentsWithSameName = context.Estudiantes.Where(e => e.nombre == GetNombre()).ToList();

            if (studentsWithSameName != null)
                foreach (var auxiliar in studentsWithSameName)
                {
                    Console.WriteLine(auxiliar.nombre);
                }
            else
                Console.WriteLine("No se encontro ningun estudiante con el mismo nombre");
        }

        public void mostrar(Estudiante estudiante)
        {
            Console.WriteLine(estudiante.nombre);
            //Console.WriteLine(estudiante.grado);
            //Console.WriteLine(estudiante.profesor);
        }

        public string GetNombre()
        {
            return "Martinsito";
        }

        public void ConsultarGrado()
        {
            var context = new Contexto();

            /*var studentWithGrade = context.Estudiantes.Where(e => e.nombre == GetNombre()).Include(e => e.profesor).FirstOrDefault();

            if (studentWithGrade != null)
                mostrar(studentWithGrade);
            else
                Console.WriteLine("No se encontro ningun estudiante con un grado");*/
        }

        public void InsertarEstudiantes()
        {
            using (var context = new Contexto())
            {
                var estudiante = new Estudiante()
                {
                    nombre = "Bill",
                    //grado = "Segundo",
                    //profesor = "Josh"
                };
                context.Estudiantes.Add(estudiante);
                context.SaveChanges();
            }
        }

        public void ActualizarEstudiantes()
        {
            using (var context = new Contexto())
            {
                var estudiante = context.Estudiantes.First<Estudiante>();
                estudiante.nombre = "Steve";
                context.SaveChanges();
            }
        }

        public void EliminarEstudiante()
        {
            using (var context = new Contexto())
            {
                var estudiante = context.Estudiantes.First<Estudiante>();
                context.Estudiantes.Remove(estudiante); 
                context.SaveChanges();
            }
        }
    }
    
}
