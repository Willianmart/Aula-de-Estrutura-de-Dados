using System.Collections;

Hashtable phoneBook = new Hashtable()
{
    { "Edson Arantes do Nascimento", "0000" },
    { "Ronaldo Nazario dos Santos", "1111" },
    { "Luiz Inácio Lula da Silva", "2222" }
};

// Adicionado em tempo de execução
phoneBook["Acelino Popó de Freitas"] = "3333";

// Tratamento de possível erro de duplicidade de chave
try
{
    phoneBook.Add("Edson Arantes do Nascimento", "0000");
}
catch (ArgumentException)
{
    Console.WriteLine("Erro: a chave já existe no PhoneBook.");
}

// Percorrendo valores TableHash

Console.WriteLine ("Cardeniho de telefone: ");
if(phoneBook.Count == 0){
    Console.WriteLine ("Agenda vazia.");
}else{
    int i =1;
    foreach (DictionaryEntry entry in phoneBook){
        Console.WriteLine ($"{i}. {entry.Key} - {entry.Value}");
        i++;
    }
}

// Busca em chave
Console.WriteLine ("");
Console.WriteLine  ("Busca por nome: ");
string name = Console.ReadLine ();

if(phoneBook.Contains (name)) {
    string number = (string)phoneBook [name];
    Console.WriteLine ( name + " - " + number);
}else {
    Console.WriteLine($"{name} não encontrado.");
}

/*
  DICIONARIOS
*/
Dictionary<string, string> dic = new Dictionary<string, string> (){
    {"Dom Pedroca 2", "123456"},
    {"São Cristovinho", "789663"}
};

// Obtendo valor do dicionario
string value = dic["Dom Pedroca 2"];

dic["Dom Pedroca 2"] = "123456";
foreach(KeyValuePair<string, string> pair in dic){
    Console.WriteLine ("" + pair.Key + "" + pair.Value);
}