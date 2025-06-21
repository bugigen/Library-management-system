using BookLibraryApp.Domain.DTO;
using BookLibraryApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryApp.Logic.Service.ReaderService
{
    public interface IReaderService
    {
        Reader GetReaderById(int id);
        List<Reader> GetAllReaders();
        Task<Reader> AddNewReader(ReaderDto reader);
        Task<Reader> UpdateReader(int id, ReaderDto readerDto);
        void DeleteReader(int id);
    }
}
