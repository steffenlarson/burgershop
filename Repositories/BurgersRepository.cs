using System;
using System.Collections.Generic;
using System.Data;
using burgershop.Models;
using Dapper;


namespace burgershop.Repositories
{
  public class BurgersRepository
  {

    public readonly IDbConnection _db;

    public BurgersRepository(IDbConnection db)
    {
      _db = db;
    }



    // Get
    public IEnumerable<Burger> getAll()
    {
      string sql = "SELECT * FROM burgers;";
      return _db.Query<Burger>(sql);
    }
    // Get By Id

    // Create

    // Edit

    // Delete



  }
}