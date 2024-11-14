using System.Reflection.Metadata.Ecma335;

class Library
{
  // Data felt
  private List<Book> books;
  private List<Book> lbooks;
  //private List<Customer> customers;
  // Konstruktøren
  public Library()
  {
    books = new List<Book>();
    lbooks = new List<Book>();
    //customers = new List<Customer>();
  }

  // Metoder, ting vi kan gjøre med objektet
  public void AddNewBook(Book newBook)  // legg til bøker i biblioteket
  {
    books.Add(newBook);
    lbooks.Remove(newBook);
  }

  public void AddToLended(Book returnBook)  // legg til i lånte bøker
  {
    lbooks.Add(returnBook);
    books.Remove(returnBook);
  }

  /*public void AddCustomer(Customer newCustomer)
  {
    customers.Add(newCustomer);
  }*/

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
  // liste alle som har registrert seg:
  /*public List<Customer> ListCustomers()
  {
    return customers;
  }*/
  public Book? LendBook(string title) //låne bøker
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

  public Book? ReturnBook(string returntitle) // levere tilbake bøker
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