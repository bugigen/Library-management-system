using BookLibraryApp.Domain.DTO;
using BookLibraryApp.Domain.HelperInterfaces;
using BookLibraryApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryApp.Domain.Mappers
{
    public class ReaderMapper : IMapper<Reader, ReaderDto>
    {
        public Reader ToDomain(ReaderDto dto)
        {
            Reader reader = new Reader();
            reader.FirstName = dto.FirstName;
            reader.LastName = dto.LastName;
            return reader;
        }

        public ReaderDto ToDto(Reader domain)
        {
            return new ReaderDto(
                    domain.FirstName,
                    domain.LastName
                );
        }
    }
}
