using BookLibraryApp.Books.Dto;
using BookLibraryApp.Books.Models;
using BookLibraryApp.HelperInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryApp.Books.Mapper
{
    public class BookMapper : IMapper<Book, BookDto>
    {
        public Book ToDomain(BookDto dto)
        {
            return new Book
                (
                    dto.Name,
                    dto.PublishingYear,
                    dto.AuthorId,
                    dto.GenreId,
                    false
                );
        }

        public BookDto ToDto(Book domain)
        {
            return new BookDto
                (
                    domain.Name,
                    domain.PublishingYear,
                    domain.AuthorInfoKey,
                    domain.GenreInfoKey
                );
        }
    }
}
