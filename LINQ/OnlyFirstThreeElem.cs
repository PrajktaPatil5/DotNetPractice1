// Take elements get only fist 3 elements
public class OnlyFirstThreeElem{
    public void oo(){

        int[] numbers = {5,4,1,3,9,8,6,7,2,0};
        var first3Numbers = numbers.Take(3);

        Console.WriteLine("first 3 numbers:");
        foreach(var n in first3Numbers)
        {
            Console.WriteLine(n);
        }
    }
}