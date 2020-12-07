using AutoMapper;
using MaverickNovo.Domain.Models;
using MaverickNovo.WebApi.Dtos;

namespace MaverickNovo.WebApi
{
    public class WebApiMapperProfile : Profile
    {
        public WebApiMapperProfile()
        {
            CreateMap<Filme, FilmesGetResult>();
            CreateMap<FilmesGet, Pesquisa>();
            CreateMap<Pessoa, PessoaGetResult>();
            CreateMap<PessoaGet, PesquisaPorPessoa>();
        } 
    }
}
