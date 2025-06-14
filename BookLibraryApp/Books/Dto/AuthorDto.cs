using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryApp.Books.Dto
{
    public class AuthorDto
    {
        private string name;
        private int birthYear;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Имя автора не может быть пустым");
                }
                name = value;
            }
        }

        public int BirthYear
        {
            get { return birthYear; }
            set
            {
                if(value < -2600 ||  value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Невалидный год рождения автора");
                }
                birthYear = value;
            }
        }

        public AuthorDto(string name, int birthYear)
        {
            Name = name;
            BirthYear = birthYear;
        }
    }
}
