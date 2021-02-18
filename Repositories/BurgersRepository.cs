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
    internal Burger getById(int burgerId)
    {
      string sql = "SELECT * FROM burgers WHERE id = @burgerId;";
      return _db.QueryFirstOrDefault<Burger>(sql, new { burgerId });
    }


    // Create
    internal Burger Create(Burger newBurger)
    {
      string sql = @"
            INSERT INTO burgers
            (name, description, price)
            VALUES
            (@Name, @Description, @Price);
            SELECT LAST_INSERT_ID();";
      int id = _db.ExecuteScalar<int>(sql, newBurger);
      newBurger.Id = id;
      return newBurger;

    }


    // Edit
    internal Burger editBurger(Burger original)
    {
      string sql = @"
        UPDATE burgers
        SET
          name = @Name,
          description = @Description,
          price = @Price
        WHERE id = @Id;
        SELECT * FROM burgers WHERE id = @Id;";
      return _db.QueryFirstOrDefault<Burger>(sql, original);
    }


    // Delete
    internal void deleteBurger(Burger burger)
    {
      string sql = "DELETE FROM burgers WHERE id =@Id";
      _db.Execute(sql, burger);
    }


  }
}