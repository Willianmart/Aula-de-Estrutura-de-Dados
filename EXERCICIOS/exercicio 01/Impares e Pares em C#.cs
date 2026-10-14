int[] numbers = new int[10];
int[] even = new int[10];
int[] odd = new int[10];
int contEven = 0;
int contOdd = 0;

Console.WriteLine("Digite 10 números inteiros:");

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());

    if (numbers[i] % 2 == 0)
    {
        even[contEven] = numbers[i];
        contEven++;
    }
    else
    {
        odd[contOdd] = numbers[i];
        contOdd++;
    }
}

if (contEven == 0)
{
    Console.WriteLine("Não foram digitados números pares.");
}
else
{
    for (int i = 0; i < contEven; i++)
    {
        Console.WriteLine("Número par digitado: " + even[i]);
    }
}

if (contOdd == 0)
{
    Console.WriteLine("Não foram digitados números ímpares.");
}
else
{
    for (int i = 0; i < contOdd; i++)
    {
        Console.WriteLine("Número ímpar digitado: " + odd[i]);
    }
}  