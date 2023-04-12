namespace DenverLibrary.Testing
{
    public class BookTests
    {
        [Fact]
        public void Constructor_SetsTitleAndAuthor()
        {
            var book = new Book("title", "author");
            Assert.Equal("title", book.Title);
            Assert.Equal("author", book.Author);
        }
    }
}