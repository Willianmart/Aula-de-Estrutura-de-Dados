Console.WriteLine("Digite uma Palavra");
string word = Console.ReadLine();
string inverted = "";

for (int i = word.Length - 1; i >= 0; i--) /*devo admitir que isso me custou umas horas demorei a usar a logica pra ler a 
lenght como ela deveria ser lida ou melhor dizendo como n -1*/
{
    inverted += word[i];//só pra garantir que eu vou lembrar o += é para comparar duas coisas.
}
if (word == inverted)
{
    Console.WriteLine(word + " é um palíndromo.");
}
else
{
    Console.WriteLine(word + " não é um palíndromo.");
}
