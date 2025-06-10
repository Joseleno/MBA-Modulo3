using Curso.Domain.Entities;
using Curso.Domain.ValueObjects;
using Common;

namespace Curso.Domain.Aggragates
{
    public class Curso(string nome, string descricao, Guid professorId, string usuarioCriacao) : Entity(usuarioCriacao)
    {
        public string Nome { get; private set; } = nome;
        public string? Descricao { get; private set; } = descricao;
        public Guid ProfessorId { get; private set; } = professorId;
        public virtual ConteudoProgramatico? ConteudoProgramatico { get; private set; }
        public virtual ICollection<Aula> Aulas { get; private set; } = [];
        public decimal Preco { get; private set; }

        public void RegistrarAula(Aula aula)
        {
            Aulas.Add(aula);
        }

        public void Update(string nome, ConteudoProgramatico conteudoProgramatico, string usuario)
        {
            Nome = nome;
            ConteudoProgramatico = conteudoProgramatico;
            Update(usuario);
        }

        public void UpdatePreco(decimal preco, string usuario)
        {
            Preco = preco;
            Update(usuario);
        }
    }
}
