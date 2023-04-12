namespace DenverLibrary.Testing
{
    public class BranchTests
    {
        [Fact]
        public void Constructor_SetsNameAndBooksAsEmptyList()
        {
            var branch = new Branch("name");
            Assert.Equal("name", branch.Name);
            Assert.Equal(new List<Book>(), branch.Books);
        }
        [Fact]
        public void AddBook_AddsABookToBooksList()
        {
            var branch = new Branch("name");
            var book1 = new Book("title1", "author1");
            var book2 = new Book("title2", "author2");
            var book3 = new Book("title3", "author3");
            var l = new List<Book>
            {
                book1,
                book2,
                book3
            };

            branch.AddBook(book1);
            branch.AddBook(book2);
            branch.AddBook(book3);
            Assert.Equal(l, branch.Books);
            Assert.Equal(3, branch.Books.Count());
        }
        [Fact]
        public void AllAuthors_GivesAllAuthors()
        {
            var branch = new Branch("name");
            var book1 = new Book("title1", "author1");
            var book2 = new Book("title2", "author2");
            var book3 = new Book("title3", "author3");
            branch.AddBook(book1);
            branch.AddBook(book2);
            branch.AddBook(book3);
            var l = new List<string>
            {
                "author1",
                "author2",
                "author3"
            };
            Assert.Equal(l, branch.AllAuthors());
        }
    }
}