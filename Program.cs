Console.WriteLine("Введи 2 числа");

 int a, b;
 Console.WriteLine("Введи число ");
 a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введи число ");
 b = Convert.ToInt32(Console.ReadLine());
 bool c = a > b;
 if (c)
 { Console.WriteLine("Первое число больше чем второе");}

 else
{ Console.WriteLine("Второе число  больше чем первое");}



Console.WriteLine("Введи 3 числа");

 int a, b, c ;
 Console.WriteLine("Введи число ");
 a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введи число ");
 b = Convert.ToInt32(Console.ReadLine());
 c = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введи число ");
 bool max = a > b;
 bool max1 = max > c;
 if (max)
 { Console.WriteLine("Первое число самое большое");}

 else if (a < b)
{ Console.WriteLine("Второе число самое большое");}
else 
{ Console.WriteLine("Третье число самое большое");}


int a;                             
Console.Write("введите число: ");
a= Console.Read();
 if (a % 2==1)
{
Console.WriteLine("число нечетное");}
else
{
Console.WriteLine("Число четное");}


