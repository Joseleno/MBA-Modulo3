using Curso.Domain.Entities;
using Curso.Domain.ValueObjects;
using Common;

namespace Curso.Domain.Aggragates
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
            Modificar(usuario);
        }

    }
}
