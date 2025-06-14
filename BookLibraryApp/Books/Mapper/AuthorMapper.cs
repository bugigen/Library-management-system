using BookLibraryApp.Books.Dto;
using BookLibraryApp.Books.Models;
using BookLibraryApp.HelperInterfaces;
namespace BookLibraryApp.Books.Mapper
{
    public class AuthorMapper : IMapper<Author, AuthorDto> 
    {
        public Author ToDomain(AuthorDto dto)
        {
            return new Author
                (
                    dto.Name,
                    dto.BirthYear
                );
        }

        public AuthorDto ToDto(Author domain)
        {
            return new AuthorDto
                (
                    domain.FullName,
                    domain.BirthYear
                );
        }
    }
}
