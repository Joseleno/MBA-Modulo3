using Curso.Domain.Aggragates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Domain.Interfaces;

public interface ICursoRepository
{
    Task<Aggragates.Curso> ObterPorId(Guid id);
    Task Cadastrar(Aggragates.Curso curso);
    Task Alterar(Aggragates.Curso curso);
    Task Excluir(Aggragates.Curso curso);
    Task<List<Aggragates.Curso>> Listar();
}
