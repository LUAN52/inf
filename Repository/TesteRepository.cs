using ConsoleApp13.Data;
using ConsoleApp13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp13.Repository
{
   public class TesteRepository
    {
        public Context context;

        public TesteRepository(Context context)
        {
            this.context = context;
        }

        public void AddCurso(Curso curso)
        {
            this.context.Cursos.Add(curso);
            this.context.SaveChanges();
        }

        public void AddDisciplina(Disciplinas disciplinas)
        {
            this.context.Displinas.Add(disciplinas);
            this.context.SaveChanges();
        }

        public void AddBloco(Blocos bloco)
        {
            this.context.Blocos.Add(bloco);
            this.context.SaveChanges();
        }

        public void AddTurma(Turmas turma)
        {
            this.context.Turmas.Add(turma);
            this.context.SaveChanges(); 
        }

        public List<Turmas> BuscarTurmas()
        {
            return this.context.Turmas.ToList();
        }

        public List<Curso> BuscarCurso()
        {
            return this.context.Cursos.ToList();
        }

        public List<Blocos> BuscarBlocos()
        {
            return this.context.Blocos.ToList();
        }

        public List<Disciplinas> BuscarDisplinas()
        {
            return this.context.Displinas.ToList();
        }

        public void removeDisciplina(string nomeDisciplina)
        {
            var disciplina = this.BuscarDisplinas().Find(p=>p.nomeDisciplina==nomeDisciplina);

            this.context.Displinas.Remove(disciplina);
            this.context.SaveChanges();
            
        }

        public void removeCurso(string nomeCurso)
        {
            var curso = this.BuscarCurso().Find(p => p.NomeCurso == nomeCurso);

            this.context.Cursos.Remove(curso);
            this.context.SaveChanges();

        }

        public void removeBloco(int numero)
        {
            var bloco = this.BuscarBlocos().Find(p => p.NumeroBloco==numero);

            this.context.Blocos.Remove(bloco);
            this.context.SaveChanges();

        }


        public void removeTurma(int numero)
        {
            var turma = this.BuscarTurmas().Find(p => p.NumeroTurma==numero);

            this.context.Turmas.Remove(turma);
            this.context.SaveChanges();

        }
    }
}
