using System;
using System.Collections.Generic;

namespace MaverickNovo.WebApi.Dtos
{
    public class PessoaGetResult
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
        // public IEnumerable<FilmesGetResult> Filmes { get; set; }
        public IEnumerable<FilmesGetResult> Filmes { get; set; }
    }
    
}
