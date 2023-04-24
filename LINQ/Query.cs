//deferred execution lets us define a query once
// and then reuse it later after data changes.

public class Query{
    public void qq(){

        int[] numbers = {5,4,1,3,9,8,6,7,2,0};
        var lowNumbers = from n in numbers      
                         where n <= 3
                          select n;

         Console.WriteLine("First run numbers <= 3:");

         foreach(int n in lowNumbers)
         {
            Console.WriteLine(n);
         }      
         for (int i =0; i < 10; i++)
         {
            numbers[i] = - numbers[i];
         }     

         Console.WriteLine("Second run numbers <= 3:");
         foreach (int n in lowNumbers)
         {
            Console.WriteLine(n);
         }      
    }
}