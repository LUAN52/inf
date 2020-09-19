using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13.Models
{
   public class Turmas
    {
        public Turmas()
        {
        }

        public Turmas( int numeroTurma)
        {
           
            NumeroTurma = numeroTurma;
            
        }

        public int Id { get; set; }
        public int NumeroTurma { get; set; }

        public List<Blocos> Blocos { get; private set; } = new List<Blocos>();


    }
}
