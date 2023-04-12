namespace DenverLibrary.Testing
{
    public class LibraryTests
    {
        [Fact]
        public void Constructor_SetsNameAndEmptyBranchList()
        {
            var library = new Library("name");
            Assert.Equal("name", library.Name);
            Assert.Equal(new List<Branch>(), library.Branches);
        }
        [Fact]
        public void AddBranch_AddsABranchToBranchsList()
        {
            var library = new Library("name");
            var branch1 = new Branch("name1");
            var branch2 = new Branch("name2");
            var branch3 = new Branch("name3");
            var l = new List<Branch>
            {
                branch1,
                branch2,
                branch3
            };

            library.AddBranch(branch1);
            library.AddBranch(branch2);
            library.AddBranch(branch3);
            Assert.Equal(l, library.Branches);
            Assert.Equal(3, library.Branches.Count());
        }
        [Fact]
        public void BranchNames_ListsAllBranchNames()
        {
            var library = new Library("name");
            var branch1 = new Branch("name1");
            var branch2 = new Branch("name2");
            var branch3 = new Branch("name3");
            var l = new List<string>
            {
                "name1",
                "name2",
                "name3"
            };
            library.AddBranch(branch1);
            library.AddBranch(branch2);
            library.AddBranch(branch3);
            Assert.Equal(l, library.BranchNames());
        }
        [Fact]
        public void AllBooks_ReturnsListOfAllBookTitles()
        {
            var library = new Library("name");
            var branch1 = new Branch("name1");
            var branch2 = new Branch("name2");
            var branch3 = new Branch("name3");
            var book1 = new Book("title1", "author1");
            var book2 = new Book("title2", "author2");
            var book3 = new Book("title3", "author3");
            var book4 = new Book("title4", "author4");
            var book5 = new Book("title5", "author5");
            var book6 = new Book("title6", "author6");
            branch1.AddBook(book1);
            branch1.AddBook(book2);
            branch2.AddBook(book3);
            branch2.AddBook(book4);
            branch3.AddBook(book5);
            branch3.AddBook(book6);
            library.AddBranch(branch1);
            library.AddBranch(branch2);
            library.AddBranch(branch3);
            var l = new List<string>
            {
                "title1",
                "title2",
                "title3",
                "title4",
                "title5",
                "title6"
            };
            Assert.Equal(l, library.AllBooks());
        }
    }
}