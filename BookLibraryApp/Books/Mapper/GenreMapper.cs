using BookLibraryApp.Books.Dto;
using BookLibraryApp.Books.Models;
using BookLibraryApp.HelperInterfaces;

namespace BookLibraryApp.Books.Mapper
{
    public class GenreMapper : IMapper<Genre, GenreDto>
    {
        public Genre ToDomain(GenreDto dto)
        {
            return new Genre(dto.Name);
        }

        public GenreDto ToDto(Genre domain)
        {
            throw new NotImplementedException();
        }
    }
}
