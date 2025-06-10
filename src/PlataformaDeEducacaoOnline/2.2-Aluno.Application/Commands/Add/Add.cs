namespace Aluno.Application.Commands.Add
{
    public class Add
    {
        public string Nome { get; }
        public string Email { get; }

        public Add(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
