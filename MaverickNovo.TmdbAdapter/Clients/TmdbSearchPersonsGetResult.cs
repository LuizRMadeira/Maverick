using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaverickNovo.TmdbAdapter.Clients
{
    /// <summary>
    /// Modelo do retorno para a rota /search/movie do TMDb API
    /// (https://developers.themoviedb.org/3/search/search-persons)
    /// <para>
    /// Este modelo representa exatamente o retorno da rota search/movie API
    /// TMDb e eh o retorno do metodo <see cref="ITmdbApi.SearchPersons"/>.
    /// O Refit implementa a deserializacao do resultado da chamada para esta
    /// estrutura.
    /// </para>
    /// <para>    
    /// Note que esta classe eh interna ao Adaptador, 
    /// os dados serao mapeados para <see cref="Domain.Models.PesquisaPorPessoa" />
    /// para serem expostos.
    /// O mapeamento eh feito em <see cref="TmdbAdapter.GetFilmesPorPessoaAsync"/>.
    /// </para>
    /// </summary>
    internal class TmdbSearchPersonsGetResult
    {

      internal class MoviesItem
      { 
        public long Id { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public string Overview { get; set; }

        [JsonProperty(PropertyName = "release_date")]
        public DateTimeOffset? ReleaseDate { get; set; }
      }

      internal class ResultItem
      {
          public string Name { get; set; }

          [JsonProperty(PropertyName = "Known_for_department")]
          public string KnownForDepartment { get; set; }

         [JsonProperty(PropertyName = "known_for")]
          public IEnumerable<MoviesItem> Movies { get; set; }
        }

        public IEnumerable<ResultItem> Results { get; set; }

    }
}
