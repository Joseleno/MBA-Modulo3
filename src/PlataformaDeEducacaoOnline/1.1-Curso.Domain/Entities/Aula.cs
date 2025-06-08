namespace Curso.Domain.Entities
{
    public class Aula
    {
        public string Nome { get; private set; } = null!;
        public string? Descricao { get; private set; }

        public virtual Aggragates.Curso Curso { get; private set; } = null!;
        public Guid CursoId { get; private set; }

        public Aula()
        {
        }

        public Aula(string nome, string? descricao, Guid cursoId)
        {
            Nome = nome;
            Descricao = descricao;
            CursoId = cursoId;
        }
    }
}
