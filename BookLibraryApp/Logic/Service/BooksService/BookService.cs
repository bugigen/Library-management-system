using BookLibraryApp.Domain.DTO;
using BookLibraryApp.Domain.HelperInterfaces;
using BookLibraryApp.Domain.Mappers;
using BookLibraryApp.Domain.Models;
using BookLibraryApp.Infrastructure;
using BookLibraryApp.Logic.CustomExceptions;

namespace BookLibraryApp.Logic.Service.BooksService
{
    public class BookService : IBookService
    {
        private readonly IMapper<Book, BookDto> _mapper;

        public BookService()
        {
            _mapper = new BookMapper();
        }
        public async Task<Book> AddBook(BookDto dto)
        {
            var bookDomain = _mapper.ToDomain(dto);
            using (var context = new LibraryAppContext())
            {
                await context.Books.AddAsync(bookDomain);
                await context.SaveChangesAsync();
            }
            return bookDomain;
        }

        public async void DeleteBook(int id)
        {
            var book = GetBookById(id);
            using (var context = new LibraryAppContext())
            {
                context.Books.Remove(book);
                await context.SaveChangesAsync();
            }
        }

        public Book GetBookById(int id)
        {
            using (var context = new LibraryAppContext())
            {
                Book book = context.Books.FirstOrDefault(x => x.Id.Equals(id));
                if (book == null)
                {
                    throw new NotFoundException($"Книга с id {id} не найдена");
                }
                return book;
            }
        }

        public List<Book> GetBooks()
        {
            using (var context = new LibraryAppContext())
            {
                return context.Books.ToList();
            }
        }

        public async Task<Book> UpdateBook(int id, BookDto dto)
        {
            var book = GetBookById(id);
            using (var context = new LibraryAppContext())
            {
                book.Title = dto.Name;
                book.Year = dto.PublishingYear;
                await context.SaveChangesAsync();
                return book;
            }
        }
    }
}
