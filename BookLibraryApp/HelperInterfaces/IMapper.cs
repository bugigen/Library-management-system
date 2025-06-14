using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryApp.HelperInterfaces
{
    public interface IMapper<Domain, Dto> where Domain : class where Dto : class
    {
        Dto ToDto(Domain domain);
        Domain ToDomain(Dto dto);
    }
}
