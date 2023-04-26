public class Sample
{
   public static void Main()
   {
       Example e = new Example();
       Thread t = new Thread(new ThreadStart(e.FirstThread));
       t.Start();
       Console.Read();
   }
}
