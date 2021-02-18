using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using burgershop.Services;
using burgershop.Models;



namespace burgershop.Controllers
{

  [ApiController]
  [Route("api/[controller]")]


  public class BurgersController
  {

    private readonly BurgersService _bs;
    public BurgersController(BurgersService bs)
    {
      _bs = bs;
    }




    // Get
    [HttpGet]
    public ActionResult<IEnumerable<Burger>> getAllBurgers()
    {
      try
      {
        return Ok(_bs.getAllBurgers());
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }

    // Get By Id

    // Post

    // Put

    // Delete




  }
}