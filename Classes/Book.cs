class Book
{
  // Data felt
  public string Title;
  public string Author;
  public DateTime FirstPublished;

  // Hvordan sette verdien i data feltene
  public Book(string title, string author, DateTime firstPublished)
  {
    Title = title;
    Author = author;
    FirstPublished = firstPublished;
  }
}