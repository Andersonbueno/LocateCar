namespace LocateCar.Model;

public class Invoice
{
  public double BasicPayment { get; set; }
  public double Tax { get; set; }

  public double TotalPayment
  {
    get { return BasicPayment + Tax; }
  }

  // construtor para a EF
  protected Invoice()
  {
  }

  public Invoice(double basicPayment, double tax)
  {
    BasicPayment = basicPayment;
    Tax = tax;
  }

}