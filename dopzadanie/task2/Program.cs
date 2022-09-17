

// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все
//целые числа в промежутке от -N до N.
Console.Write("Введит N");
int N=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"целые числа в диапозоне от {-N} до {N} ");

for (int i = -N; i <= N; i=i+1)
             
Console.Write($"{i} ");



             

            