using System;
using System.ComponentModel.DataAnnotations;

namespace burgershop.Models
{
  public class Burger
  {


    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    // public array Toppings { get; set; }


    public int Id { get; set; }


  }
}