using System.Collections.Generic;
using burgershop.Models;

namespace burgershop.db
{
  public class FakeDB
  {
    public static List<Burger> Burgers { get; set; } = new List<Burger>();
  }
}