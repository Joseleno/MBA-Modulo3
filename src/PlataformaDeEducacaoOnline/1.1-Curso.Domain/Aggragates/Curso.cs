using _1._1_Curso.Domain.Entities;
using _1._1_Curso.Domain.ValueObjects;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_Curso.Domain.Aggragates
{
    public class Curso : Entity
    {
        public string Nome { get; private set; } = null!;
        public string? Descricao { get; private set; }
        public Guid ProfessorId { get; private set; }
        public virtual ConteudoProgramatico? ConteudoProgramatico { get; private set; }
        public virtual ICollection<Aula> Aulas { get; private set; } = [];
        public decimal Preco { get; private set; }

        
        public void RegistrarAula(Aula aula)
        {
            Aulas.Add(aula);
        }
        public void Modificar(string nome, ConteudoProgramatico conteudoProgramatico, string usuario)
        {
            Nome = nome;
            ConteudoProgramatico = conteudoProgramatico;
            Atualizar(usuario);
        }

    }
}
