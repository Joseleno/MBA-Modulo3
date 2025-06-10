using Common;

namespace Aluno.Domain.Entities
{
    public class Aluno : Entity
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Aluno(string nome, string email, string usuarioCriacao)
        : base(usuarioCriacao)
        {
            Nome = nome;
            Email = email;
        }
    }
}
