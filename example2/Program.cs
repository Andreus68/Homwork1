// Example 4


Console.WriteLine("Введите numberA: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите numberB: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите numberC: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberA > max) max = numberA; 
if (numberB > max) max = numberB; 
if (numberC > max) max = numberC; 
Console.WriteLine($"max {max}");

