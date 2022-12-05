Console.WriteLine("введите любое число ");
int N = Convert.ToInt32(Console.ReadLine());

if ((N % 7) == 0 )
{
    if ((N % 23) == 0 )
    {
        Console.WriteLine("да");
    }
    else
    { 
    Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("нет");
}
