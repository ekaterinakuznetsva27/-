//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());


if (numberOne > numberTwo)

{
Console.WriteLine(numberOne);
}
if (numberTwo > numberOne)

{
Console.WriteLine(numberTwo);
}


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
 
if(a>b)
{
    if(a>c)
    {
        Console.WriteLine(a);
    }
}
 else if(b>c)
{
    Console.WriteLine(b);
}
else
{
    Console.WriteLine(c);
}


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int d = Convert.ToInt32(Console.ReadLine());
if(d%2 != 0) 
{
    Console.WriteLine("нет");
}
else {
Console.WriteLine("да");
}


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int x=0; x<n; x++)
{
    if (x%2 ==0 && x!=0)
    {
      Console.WriteLine(x);  
    }
}


