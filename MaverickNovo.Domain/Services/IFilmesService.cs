using MaverickNovo.Domain.Exceptions;
using MaverickNovo.Domain.Models;
using Otc.DomainBase.Exceptions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MaverickNovo.Domain.Services
{
    public interface IFilmesService
    {
        /// <summary>
        /// Realiza pesquisa em filmes.
        /// </summary>
        /// <param name="pesquisa">Criterios de pesquisa.</param>
        /// <returns>
        ///     Lista dos filmes encontrados conforme criterio de pesquisa.
        /// </returns>
        /// <exception cref="BuscarFilmesCoreException" />
        /// <exception cref="ModelValidationException" />
        Task<IEnumerable<Filme>> ObterFilmesAsync(Pesquisa pesquisa);

        /// <summary>
        /// Realiza pesquisa em filmes por pessoa.
        /// </summary>
        /// <param name="pesquisa">Criterios de pesquisa.</param>
        /// <returns>
        ///     Lista das pessoas encontradas e seus filmes conforme criterio de pesquisa.
        /// </returns>
        /// <exception cref="BuscarFilmesCoreException" />
        /// <exception cref="ModelValidationException" />
        Task<IEnumerable<Pessoa>> ObterFilmesPorPessoaAsync(PesquisaPorPessoa pesquisa);
  }
}
