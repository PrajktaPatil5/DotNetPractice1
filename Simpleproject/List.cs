public class List{
    public void xx(){
        List<string>  names = new List<string> { "Praju", "Anita", "Ashok" };
foreach (string name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}

//List<string> names = new List<string> ();
names.Add("Pragati");
names.Add("Shubhu");
names.Remove("Ashok");
foreach (string name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine($"My name is {names[0]}.");
Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

Console.WriteLine($"The list has {names.Count} people in it");

var index = names.IndexOf("Praju");
 Console.WriteLine($"Found Praju at {index} index");

//var index = names.IndexOf("Praju");
if (index != 1)
{
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
  
}
else{
Console.WriteLine($"The name {names[index]} is at index {index}");
}
    }
}