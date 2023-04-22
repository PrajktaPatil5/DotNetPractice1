
public class SumOfAllInteger{
    public void aa(int sum){
       
for (int number = 1; number < 21; number++)
{
  if (number % 3 == 0)
  {
    sum = sum + number;
  }
}
Console.WriteLine($"The sum is {sum}");

    }
}