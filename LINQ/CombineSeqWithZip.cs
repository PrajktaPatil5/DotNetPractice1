// Zip - To calculate dot product passing its lambda function to multiple two arrays elements by elements & sum the result

public class CombineSeqWithZip{
    public void cc(){
        int[] vectorA = {0,2,4,5,6};
        int[] vectorB = {1,3,5,7,8};

        int dotProduct = vectorA.Zip(vectorB, (a, b) => a * b).Sum();
        Console.WriteLine($"Dot products: {dotProduct}");
    }
}