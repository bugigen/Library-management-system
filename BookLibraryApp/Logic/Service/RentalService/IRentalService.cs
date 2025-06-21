using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryApp.Logic.Service.RentalService
{
    public interface IRentalService
    {
        Task RentBook(int bookId, int readerId);
        Task ReturnBook(int bookId, int readerId);
    }
}
