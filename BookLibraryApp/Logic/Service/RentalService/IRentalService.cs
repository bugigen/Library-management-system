using BookLibraryApp.Domain.Models;

namespace BookLibraryApp.Logic.Service.RentalService
{
    public interface IRentalService
    {
        Task<RentedBook> RentBook(int bookId, int readerId);
        Task<RentedBook> ReturnBook(int bookId, int readerId);
        List<RentedBook> GetAllRents();
    }
}
