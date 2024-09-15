namespace LibraryManagementSystemUAZ.UI.DTOs
{
    internal class BookDTO
    {
        public BookDTO()
        {
        }
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Authors { get; set; }
    }
}