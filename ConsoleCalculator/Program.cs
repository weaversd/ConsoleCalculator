// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a number as input");

int input = int.Parse(Console.ReadLine());

if (input % 3 == 0 && input % 4 == 0)
{
    Console.WriteLine("The input is divisible by 3 and 4");
}
else
{
    Console.WriteLine("The input is not divisible by 3 and 4");
}






for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

int j = 1;
while (j <= 10)
{
    if (j % 2 == 0)
    {
        Console.WriteLine(j);
    }
    j++;
}

int FactorialResult = Factorial(input);
Console.WriteLine(input + " factorial is " + FactorialResult);

static int Factorial(int input)
{
    int result = 1;
    for (int k = 1; k <= input; k++)
    {
        result *= k;
    }
    return result;
}
