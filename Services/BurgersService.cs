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
    // Get By ID

    public Burger getBurgerById(string id)
    {
      Burger burgerToGet = FakeDB.Burgers.Find(b => b.Id == id);
      if (burgerToGet == null)
      {
        throw new Exception("Invalid Id");
      }
      return burgerToGet;
    }

    // Create

    public Burger createBurger(Burger newBurger)
    {
      FakeDB.Burgers.Add(newBurger);
      return newBurger;
    }

    // Edit

    public Burger editBurger(Burger updatedBurger)
    {
      Burger burgerToUpdate = FakeDB.Burgers.Find(b => b.Id == updatedBurger.Id);
      if (burgerToUpdate == null)
      {
        throw new Exception("Invalid Id");
      }
      FakeDB.Burgers.Remove(burgerToUpdate);
      FakeDB.Burgers.Add(updatedBurger);
      return updatedBurger;
    }

    // Delete

    public string deleteBurger(string burgerId)
    {
      Burger burgerToDelete = FakeDB.Burgers.Find(b => b.Id == burgerId);
      if (burgerToDelete == null)
      {
        throw new Exception("Invalid Id");
      }
      FakeDB.Burgers.Remove(burgerToDelete);
      return "Burger Posting Successfully Delorted";
    }

  }
}