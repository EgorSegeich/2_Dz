Console.WriteLine("введите любое число ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 99)
{
    string X = Convert.ToString(N);
    Console.WriteLine(X[2]);
}
else
{
   Console.WriteLine("третьей цифры нет"); 
}
