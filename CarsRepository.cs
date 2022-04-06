using System.Data;
using System.Collections.Generic;
using gregs_list_two_sharp.Models;
using System.Linq;
using Dapper;
using System;

namespace gregs_list_two_sharp.Repositories
{
  public class CarsRepository
  {
    private readonly IDbConnection _db;

    public CarsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal List<Car> Get()
    {
      string sql = "SELECT * FROM cars;";
      return _db.Query<Car>(sql).ToList();
    }

    internal Car Create(Car newCar)
    {
      string sql = @"
      INSERT INTO cars
      (make, model, year, color)
      VALUES
      (@Make, @Model, @Year, @Color);
      SELECT LAST_INSERT_ID();";
      int id = _db.ExecuteScalar<int>(sql, newCar);
      newCar.Id = id;
      return newCar;
    }

    internal Car Get(int id)
    {
      string sql = "SELECT * FROM cars WHERE id = @id";
      return _db.QueryFirstOrDefault<Car>(sql, new { id });
    }

    internal void Update(Car original)
    {
      string sql = @"
      UPDATE cars
      SET
        make = @Make,
        model = @Model,
        year = @Year,
        color = @Color
        WHERE id = @Id;";
      _db.Execute(sql, original);
    }

    internal void Delete(int id)
    {
      string sql = "DELETE FROM cars WHERE id = @id LIMIT 1;";
      _db.Execute(sql, new { id });
    }
  }
}