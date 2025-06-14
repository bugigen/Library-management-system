using BookLibraryApp.Books.Dto;
using BookLibraryApp.Books.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryApp.Books.Service
{
    public interface IGenreService
    {
        Genre GetGenreById(int id);
        List<Genre> GetAllGenres();
        void DeleteGenre(int id);
        Genre AddNewGenre(GenreDto genreDto);
    }
}
