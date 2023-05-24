// See https://aka.ms/new-console-template for more information
//Принимает на ввод три числа и выдает максимальное.

int count = 0, index=0; 
int[] array = new int[3];
while(count<3) 
{
        Console.WriteLine($"Введите число {count+1}");
        array[count] = int.Parse(Console.ReadLine());
        count = count+1;
}
int iMax=0;
while(index<3)
{
    if(array[index]>array[iMax])
    {
        iMax=index;
    }
    index++;
}
Console.WriteLine($"Макимальное число - номер {iMax+1} и равно {array[iMax]} ");

