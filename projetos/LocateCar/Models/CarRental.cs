namespace LocateCar.Model;

public class CarRental
{
  public long Id { get; set; }

  public DateTime? start { get; set; }

  public DateTime? finish { get; set; }

  public Car Car { get; set; } = null!;

  public Invoice? Invoice { get; set; }

}