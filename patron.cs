using System;
using System.Collections.Generic;
using System.Linq;

class Patron : Person
{
  public string LibraryId { get; set; }
  public DateTime StartDate { get; set; }
  public DateTime EndDate { get; set; }
  public bool IsAccountActive { get; set; }
  private List<Rental> RentalCart = new List<Rental>();
  public int FineAmountDue { get; set; }

  public Patron(string fname, string lname, string libraryid) : base(fname, lname)
  {
    LibraryId = libraryid;
    FineAmountDue = 0;
    StartDate = DateTime.Today;
    IsAccountActive = true;
  }

  public void Display()
  {
    Console.WriteLine("Patron ID = " + LibraryId + " Name = " + FirstName + " " + LastName);
  }

  public void AddToRentalCart(Rental livre, DateTime input)
  {
    RentalCart.Add(livre);
    Console.WriteLine("Added to rental cart " + livre + " for patron " + FirstName + " " + LastName);
  }

  public void RemoveFromRentalCart(Rental livre)
  {
    RentalCart.Remove(livre);
    Console.WriteLine(livre + " has been removed for patron " + FirstName + " " + LastName);
  }
}