using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13.Models
{
   public class Curso
    {
        public Curso()
        {
        }

        public Curso(string nomeCurso)
        {
            NomeCurso = nomeCurso;
            
        }

        public int Id { get; set; }

        public string NomeCurso { get; set; }

        public List<Turmas> Turmas { get; private set; } = new List<Turmas>();

       
    }
}
