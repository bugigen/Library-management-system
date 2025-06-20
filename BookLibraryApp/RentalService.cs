using BookLibraryApp.Books.Models;
using BookLibraryApp.CustomExceptions;
using BookLibraryApp.DataBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApp.Services
{
    public class RentalService
    {
        private readonly BookAppContext _context;

        public RentalService(BookAppContext context)
        {
            _context = context;
        }

        public class RentalInfo
        {
            public int BookId { get; set; }
            public string BookTitle { get; set; }
            public int? ReaderId { get; set; }
            public string ReaderFirstName { get; set; }
            public string ReaderLastName { get; set; }
        }

        // Получаем список текущих аренд
        public async Task<List<RentalInfo>> GetCurrentRentals()
        {
            return await _context.Books
                .Where(b => b.IsAlreadyTaken)
                .Include(b => b.CurrentReader)
                .Select(b => new RentalInfo
                {
                    BookId = b.Id,
                    BookTitle = b.Name,
                    ReaderId = b.CurrentReader.Id,
                    ReaderFirstName = b.CurrentReader.FirstName,
                    ReaderLastName = b.CurrentReader.LastName
                })
                .ToListAsync();
        }

        // Выдать книгу
        public async Task RentBook(int bookId, int readerId)
        {
            var book = await _context.Books.FindAsync(bookId);
            if (book == null)
                throw new NotFoundException($"Книга с id {bookId} не найдена");

            if (book.IsAlreadyTaken)
                throw new AlreadyRentedException();

            var reader = await _context.Readers.FindAsync(readerId);
            if (reader == null)
                throw new NotFoundException($"Читатель с id {readerId} не найден");

            book.IsAlreadyTaken = true;
            book.CurrentReaderId = readerId;
            await _context.SaveChangesAsync();
        }

        // Вернуть книгу
        public async Task ReturnBook(int bookId)
        {
            var book = await _context.Books.FindAsync(bookId);
            if (book == null)
                throw new NotFoundException($"Книга с id {bookId} не найдена");

            if (!book.IsAlreadyTaken)
                throw new InvalidOperationException("Книга уже возвращена");

            book.IsAlreadyTaken = false;
            book.CurrentReaderId = null;
            await _context.SaveChangesAsync();
        }
    }
}