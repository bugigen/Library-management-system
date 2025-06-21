using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryApp.Domain.DTO
{
    public class ReaderDto
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public ReaderDto(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("Имя не может быть пустым.", nameof(firstName));
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Фамилия не может быть пустой.", nameof(lastName));

            FirstName = firstName;
            LastName = lastName;
        }

    }
}
