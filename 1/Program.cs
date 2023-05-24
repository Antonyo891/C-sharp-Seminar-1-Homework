/*See https://aka.ms/new-console-template for more information
// Задача №1 на вход принимаются два числа. Выводит какое число меньше.*/

Console.Clear();
Console.WriteLine("Введите первое число");
int NumberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int NumberB = int.Parse(Console.ReadLine());
if (NumberA > NumberB)
{
    Console.WriteLine($"Число {NumberA} больше числа {NumberB} ");
}
else 
{
   Console.WriteLine($"Число {NumberB} больше числа {NumberA} ");
} 