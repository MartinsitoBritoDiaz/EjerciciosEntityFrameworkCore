using EFCoreTutorials.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTutorials.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Curso> Cursos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=EscuelaDB;Trusted_Connection=True;");
        }
        /* Este OnModelCreating fue utilizado en un ejercicio anterior del curso.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<Estudiante>()
                .Property(e => e.estudianteId)
                .HasColumnName("estudianteId")
                .HasDefaultValue(0)
                .IsRequired();
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiante>()
                .HasOne<DireccionEstudiante>(e => e.Direccion)
                .WithOne(ad => ad.Estudiante)
                .HasForeignKey<DireccionEstudiante>(ad => ad.direccionEstudianteId);
        }
    }
}
