int[] numbers = new int [10];
int[] even = new int [10];
int[] odd = new int [10];

Console.WriteLine("Digite 10 números inteiros:");
//eu acho que é assim que começa a leitura dos numeros.
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Convert.ToInt32(
        Console.ReadLine()
    );
    if (numbers[i] % 2 == 0)
    {
        even[i] = numbers[i];
    }
    else
    {
        odd[i] = numbers [i];
    }
    
}

for(int i = 0; i < even.Length; i++)

{
    if(even[i]!= 1){
        Console.WriteLine("Números pares digitados:" + even[i] );
    }
    else
    {
        Console.WriteLine("Não foram digitados números pares.");
    }
}

for(int i = 0; i < odd.Length; i++)
{
    if(odd[i]!= 0){
        Console.WriteLine("Números ímpares digitados:" + odd[i] );
    }
    else
    {
        Console.WriteLine("Não foram digitados números ímpares.");
    }
}