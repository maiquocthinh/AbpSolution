using AbpSolution.Authors;
using AbpSolution.Books;
using AutoMapper;


namespace AbpSolution.Blazor.Client;

public class AbpSolutionBlazorAutoMapperProfile : Profile
{
    public AbpSolutionBlazorAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();

        CreateMap<AuthorDto, UpdateAuthorDto>();
    }
}