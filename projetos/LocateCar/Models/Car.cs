using LocateCar.Model.Enums;

namespace LocateCar.Model;

public class Car
{
  public int Ano { get; set; }
  public string? Marca { get; set; }
  public Cor Cor { get; set; }
  public int Kilometragem { get; set; }
  public bool Available { get; set; }
}