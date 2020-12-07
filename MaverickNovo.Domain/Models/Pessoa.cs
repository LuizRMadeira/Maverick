using System;
using System.Collections.Generic;

namespace MaverickNovo.Domain.Models
{
    public class Pessoa
    {
        /// <summary>
        /// Nome da Pessoa.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Departamento/Papel da Pessoa.
        /// </summary>
        public string Departamento { get; set; }

        /// <summary>
        /// Lista dos Filmes
        /// </summary>
        public IEnumerable<Filme> Filmes { get; set; }
    }
}
