// Skip elements get all but the first 4 elements 

public class SkipElementsFirstFourElem{
    public void ss(){
        int[] numbers = {5,4,1,3,9,8,6,7,2,0};

        var allButFirst4Numbers = numbers.Skip(4);

        Console.WriteLine("All but first 4 numbers:");
        foreach( var n in allButFirst4Numbers)
        {
            Console.WriteLine(n);
        }
    }
}