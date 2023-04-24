Console.Write("Введите число: ");
int rand= int.Parse(Console.ReadLine());
if (rand>=1 && rand<=5)
{
    Function(rand);
}
else if(rand>=6 && rand<=7)
{
    FunctionTwo(rand);
}
else
{
    Console.WriteLine("Вы ввели некорректное число");
}
void Function(int a)
    {
        Console.WriteLine("Нет");
    }
void FunctionTwo(int a)
{
    Console.WriteLine("Да");
}