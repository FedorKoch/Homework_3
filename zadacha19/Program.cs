Console.Clear();
int pal = 0;
int b = 0;
Console.WriteLine("введите a");
int a = int.Parse(Console.ReadLine());
b = a;
while (a > 0)
{
pal = (pal * 10) + (a % 10);
a = a / 10;
}
if ( b == pal)
 Console.WriteLine("палиндром"); 
 else 
  Console.WriteLine("не палиндром"); 