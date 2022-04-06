using System;
using System.Collections.Generic;
using gregs_list_two_sharp.Models;
using gregs_list_two_sharp.Repositories;

namespace gregs_list_two_sharp.Services
{
  public class CarsService
  {
    private readonly CarsRepository _repo;

    public CarsService(CarsRepository repo)
    {
      _repo = repo;
    }
    internal List<Car> Get()
    {
      return _repo.Get();
    }

    internal Car Create(Car newCar)
    {
      return _repo.Create(newCar);
    }

    internal Car Get(int id)
    {
      Car found = _repo.Get(id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

    internal Car Update(Car updatedCar)
    {
      Car original = Get(updatedCar.Id);
      original.Make = updatedCar.Make ?? original.Make;
      original.Model = updatedCar.Model ?? original.Model;
      original.Year = updatedCar.Year;
      original.Color = updatedCar.Color ?? original.Color;
      _repo.Update(original);
      return original;
    }

    internal void Delete(int id)
    {
      Get(id);
      _repo.Delete(id);
    }
  }
}