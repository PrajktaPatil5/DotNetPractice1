// number is hit that is not less than 6 TakeWhile syntax

public class TakeWhileLess{
    public void tt(){
        int[] numbers = {5,4,1,3,9,8,6,7,2,0};

        var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);
        Console.WriteLine("First numbers less than 6:");
        foreach( var num in firstNumbersLessThan6)
        {
            Console.WriteLine(num);
        }
    }
}