// Найти максимальное и минимальное - вывести на экран

Console.WriteLine("Enter 1st number: ");
int First = int.Parse(Console.ReadLine());
Console.WriteLine("Enter 2nd number: ");
int Second = int.Parse(Console.ReadLine());

if(First > Second)
{
    Console.WriteLine("Bigger:" + First);
    Console.WriteLine("Smaller: " + Second);
}
else 
{
    Console.WriteLine("Bigger:" + Second);
    Console.WriteLine("Smaller:" + First);
}
