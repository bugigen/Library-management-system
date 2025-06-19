using BookLibraryApp.Books.Dto;
using BookLibraryApp.Books.Mapper;
using BookLibraryApp.Books.Models;
using BookLibraryApp.CustomExceptions;
using BookLibraryApp.DataBase;
using BookLibraryApp.HelperInterfaces;

namespace BookLibraryApp.Books.Service
{
    public class BookService : IBookService
    {
        private readonly BookAppContext _context;
        private readonly IMapper<Book, BookDto> _mapper;

        public BookService(BookAppContext context)
        {
            _context = context;
            _mapper = new BookMapper();
        }
        public async Task<Book> AddBook(BookDto dto)
        {
            Book book = _mapper.ToDomain(dto);
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async void DeleteBook(int id)
        {
            var book = GetBookById(id);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }

        public Book GetBookById(int id)
        {
            Book book = _context.Books.FirstOrDefault(x => x.Id.Equals(id));
            if (book == null)
            {
                throw new NotFoundException($"Книга с id {id} не найдена");
            }
            return book;
        }

        public List<Book> GetBooks()
        {
            return _context.Books.ToList();
        }

        public async Task<Book> ReturnBookFromRent(int id)
        {
            var book = GetBookById(id);
            book.IsAlreadyTaken = true;
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<Book> TakeBookToRent(int id)
        {
            var book = GetBookById(id);
            if (book.IsAlreadyTaken)
            {
                throw new AlreadyRentedException();
            }
            book.IsAlreadyTaken = true;
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<Book> UpdateBook(int id, BookDto dto)
        {
            var book = GetBookById(id);
            book.Name = dto.Name;
            book.PublishingYear = dto.PublishingYear;
            await _context.SaveChangesAsync();
            return book;
        }
    }
}
