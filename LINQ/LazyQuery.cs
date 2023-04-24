// sequence operators from first class queries that 
// are not excuted until you enumerate over them.

public class LazyQuery{
    public void ll(){

        int[] numbers = { 5,4,1,3,9,8,6,7,2,0};
        int i =0;
        var q = from n in numbers
                select ++i;

 // note, the local variable i is not incremwnted               

         foreach(var v in q) 
         {
            Console.WriteLine($"v = {v}, i = {i}");
         }      
    }
}