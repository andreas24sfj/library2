class Library
{
  // Data felt
  private List<Book> books;
  private List<Book> lbooks;

  // Konstruktøren
  public Library()
  {
    books = new List<Book>();
    lbooks = new List<Book>();
  }

  // Metoder, ting vi kan gjøre med objektet
  public void AddNewBook(Book newBook)
  {
    books.Add(newBook);
    lbooks.Remove(newBook);
    books.Sort();
  }

  public void AddToLended(Book returnBook)  // legg til i lånte bøker
  {
    lbooks.Add(returnBook);
    books.Remove(returnBook);
    lbooks.Sort();
  }

  // Lister alle bøkene som er utilgjengelige i library
  public List<Book> ListUnavailableBooks()
  {
    return lbooks;
  }
  // Lister alle bøkene som er tilgjengelige i library
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

  public Book? ReturnBook(string returntitle)
  {
    Book? lbook = lbooks.Find((lbook) =>
    {
      if (lbook.Title == returntitle)
      {
        return true;
      }
      else
      {
        return false;
      }
    });

    return lbook;
  }
}