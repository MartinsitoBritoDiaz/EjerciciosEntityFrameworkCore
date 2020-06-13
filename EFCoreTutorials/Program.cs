using System;
using EFCoreTutorials.DAL;
using EFCoreTutorials.Models;
using EFCoreTutorials.Pruebas;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace EFCoreTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicios ejercicio = new Ejercicios();

            Console.WriteLine("\n\t**---Ejercicios---**");

            //ejercicio.CrearEstudiante();
            //ejercicio.ConsultarEstudiante();
            ejercicio.ConsultarGrado();

            Console.WriteLine("\nFin");
        }

    }
}
