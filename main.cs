using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main (string[] args) 
  {

    /*Author a1 = new Author("J.K.", "Rowling");
    a1.DisplayInfo();
    //Console.WriteLine(a1);

    Author a2 = new Author("Suzanne", "Collins");
    a2.DisplayInfo();
    //Console.WriteLine(a2);

    Book b1 = new Book("489325934", "Harry Potter Book 1", a1);
    //b1.Display();

    Book b2 = new Book("2379325125", "Hunger Games Book 1", a2);
    //b2.Display();

    Book b3 = new Book("4928517456", "Harry Potter Book 2", a1);
    //b3.Display();

    Book b4 = new Book("09328504052", "Hunger Games Book 2", a2, Convert.ToDateTime("09/01/2009"), "Scholastic Press");
    //b4.Display();

    Book b5 = new Book("49101085739", "Harry Potter Book 3", a1, Convert.ToDateTime("07/08/1999"), "Bloomsbury");
    //b5.Display();

    Book b6 = new Book("40751257423", "Hunger Games Book 3", a2, Convert.ToDateTime("08/24/2010"), "Scholastic Press");
    //b6.Display();

    a1.AddBook(b1);
    a1.AddBook(b3);
    a1.AddBook(b5);
    a1.DisplayBooks();
    a2.AddBook(b2);
    a2.AddBook(b4);
    a2.AddBook(b6);
    a2.DisplayBooks();
    a1.RemoveBook("489325934");
    a1.DisplayBooks();*/

    Patron p1 = new Patron("Katie", "Smith", "40198515");
    p1.Display();
    Patron p2 = new Patron("John", "Jones", "24892384");
    p2.Display();
    Patron p3 = new Patron("Betty", "Smith", "09885682");
    p3.Display();
    Patron p4 = new Patron("Bob", "Wilson", "05039264");
    p4.Display();
    Patron p5 = new Patron("Will", "Smith", "09846326");
    p5.Display();

    
    
    
  }
}
