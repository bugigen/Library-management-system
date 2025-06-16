using BookLibraryApp.Books.Dto;
using BookLibraryApp.Books.Mapper;
using BookLibraryApp.Books.Models;
using BookLibraryApp.CustomExceptions;
using BookLibraryApp.DataBase;
using BookLibraryApp.HelperInterfaces;
using System.Threading.Tasks;

namespace BookLibraryApp.Books.Service
{
    public class AuthorService : IAuthorService
    {
        private readonly BookAppContext _context;
        private readonly IMapper<Author, AuthorDto> _mapper;

        public AuthorService(BookAppContext context)
        {
            _context = context;
            _mapper = new AuthorMapper();
        }
        public async Task<Author> AddNewAuthor(AuthorDto authorDto)
        {
            var author = _mapper.ToDomain(authorDto);
            await _context.Authors.AddAsync(author);
            await _context.SaveChangesAsync();
            return author;
        }

        public async void DeleteAuthor(int id)
        {
            var author = GetAuthorById(id);
            _context.Authors.Remove(author);
            await _context.SaveChangesAsync();
        }

        public List<Author> GetAllAuthors()
        {
            return _context.Authors.ToList();
        }

        public Author GetAuthorById(int id)
        {
            var authorFromDb = _context.Authors.Where(a => a.Id.Equals(id)).FirstOrDefault();
            if (authorFromDb is null)
            {
                throw new NotFoundException($"Книга с id {id} не найдена");
            }
            return authorFromDb;
        }

        public async Task<Author> UpdateAuthor(int id, AuthorDto authorDto)
        {
            var authorFromDb = GetAuthorById(id);
            authorFromDb.FullName = authorFromDb.FullName;
            authorFromDb.BirthYear = authorDto.BirthYear;
            await _context.SaveChangesAsync();
            return authorFromDb;
        }
    }
}
