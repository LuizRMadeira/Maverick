using AutoMapper;
using MaverickNovo.Domain.Models;
using MaverickNovo.TmdbAdapter.Clients;

namespace MaverickNovo.TmdbAdapter
{
    public class TmdbMapperProfile : Profile
    {
        public TmdbMapperProfile()
        {
            CreateMap<TmdbSearchMoviesGetResult.ResultItem, Filme>()
                // Mapeia a propriedade TmdbMovieResult.Overview para
                // Filme.Descricao.
                .ForMember(destino => destino.Descricao,
                    opt => opt.MapFrom(origem => origem.Overview))

                // TmdbMovieResult.Title -> Filme.Nome
                .ForMember(destino => destino.Nome,
                    opt => opt.MapFrom(origem => origem.Title))

                // TmdbMovieResult.Name -> Filme.Serie
                .ForMember(destino => destino.Serie,
                    opt => opt.MapFrom(origem => origem.Name))

                // TmdbMovieResult.ReleaseDate -> Filme.DataLancamento
                .ForMember(destino => destino.DataLancamento,
                    opt => opt.MapFrom(origem => origem.ReleaseDate));

            CreateMap<Pesquisa, TmdbSearchMoviesGet>()
                // Pesquisa.TermoPesquisa -> TmdbSearchMoviesGet.Query
                .ForMember(destino => destino.Query,
                    opt => opt.MapFrom(origem => origem.TermoPesquisa))

                // Pesquisa.AnoLancamento -> TmdbSearchMoviesGet.Year
                .ForMember(destino => destino.Year,
                    opt => opt.MapFrom(origem => origem.AnoLancamento));





            CreateMap<TmdbSearchPersonsGetResult.ResultItem, Pessoa>()
                // Mapeia a propriedade TmdbPersonResult.Name para
                // Pessoa.Nome.
                .ForMember(destino => destino.Nome,
                    opt => opt.MapFrom(origem => origem.Name))

                // TmdbPersonResult.KnownForDepartment -> Pessoa.Departamento
                .ForMember(destino => destino.Departamento,
                    opt => opt.MapFrom(origem => origem.KnownForDepartment))

                // TmdbPersonResult.Movies -> Filme.Filmes
                .ForMember(destino => destino.Filmes,
                    opt => opt.MapFrom(origem => origem.Movies));


            CreateMap<TmdbSearchPersonsGetResult.MoviesItem, Filme>()
                // Mapeia a propriedade MoviesItem.Overview para
                // Filme.Descricao.
                .ForMember(destino => destino.Descricao,
                    opt => opt.MapFrom(origem => origem.Overview))

                // MoviesItem.Title -> Filme.Nome
                .ForMember(destino => destino.Nome,
                    opt => opt.MapFrom(origem => origem.Title))

                // MoviesItem.Name -> Filme.Serie
                .ForMember(destino => destino.Serie,
                    opt => opt.MapFrom(origem => origem.Name))

                // MoviesItem.ReleaseDate -> Filme.DataLancamento
                .ForMember(destino => destino.DataLancamento,
                    opt => opt.MapFrom(origem => origem.ReleaseDate));

            CreateMap<PesquisaPorPessoa, TmdbSearchPersonsGet>()
                // PesquisaPorPessoa.TermoPesquisa -> TmdbSearchPersosGet.Query
                .ForMember(destino => destino.Query,
                    opt => opt.MapFrom(origem => origem.TermoPesquisa));

        }
    }
}
