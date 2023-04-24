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
else
{
    Console.WriteLine("Вы ввели не трёхзначное число");
}