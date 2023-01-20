
int a = 2;
int b = 20;
int max = 0;
int min = 0;

if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
Console.WriteLine("Max " + max);
Console.WriteLine("Min " + min);