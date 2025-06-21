namespace BookLibraryApp.Logic.CustomExceptions
{
    public class AlreadyRentedException : Exception
    {
        public AlreadyRentedException() : base("Книга уже арендована") { }
    }
}
