namespace BookLibraryApp.Logic.Service.RentalService
{
    public interface IRentalService
    {
        Task RentBook(int bookId, int readerId);
        Task ReturnBook(int bookId, int readerId);
    }
}
