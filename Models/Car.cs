using System.ComponentModel.DataAnnotations;

namespace gregs_list_two_sharp.Models
{

  public class Car
  {
    public int Id { get; set; }
    [Required]
    public string Make { get; set; }
    [Required]
    public string Model { get; set; }

    [Required]
    public int? Year { get; set; }

    [Required]

    public string Color { get; set; }








  }

}
