Console.Write("Введите число: ");
int rand= int.Parse(Console.ReadLine());
if (rand>=100 && rand<=999)
{
    Function(rand);
    void Function(int a)
    {
        int b=a%100;
        int c=b/10;
        Console.WriteLine(c);
    }
}
else if(rand>999)
{
    FunctionTwo(rand);
    void FunctionTwo(int a)
    {
        while (a>999)
        {
            a=a/10;
        }
        Console.WriteLine(a%10);
    }
}
else
{
    Console.WriteLine("Третьей цифры нет");
}