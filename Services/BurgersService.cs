using System;
using System.Collections.Generic;
// using burgershop.db;
using burgershop.Models;
using burgershop.Repositories;


namespace burgershop.Services
{
  public class BurgersService
  {


    private readonly BurgersRepository _repo;

    public BurgersService(BurgersRepository repo)
    {
      _repo = repo;
    }




    // Get All

    internal IEnumerable<Burger> getAllBurgers()
    {
      return _repo.getAll();
    }
    // Get By ID

    internal Burger getBurgerById(int id)
    {
      Burger burgerToGet = _repo.getById(id);
      if (burgerToGet == null)
      {
        throw new Exception("Invalid Id");
      }
      return burgerToGet;
    }

    // // Create

    internal Burger createBurger(Burger newBurger)
    {
      return _repo.Create(newBurger);
    }

    // // Edit

    internal Burger editBurger(Burger updatedBurger)
    {
      Burger original = getBurgerById(updatedBurger.Id);

      original.Name = updatedBurger.Name != null ? updatedBurger.Name : original.Name;
      original.Description = updatedBurger.Description != null ? updatedBurger.Description : original.Description;
      original.Price = updatedBurger.Price > 0 ? updatedBurger.Price : original.Price;

      return _repo.editBurger(original);
    }

    // // Delete

    // public string deleteBurger(string burgerId)
    // {
    //   Burger burgerToDelete = FakeDB.Burgers.Find(b => b.Id == burgerId);
    //   if (burgerToDelete == null)
    //   {
    //     throw new Exception("Invalid Id");
    //   }
    //   FakeDB.Burgers.Remove(burgerToDelete);
    //   return "Burger Menu Item Successfully Delorted";
    // }

  }
}