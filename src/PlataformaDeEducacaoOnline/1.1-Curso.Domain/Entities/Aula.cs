﻿using _1._1_Curso.Domain.Aggragates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_Curso.Domain.Entities
{
    public class Aula
    {
        public string Nome { get; private set; } = null!;
        public string? Descricao { get; private set; }

        public virtual Curso Curso { get; private set; } = null!;
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
