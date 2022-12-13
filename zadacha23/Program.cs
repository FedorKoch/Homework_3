Console.Clear();
int b = 0;
Console.WriteLine("введите a");
int a = int.Parse(Console.ReadLine());
for (int i = 1; i <= a; i++)
{
    b = i * i * i;
Console.WriteLine(b); 
}