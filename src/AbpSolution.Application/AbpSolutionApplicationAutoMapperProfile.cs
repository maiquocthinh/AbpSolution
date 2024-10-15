using AbpSolution.Authors;
using AbpSolution.Books;
using AutoMapper;

namespace AbpSolution;

public class AbpSolutionApplicationAutoMapperProfile : Profile
{
    public AbpSolutionApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();

        CreateMap<Author, AuthorDto>();
        CreateMap<Author, AuthorLookupDto>();
    }
}
