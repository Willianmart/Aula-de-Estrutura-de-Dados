string firstName = "Gabriel";
string lastName = "Otto";
string note = lastName.ToUpper () +
                " " + firstName;

string initials = lastName[0] + " " + firstName[0];

Console.WriteLine("" +initials);

//Formatação de strings
string texto = string.Format( 
    "{0} {1} nascido em {2} ",
    firstName,
    lastName,
     "2008"
);
Console.WriteLine("" + texto);




//C# é uma linguagem filha do C++
//totalmente orientada a objetos
//portanto tudo dentro do C é descendente do tipo object

int age = 24;
object ageBoxing = age;
int ageUnboxing = (int)ageBoxing;



/* 
VETORES UNI-DIMENSIONAIS
Sintaxe: Type[] name
*/
//Declaração sem inicialização//
//Obs: Variavel alocada porem nula
int[] numbers;

//Inicializando o vetor
numbers = new int [5];

//Atribuindo valores ao vetor
numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;
numbers[3] = 40;
numbers[4] = 50;

//é possiel declarar o vetor e ja definir e atribuir
int[] number2 = 
    new int[] { 100, 200, 300};

int[] number3 = {1000, 2000, 3000, 4000};

//Percorrendo o vetor e adicionando 
// valores dinamicamente


Console.WriteLine(
    "Iniciando com Vetores"
    );
    console.WriteLine("informe o tamanho do vetor de inteiros");

int size = CConvert.ToInt32(
    Console.ReadLine()
    );

int[] myArray = new int[size];
int total = 0; //Acumuladora
int counter = 0; //Contadora
for(int i = 0; i< myArray.Length; i++);
{
    Console.WriteLine(
        "Digite para [" + i + "]");

myArray[i] = Convert.ToInt32(
    Console.ReadLine()
    );s
    total += myArray[i];
   counter++;
    } 

Console.WriteLine("Contagem = " + counter);
