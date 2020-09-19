using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13.Models
{
    public class Blocos
    {
        public Blocos()
        {

        }

        public Blocos(int numeroBloco)
        {
            NumeroBloco = numeroBloco;
        }

        public int Id { get; set; }
        public int NumeroBloco { get; set; }

        public List<Disciplinas> Disciplinas { get; private set; } = new List<Disciplinas>();

      


    }
}
