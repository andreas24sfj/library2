class Library
{
  // Data felt
  private List<Book> books;

  // Konstruktøren
  public Library()
  {
    books = new List<Book>();
  }

  // Metoder, ting vi kan gjøre med objektet
  public void AddNewBook(Book newBook)
  {
    books.Add(newBook);
  }

  public List<Book> ListAvailableBooks()
  {
    return books;
  }

  public Book? LendBook(string title)
  {
    Book? book = books.Find((book) =>
    {
      if (book.Title == title)
      {
        return true;
      }
      else
      {
        return false;
      }
    });

    return book;
  }
}