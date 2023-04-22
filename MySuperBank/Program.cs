// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public class Program{
  
  public static void Main(string[] args)
  {
    BankAccount b = new BankAccount("Prajkta", 20000);
    Console.WriteLine($"Account  {b.Number} was  created for {b.Owner} with {b.Balance} ");
  }
}
