// Задача 2

Console.WriteLine("Введите numberA: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите numberB: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
    {
    Console.WriteLine($"max {numberA} min {numberB}");   
    }
else {
    Console.WriteLine($"max {numberB} min {numberA}");   
}

