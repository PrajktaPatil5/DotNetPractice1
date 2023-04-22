public class Greter
{
    public string pp(int a, int b, int c)
    {

         if ((a + b + c > 10) && (a == b))
             return("The answer is greater than 10 \nThe answer is not greater than 10");
         else if (a == b)
             return("the first number is equal to the second");
            //  return("Or the first number is equal to the second");
         else if((a + b + c > 10))
             return("And the first number is not equal to the second");
        else 
            return("And the first number is not equal to the second");

    }
}