namespace Curso.Domain.ValueObjects
{
    public class ConteudoProgramatico(string? conteudo)
    {
        public string? Conteudo { get; private set; } = conteudo;
    }
}
