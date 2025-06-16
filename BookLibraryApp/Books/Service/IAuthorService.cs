using BookLibraryApp.Books.Dto;
using BookLibraryApp.Books.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryApp.Books.Service
{
    public interface IAuthorService
    {
        Author GetAuthorById(int id);
        List<Author> GetAllAuthors();
        Task<Author> AddNewAuthor(AuthorDto authorDto);
        Task<Author> UpdateAuthor(int id, AuthorDto authorDto);
        void DeleteAuthor(int id);
    }
}
