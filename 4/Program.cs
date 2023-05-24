// See https://aka.ms/new-console-template for more information
// Выводит все четные от одного до N
Console.Clear();
Console.WriteLine("Введите число N");
int Number = int.Parse(Console.ReadLine());
while (Number<=1)
{
    Console.WriteLine("Введите число больше 1");
    Number = int.Parse(Console.ReadLine());
}
for (int i = 1; i < Number + 1;i++){
     if (i%2==0)
     {
        Console.Write($"{i} ");
     }
}
Console.WriteLine();
