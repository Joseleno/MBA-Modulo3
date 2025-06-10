namespace Aluno.Domain.Repositories
{
    public interface IAlunoRepository
    {
        Task Add(Entities.Aluno aluno);
        Task Delete(Entities.Aluno aluno);
        Task Update(Entities.Aluno aluno);
        Task<List<Entities.Aluno>> Listar();
        Task<Entities.Aluno> ObterPorId(Guid id);
        Task<Entities.Aluno> ObterAlunoPorMatriculaId(Guid matriculaId);
    }
}
