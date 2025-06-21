using BookLibraryApp.Domain.DTO;
using BookLibraryApp.Domain.HelperInterfaces;
using BookLibraryApp.Domain.Mappers;
using BookLibraryApp.Domain.Models;
using BookLibraryApp.Infrastructure;
using BookLibraryApp.Logic.CustomExceptions;

namespace BookLibraryApp.Logic.Service.ReaderService
{
    public class ReaderService : IReaderService
    {
        private readonly IMapper<Reader, ReaderDto> _mapper;

        public ReaderService()
        {
            _mapper = new ReaderMapper();
        }
        public async Task<Reader> AddNewReader(ReaderDto readerDto)
        {
            var reader = _mapper.ToDomain(readerDto);
            using (var context = new LibraryAppContext())
            {
                await context.Readers.AddAsync(reader);
                await context.SaveChangesAsync();
            }
            return reader;
        }

        public async void DeleteReader(int id)
        {
            using (var context = new LibraryAppContext())
            {
                var readerToRemove = await context.Readers.FindAsync(id);

                if (readerToRemove is null)
                {
                    throw new NotFoundException($"Читатель с id {id} не найден");
                }

                if (context.RentedBooks.Where(b => b.ReaderId == id).Count() > 0)
                {
                    throw new InvalidOperationException(
                        $"Нельзя удалить читателя {readerToRemove.FirstName} {readerToRemove.LastName}, " +
                        "имеется книга на руках.");
                }

                context.Remove(readerToRemove);
                await context.SaveChangesAsync();
            }
        }

        // Обновление данных читателя
        public async Task<Reader> UpdateReader(int id, ReaderDto readerDto)
        {
            using (var context = new LibraryAppContext())
            {
                var readerToUpdate = await context.Readers.FindAsync(id);

                if (readerToUpdate is null)
                {
                    throw new NotFoundException($"Читатель с id {id} не найден");
                }

                if (!string.IsNullOrEmpty(readerDto.FirstName))
                {
                    readerToUpdate.FirstName = readerDto.FirstName;
                }

                if (!string.IsNullOrEmpty(readerDto.LastName))
                {
                    readerToUpdate.LastName = readerDto.LastName;
                }

                await context.SaveChangesAsync();
                return readerToUpdate;
            }
        }

        public Reader GetReaderById(int id)
        {
            using (var context = new LibraryAppContext())
            {
                var reader = context.Readers.FirstOrDefault(b => b.Id == id);
                if (reader is null)
                {
                    throw new NotFoundException($"Читатель с id {id} не найден");
                }
                return reader;
            }
        }

        public List<Reader> GetAllReaders()
        {
            using (var context = new LibraryAppContext())
            {
                return context.Readers.ToList();
            }
        }
    }
}
