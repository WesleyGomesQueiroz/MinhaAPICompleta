using AutoMapper;
using DevIO.Api.ViewModels;
using DevIO.Business.Models;

namespace DevIO.Api.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<ProdutoViewModel, Produto>().ReverseMap();

            CreateMap<ProdutoImagemViewModel, Produto>().ReverseMap();

            CreateMap<Produto, ProdutoViewModel>()
                .ForMember(destinationMember: dest => dest.NomeFornecedor, memberOptions: opt => opt.MapFrom(mapExpression: src => src.Fornecedor.Nome));
        }
    }
}
