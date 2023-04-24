public class ElementsLessThan{
    public void ee(){
        List<int> numbers = new List<int>(){5,4,1,3,9,8,7,2,0};
        
        var lowNums = from num in numbers
                      where num < 5
                      select num;
          Console.WriteLine("number < 5:");
          foreach (var x in lowNums)
          {
            Console.WriteLine(x);
          }            
                      
                      
    }
}