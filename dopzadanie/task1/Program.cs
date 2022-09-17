
// Напишите программу, которая будет выдавать название дня недели по заданному номеру 
//3 -> Среда
//5 -> Пятница

Console.Write("Введите 3 или 5:  ");
int a=Convert.ToInt32(Console.ReadLine());

if (a==3)
{
   Console.Write($"cреда");
}
if (a==5)
{
   Console.Write($"пятница");
}
else if  (a!=5 & (a!=3))
{
    Console.Write($"Введенное не соответсвует условиям");
}

