namespace BookLibraryApp.Domain.HelperInterfaces
{
    public interface IMapper<Domain, Dto> where Domain : class where Dto : class
    {
        Dto ToDto(Domain domain);
        Domain ToDomain(Dto dto);
    }
}
