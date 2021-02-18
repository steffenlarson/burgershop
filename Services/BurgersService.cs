using System;
using System.Collections.Generic;
using burgershop.db;
using burgershop.Models;


namespace burgershop.Services
{
  public class BurgersService
  {



    // Get All

    public IEnumerable<Burger> getAllBurgers()
    {
      return FakeDB.Burgers;
    }
    // GetByID

    // Create

    // Edit

    // Delete



  }
}