using System;
using System.Collections.Generic;
using System.Linq;

class Rental 
{
  
  public Book Livre { get; set; }
  public DateTime DateRented { get; set; }
  public DateTime DateDue { get; set; }

  public Rental(Book livre, DateTime daterented, DateTime datedue)
{
  Livre = livre;
  DateRented = daterented;
  DateDue = datedue;
}


}

