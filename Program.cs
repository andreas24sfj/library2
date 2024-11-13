// Sett opp biblioteket
Library library = new Library();

// Lag bøkene
Book martian = new Book("The Martian", "Andy Weir", new DateTime(2011, 2, 11));
Book nineteeneightyfour = new Book("1984", "George Orwell", new DateTime(1949, 6, 8));
Book tokillamockingbird = new Book("To Kill a Mockingbird", "Harper Lee", new DateTime(1960, 7, 11));
Book prideandpred = new Book("Pride and Prejudice", "Jane Austen", new DateTime(1813, 1, 28));
Book catcher = new Book("The Catcher in the Rye", "J.D. Salinger", new DateTime(1951, 7, 16));
Book gatsby = new Book("The Great Gatsby", "F. Scott Fitzgerald", new DateTime(1925, 4, 10));
Book moby = new Book("Moby Dick", "Herman Melville", new DateTime(1851, 10, 18));
Book warandpeace = new Book("War and Peace", "Leo Tolstoy", new DateTime(1869, 1, 1));
Book odyssey = new Book("The Odyssey", "Homer", new DateTime(1, 1, 1)); //date actually -700
Book ulysses = new Book("Ulysses", "James Joyce", new DateTime(1922, 2, 2));
Book divine = new Book("The Divine Comedy", "Dante Alighieri", new DateTime(1320, 1, 1));
Book hobbit = new Book("The Hobbit", "J.R.R. Tolkien", new DateTime(1937, 9, 21));
Book fahrenheit = new Book("Fahrenheit 451", "Ray Bradbury", new DateTime(1953, 10, 19));
Book janeeyre = new Book("Jane Eyre", "Charlotte Brontë", new DateTime(1847, 10, 16));
Book crimeandp = new Book("Crime and Punishment", "Fyodor Dostoevsky", new DateTime(1866, 1, 1));

// Legg til bøker i biblioteket
library.AddNewBook(martian);
library.AddNewBook(nineteeneightyfour);
library.AddNewBook(tokillamockingbird);
library.AddNewBook(prideandpred);
library.AddNewBook(catcher);
library.AddNewBook(gatsby);
library.AddNewBook(moby);
library.AddNewBook(warandpeace);
library.AddNewBook(odyssey);
library.AddNewBook(ulysses);
library.AddNewBook(divine);
library.AddNewBook(hobbit);
library.AddNewBook(fahrenheit);
library.AddNewBook(janeeyre);
library.AddNewBook(crimeandp);

// Håndter bruker input
bool runProgram = true;
while (runProgram)
{
  // les av bruker input
  Console.WriteLine("---------------------------------------------------------");
  Console.WriteLine("Do you want to (list) available books, (list unavailable) books, (lend) or (return)?");
  Console.WriteLine("---------------------------------------------------------");
  string? userInput = Console.ReadLine();

  // Vi må finne hva bruker skrev inn

  // List ut tilgjengelige bøker
  if (userInput == "list")
  {
    Console.WriteLine("---------------------------------------------------------");
    Console.WriteLine("Here are the list of available books:");
    Console.WriteLine("---------------------------------------------------------");
    List<Book> availableBooks = library.ListAvailableBooks();

    foreach (var book in availableBooks)
    {
      Console.WriteLine(book.Title + "(" + book.FirstPublished.Year + ")" + "  by  " + book.Author);
    }
  }
  //list ut utilgjengelige bøker:
  else if (userInput == "list unavailable")
  {
    Console.WriteLine("---------------------------------------------------------");
    Console.WriteLine("Here are books that are unavailable(already borrowed):");
    Console.WriteLine("---------------------------------------------------------");
    List<Book> unavailableBooks = library.ListUnavailableBooks();
    unavailableBooks.Sort();
    foreach (var book in unavailableBooks)
    {
      Console.WriteLine(book.Title + "(" + book.FirstPublished.Year + ")" + "  by  " + book.Author);
    }
  }
  // For å låne en bok (lend)
  else if (userInput == "lend")
  {
    Console.WriteLine("What is the title of the book you want to lend(remember case sensitivity?");
    string? wantedBookTitle = Console.ReadLine();

    if (wantedBookTitle == null)
    {
      continue; // Start hoved løkken på nytt
    }

    Book? book = library.LendBook(wantedBookTitle);

    // Det kan hende biblioteket ikke hadde boken vår
    if (book == null)
    {
      Console.WriteLine("No book with title found: " + wantedBookTitle);
    }
    else
    {
      Console.WriteLine("Lending book: " + book.Title);
      library.AddToLended(book);
    }
  }
  // For å lever tilbake en bok (return)
  else if (userInput == "return")
  {
    Console.WriteLine("Returning a book.");
    Console.WriteLine("Which book would you like to return?");
    string? returnBookTitle = Console.ReadLine();
    if (returnBookTitle == null)
    {
      continue; // Start hoved løkken på nytt
    }

    Book? lbook = library.ReturnBook(returnBookTitle);
    if (lbook == null)
    {
      Console.WriteLine("No book with that title found, or it is already in the library: " + returnBookTitle);
    }
    else
    {
      Console.WriteLine("Returning book to library: " + lbook.Title);
      library.AddNewBook(lbook);
    }


  }
  // For å avslutte (exit)
  else if (userInput == "exit")
  {
    runProgram = false;
  }
}