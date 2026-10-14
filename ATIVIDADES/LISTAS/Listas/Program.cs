//ArrayLists
using System.Collections;
using System.Globalization;
ArrayList arrayList = new ArrayList();
//Adicionando Items a Lista

arrayList.Add(5);

//Adicionando QUantias de Itens a Lista
arrayList.AddRange(new int[] { 1, 2, 3});
arrayList.Insert(3, 7.8);

//Percorrendo itens da Lista de Forma Generica
foreach (object obj in arrayList)
{
    Console.WriteLine(obj);
}


// LISTAS GENERICAS

List<double> numbers = new List<double>();
Console.WriteLine("Digite 'sair' para encerrar.  " );

bool run = true;
do
{
    Console.WriteLine("Digite um numero: ");
    string numberStr = Console.ReadLine();
    if (numberStr.Equals("sair"))
    {
        run = false;
        Console.WriteLine("Processo Encerrado");
        break;
        
    }
    else
    {
        // Validação da entrada do usuario para checar se é de fato um número 
        if(!double.TryParse(numberStr,
        System.Globalization.NumberStyles.Float,
        new NumberFormatInfo(),
        out double number
        )
        ){
         Console.WriteLine("Você não digitou um numero. ");
         continue;   
        }  
       numbers.Add(number);
       Console.WriteLine("A media dos valores informados é" + numbers.Average());

      }
}while(run);

// LISTAS DE TIPOS ABSTRATOS DE DADOS (TAD)

List <Person> people = new List<Person>();

//Criar uma varivavel do tipo person
Person p1 = new Person();
p1.Name = "João";
p1.Age = 42;
p1.Nationality = CountryEnum.BR;
 
people.Add(p1);

// Adicionando a lista inline
people.Add(new Person() {Name = "Mary", Age = 39, Nationality = CountryEnum.US });

people.Add(new Person() {Name = "Carlitos", Age = 24, Nationality = CountryEnum.AR });

people.Add(new Person() {Name = "Juanito", Age = 39, Nationality = CountryEnum.PY});
//Exemplo de ordenação de Lista Genérica
//Exemplo de ordenação de lista generica ultilizando o LINQ

List<Person> results = people.OrderBy( p => p.Name ).ToList();


// Percorremoa a Lista
foreach(Person p in results)
{
    Console.WriteLine($"Nome: {p.Name}, Idade: {p.Age}, Nac:  {p.Nationality}");
}

