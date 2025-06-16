using BookLibraryApp.Books.Dto;
using BookLibraryApp.Books.Mapper;
using BookLibraryApp.Books.Models;
using BookLibraryApp.CustomExceptions;
using BookLibraryApp.DataBase;
using BookLibraryApp.HelperInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryApp.Books.Service
{
    public class GenreService : IGenreService
    {

        private readonly BookAppContext _context;
        private IMapper<Genre, GenreDto> _mapper;

        public GenreService(BookAppContext context)
        {
            _context = context;
            _mapper = new GenreMapper();
        }
        public async Task<Genre> AddNewGenre(GenreDto genreDto)
        {
            var genre = _mapper.ToDomain(genreDto);
            await _context.Genres.AddAsync(genre);
            await _context.SaveChangesAsync();
            return genre;
        }

        public async void DeleteGenre(int id)
        {
            var genre = GetGenreById(id);
            _context.Genres.Remove(genre);
            await _context.SaveChangesAsync();
        }

        public List<Genre> GetAllGenres()
        {
            return _context.Genres.ToList();
        }

        public Genre GetGenreById(int id)
        {
            var genreFromDb = _context.Genres.FirstOrDefault(x => x.Id == id);
            if (genreFromDb == null)
            {
                throw new NotFoundException($"Жанр с id {id} не найден");
            }
            return genreFromDb;
        }
    }
}
