using Refit;

namespace MaverickNovo.TmdbAdapter.Clients
{
    /// <summary>
    /// Modelo do entrada para a rota /search/movie do TMDb API
    /// (https://developers.themoviedb.org/3/search/search-persons)
    /// <para>
    /// Este modelo representa exatamente os parametros para requisicoes na
    /// rota search/movie API TMDb e
    /// eh utilizado como parametro de entrada para o metodo
    /// <see cref="ITmdbApi.SearchPersons"/>.
    /// </para>
    /// <para>    
    /// Note que esta classe eh interna ao Adaptador, 
    /// os dados serao mapeados a partir de <see cref="Domain.Models.PesquisaPorPessoa" />.
    /// O mapeamento eh feito em <see cref="TmdbAdapter.GetFilmesPorPessoaAsync"/>.
    /// </para>
    /// </summary>
    internal class TmdbSearchPersonsGet
    {
        [AliasAs("query")]
        public string Query { get; set; }
        [AliasAs("api_key")]
        public string ApiKey { get; set; }
        [AliasAs("language")]
        public string Language { get; set; }
    }
}
