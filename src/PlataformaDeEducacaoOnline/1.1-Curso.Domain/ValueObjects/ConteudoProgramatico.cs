using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_Curso.Domain.ValueObjects
{
    public class ConteudoProgramatico(string? conteudo)
    {
        public string? Conteudo { get; private set; } = conteudo;
    }
}
