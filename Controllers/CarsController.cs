using Microsoft.AspNetCore.Mvc;
using gregs_list_two_sharp.Services;
using gregs_list_two_sharp.Models;
using System;
using System.Collections.Generic;

namespace gregs_list_two_sharp.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CarsController : ControllerBase
  {
    private readonly CarsService _cs;

    public CarsController(CarsService cs)
    {
      _cs = cs;
    }

    [HttpGet]
    public ActionResult<List<Car>> Get()
    {
      try
      {
        List<Car> cars = _cs.Get();
        return Ok(cars);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]

    public ActionResult<Car> Get(int id)
    {
      try
      {
        Car car = _cs.Get(id);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]

    public ActionResult<Car> Create([FromBody] Car newCar)
    {
      try
      {
        Car car = _cs.Create(newCar);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]

    public ActionResult<Car> Update(int id, [FromBody] Car updatedCar)
    {
      try
      {
        updatedCar.Id = id;
        Car car = _cs.Update(updatedCar);
        return Ok(car);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]

    public ActionResult<String> Delete(int id)
    {
      try
      {
        _cs.Delete(id);
        return Ok("Deleted");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}
