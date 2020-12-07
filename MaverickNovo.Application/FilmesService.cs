using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MaverickNovo.Domain.Adapters;
using MaverickNovo.Domain.Models;
using MaverickNovo.Domain.Services;
using Microsoft.Extensions.Logging;
using Otc.Validations.Helpers;

namespace MaverickNovo.Application
{
    public class FilmesService : IFilmesService
    {
        private readonly ITmdbAdapter tmdbAdapter;
        private readonly ApplicationConfiguration configuration;
        private readonly ILogger logger;

        public FilmesService(ITmdbAdapter tmdbAdapter, ApplicationConfiguration
            configuration, ILoggerFactory loggerFactory)
        {
            this.tmdbAdapter = tmdbAdapter ??
                throw new ArgumentNullException(nameof(tmdbAdapter));

            this.configuration = configuration ??
                throw new ArgumentNullException(nameof(configuration));

            logger = loggerFactory?.CreateLogger<FilmesService>() ??
                throw new ArgumentNullException(nameof(loggerFactory));
        }

        public async Task<IEnumerable<Filme>> ObterFilmesAsync(
            Pesquisa pesquisa)
        {
            ValidationHelper.ThrowValidationExceptionIfNotValid(pesquisa);

            logger.LogInformation("Realizando chamada ao TMDb com os seguintes " +
                "criterios de pesquisa: {@CriteriosPesquisa}",
                new { Criterios = pesquisa, configuration.Idioma });

            IEnumerable<Filme> resultado = await tmdbAdapter
                .GetFilmesAsync(pesquisa, configuration.Idioma);

            logger.LogInformation("Chamada ao TMDb concluida com sucesso.");

            return resultado;
        }

        public async Task<IEnumerable<Pessoa>> ObterFilmesPorPessoaAsync(
        PesquisaPorPessoa pesquisa)
        {
          ValidationHelper.ThrowValidationExceptionIfNotValid(pesquisa);

          logger.LogInformation("Realizando chamada ao TMDb com os seguintes " +
              "criterios de pesquisa: {@CriteriosPesquisa}",
              new { Criterios = pesquisa, configuration.Idioma });

          IEnumerable<Pessoa> resultado = await tmdbAdapter
              .GetFilmesPorPessoaAsync(pesquisa, configuration.Idioma);

          logger.LogInformation("Chamada ao TMDb concluida com sucesso.");

          return resultado;
        }
    }
}
