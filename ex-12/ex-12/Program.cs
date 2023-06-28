using System.Collections;

ArrayList arrayList = new ArrayList();

arrayList.Add(17);
arrayList.Add("Testing");
arrayList.Add(3.14);
arrayList.Add(false);

Console.WriteLine("This is inside the arraylist:");
foreach (var el in arrayList)
{
    Console.WriteLine(el);
}