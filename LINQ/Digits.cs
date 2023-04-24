public class Digits{

  public void dd(){
   string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

   var shortDigits = digits.Where((digit, index)=> digit.Length<index);

   Console.WriteLine("short digits:");
   foreach(var d in shortDigits)
   {
    Console.WriteLine($"The word {d} is shorter than its value.");
   }
  }
}