using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
  public class Disciplinas
    {
        public Disciplinas()
        {
        }

        public Disciplinas(string nomeDisciplina)
        {
            this.nomeDisciplina = nomeDisciplina;
        }

        public int Id { get; set; }
        public string nomeDisciplina { get; set; }


    }
}
