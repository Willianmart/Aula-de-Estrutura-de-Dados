using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, string>> carros =
            new Dictionary<string, Dictionary<string, string>>();

        int opcao = 0;

        while (opcao != 5)
        {
            Console.WriteLine("\nSISTEMA DE CONTROLE DE AUTOMÓVEIS");
            Console.WriteLine("1 - Cadastrar automóvel");
            Console.WriteLine("2 - Buscar automóvel pela placa");
            Console.WriteLine("3 - Listar todos os automóveis");
            Console.WriteLine("4 - Buscar automóveis por marca");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("\nDigite a placa: ");
                string placa = Console.ReadLine().ToUpper();

                if (carros.ContainsKey(placa))
                {
                    Console.WriteLine("Essa placa já está cadastrada!");
                }
                else
                {
                    Console.Write("Digite a marca: ");
                    string marca = Console.ReadLine();

                    Console.Write("Digite o modelo: ");
                    string modelo = Console.ReadLine();

                    Console.Write("Digite o ano: ");
                    string ano = Console.ReadLine();

                    Console.Write("Digite a cor: ");
                    string cor = Console.ReadLine();

                    Console.Write("Digite o valor: ");
                    string valor = Console.ReadLine();

                    Dictionary<string, string> carro =
                        new Dictionary<string, string>();

                    carro.Add("Marca", marca);
                    carro.Add("Modelo", modelo);
                    carro.Add("Ano", ano);
                    carro.Add("Cor", cor);
                    carro.Add("Valor", valor);

                    carros.Add(placa, carro);

                    Console.WriteLine("Automóvel cadastrado com sucesso!");
                }
            }
            else if (opcao == 2)
            {
                Console.Write("\nDigite a placa: ");
                string placa = Console.ReadLine().ToUpper();

                if (carros.ContainsKey(placa))
                {
                    Dictionary<string, string> carro = carros[placa];

                    Console.WriteLine("\n--- AUTOMÓVEL ---");
                    Console.WriteLine("Placa: " + placa);
                    Console.WriteLine("Marca: " + carro["Marca"]);
                    Console.WriteLine("Modelo: " + carro["Modelo"]);
                    Console.WriteLine("Ano: " + carro["Ano"]);
                    Console.WriteLine("Cor: " + carro["Cor"]);
                    Console.WriteLine("Valor: R$ " + carro["Valor"]);
                }
                else
                {
                    Console.WriteLine("Automóvel não encontrado.");
                }
            }
            else if (opcao == 3)
            {
                if (carros.Count == 0)
                {
                    Console.WriteLine("\nNenhum automóvel cadastrado.");
                }
                else
                {
                    Console.WriteLine("\n--- TODOS OS AUTOMÓVEIS ---");

                    foreach (var item in carros)
                    {
                        Console.WriteLine("\nPlaca: " + item.Key);
                        Console.WriteLine("Marca: " + item.Value["Marca"]);
                        Console.WriteLine("Modelo: " + item.Value["Modelo"]);
                        Console.WriteLine("Ano: " + item.Value["Ano"]);
                        Console.WriteLine("Cor: " + item.Value["Cor"]);
                        Console.WriteLine("Valor: R$ " + item.Value["Valor"]);
                    }
                }
            }
            else if (opcao == 4)
            {
                Console.Write("\nDigite a marca: ");
                string marca = Console.ReadLine();

                bool encontrou = false;

                foreach (var item in carros)
                {
                    if (item.Value["Marca"].ToLower() == marca.ToLower())
                    {
                        Console.WriteLine("\nPlaca: " + item.Key);
                        Console.WriteLine("Marca: " + item.Value["Marca"]);
                        Console.WriteLine("Modelo: " + item.Value["Modelo"]);
                        Console.WriteLine("Ano: " + item.Value["Ano"]);
                        Console.WriteLine("Cor: " + item.Value["Cor"]);
                        Console.WriteLine("Valor: R$ " + item.Value["Valor"]);

                        encontrou = true;
                    }
                }

                if (!encontrou)
                {
                    Console.WriteLine("Nenhum automóvel dessa marca foi encontrado.");
                }
            }
            else if (opcao == 5)
            {
                Console.WriteLine("Sistema encerrado.");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
        }
    }
}