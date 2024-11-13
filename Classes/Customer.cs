class Customer
{
   public string FirstName;
   public string LastName;

   public Customer(string firstName, string lastName)
   {
        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
    {
        Console.WriteLine("First name and last name cannot be null or empty.");
    }

    FirstName = firstName;
    LastName = lastName;
   }
}