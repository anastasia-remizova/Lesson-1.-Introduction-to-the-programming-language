Console.WriteLine("Введи 2 числа");
 int a, b;
 Console.WriteLine("Введи число ");
 a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введи число ");
 b = Convert.ToInt32(Console.ReadLine());
 bool c = a > b;
 if (c)
 { Console.WriteLine($"Число {a} больше чем {b}");}

 else
{ Console.WriteLine($"Число {b} больше чем {a}");}



int a;                             
Console.Write("введите число: ");
a= Console.Read();
 if (a % 2==1)
{
Console.WriteLine("число нечетное");}
else
{
Console.WriteLine("Число четное");}
