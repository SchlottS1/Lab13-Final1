using System;
using System.Collections.Generic;
using System.Linq;

class Author : Person
{

  private List<Book> BookList = new List<Book>();

  public Author() : base()
  {
    PermanentAddress = new Address();
    //Console.WriteLine("Person constructor" + "1"); 
  }

  public Author(string fname, string lname) : base(fname, lname)
  {
    FirstName = fname;
    LastName = lname;
    PermanentAddress = new Address();
    //Console.WriteLine("Person constructor" + "2");
  }

  public void DisplayInfo()
  {
    Console.WriteLine("First Name: " + FirstName);
    Console.WriteLine("Last Name: " + LastName);
    Console.WriteLine("Email: " + Email);
  }

  public void DisplayBooks()
  {
    Console.WriteLine("List of books for " + FirstName + " " + LastName + ":");
    foreach(Book b in BookList)
    {
      b.Display();
    }
  }
  

  public void AddBook(Book nouveau)
  {
    BookList.Add(nouveau);
    
  }

  public void RemoveBook(string code)
  {
    Book e = BookList.Find(o => o.ISBN == code);
    BookList.Remove(e);
  }

  

}