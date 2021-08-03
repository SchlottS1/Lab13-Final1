using System;
using System.Collections.Generic;
using System.Linq;

class Book 
{
  
  public string ISBN { get; set; }
  public string Title { get; set; }
  public Author AuthorInfo { get; set; }
  public DateTime PublishedOn { get; set; }
  public string PublishedBy { get; set; }

  public Book(string isbn, string title, Author authorinfo) : this(isbn, title, authorinfo, DateTime.Today, "unknown")
  {
    
  }

  public Book(string isbn, string title, Author authorinfo, DateTime publishedon, string publishedby)

  {

    ISBN = isbn;
    Title = title;
    AuthorInfo = authorinfo;
    PublishedOn = publishedon;
    PublishedBy = publishedby;

  }

  public void Display()
  {

    Console.WriteLine("The book '" + Title + "' was written by " + AuthorInfo + " and published on " + PublishedOn.ToString("MM/dd/yyyy") + ". It was published by " + PublishedBy + " and has an ISBN of " + ISBN + ".");

  }

}

