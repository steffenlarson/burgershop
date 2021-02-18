using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using burgershop.Services;
using burgershop.Models;



namespace burgershop.Controllers
{

  [ApiController]
  [Route("api/[controller]")]


  public class BurgersController : ControllerBase
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

    // // Get By Id
    [HttpGet("{burgerId}")]
    public ActionResult<Burger> getBurgerById(int burgerId)
    {
      try
      {
        Burger burgerToGet = _bs.getBurgerById(burgerId);
        return Ok(burgerToGet);
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }
    // // Post

    [HttpPost]
    public ActionResult<Burger> Create([FromBody] Burger newBurger)
    {
      try
      {
        Burger burgerToMake = _bs.createBurger(newBurger);
        return Ok(burgerToMake);
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }


    // // Put

    [HttpPut("{burgerId}")]
    public ActionResult<Burger> editBurger([FromBody] Burger updatedBurger, int burgerId)
    {
      try
      {
        updatedBurger.Id = burgerId;
        Burger burgerToEdit = _bs.editBurger(updatedBurger);
        return Ok(burgerToEdit);
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }

    // // Delete

    [HttpDelete("{burgerId}")]
    public ActionResult<String> deleteBurger(int burgerId)
    {
      try
      {
        _bs.deleteBurger(burgerId);
        return Ok("Burger Posting Successfully Delorted");
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }


  }
}


// I LOVE YOU KYRSTEN :)