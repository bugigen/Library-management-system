using BookLibraryApp.Domain.Models;
using BookLibraryApp.Infrastructure;
using BookLibraryApp.Logic.CustomExceptions;
namespace BookLibraryApp.Logic.Service.RentalService
{
    public class RentalService : IRentalService
    {
        public async Task RentBook(int bookId, int readerId)
        {
            using (var context = new LibraryAppContext())
            {
                var book = await context.Books.FindAsync(bookId);
                if (book == null)
                    throw new NotFoundException($"Книга с id {bookId} не найдена");

                if (book.Status.Equals(Constants.RENTED))
                    throw new AlreadyRentedException();

                var reader = await context.Readers.FindAsync(readerId);
                if (reader == null)
                    throw new NotFoundException($"Читатель с id {readerId} не найден");

                book.Status = Constants.RENTED;

                RentedBook rentedBook = new RentedBook()
                {
                    BookId = bookId,
                    ReaderId = readerId,
                    RentDate = DateTime.Now.ToString(),
                    Status = Constants.STILL_RENTED
                };
                await context.RentedBooks.AddAsync(rentedBook);
                await context.SaveChangesAsync();
            }
        }

        public async Task ReturnBook(int bookId, int readerId)
        {
            using (var context = new LibraryAppContext())
            {
                var book = await context.Books.FindAsync(bookId);
                if (book == null)
                    throw new NotFoundException($"Книга с id {bookId} не найдена");

                if (book.Status.Equals(Constants.NOT_RENTED))
                    throw new InvalidOperationException("Книга уже возвращена");

                book.Status = Constants.NOT_RENTED;

                var rent = context.RentedBooks.Where(x => x.Status.Equals(Constants.STILL_RENTED) && x.ReaderId == readerId && x.BookId == bookId).FirstOrDefault();
                if (rent is null)
                {
                    throw new NotFoundException("Аренды не было, либо она уже завершена!");
                }
                rent.Status = Constants.RENT_FINISHED;

                await context.SaveChangesAsync();
            }
        }
    }
}
