using Aluno.Domain.Repositories;
using Common;

namespace Aluno.Application.Commands.Add
{
    public class AddHandler(IAlunoRepository repositorio, IUsuarioContext usuarioContexto, IUnitOfWork unitOfWork)
    {
        private readonly IAlunoRepository _repositorio = repositorio;
        private readonly IUsuarioContext _usuarioContext = usuarioContexto;
        private readonly IUnitOfWork _unitOfWork = unitOfWork;

        public async Task<Result<Guid>> Handle(Add comando, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(comando.Nome))
                return Result<Guid>.Error("O campo nome é obrigatório.");

            if (string.IsNullOrWhiteSpace(comando.Email) || !comando.Email.Contains('@'))
                return Result<Guid>.Error("Email inválido.");

            var aluno = new Domain.Entities.Aluno(comando.Nome, comando.Email, _usuarioContext.GetUsuario());
            await _repositorio.Add(aluno);
            await _unitOfWork.Commit();

            return Result<Guid>.Sucess(aluno.Id, "Cadastro realizado com sucesso!");
        }
    }
}
