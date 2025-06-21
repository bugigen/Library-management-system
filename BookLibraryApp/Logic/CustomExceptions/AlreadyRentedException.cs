using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryApp.Logic.CustomExceptions
{
    public class AlreadyRentedException : Exception
    {
        public AlreadyRentedException() : base("Книга уже арендована") { }
    }
}
