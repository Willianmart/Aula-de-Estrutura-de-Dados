/* Vetores Multi-Dimensionais*/
//Vetor Bi-Dimensional
int[,] numbersBi = new int [5,2]; //5 linhas e 2 colunas

//Vetor Tri-Dimensional
int[,,] numbersTri = new int [5,4,3];// Linhas Colunas e Profundidade

//Podemos Combinar a declaração com a inicialização
//Exemplo de um 4x3
int[,] newNumbersBi = new int[,] {
 {9, 5, -9},
 {-11, 4, 0},
 {6, 115, 3},
 {-12, -9, 7},
 {1, -6, -1}
};

//Percorrendo a Matriz, Exemplo de repetição for encadeada ou Nested/Chained for
for(int i = 0; i < newNumbersBi.GetLength(0); i++)
{
    for (int j = 0; j< newNumbersBi.GetLength(1); j++)
    {
        Console.Write ($"[{newNumbersBi[i,j]}]");
    }
    Console.WriteLine("");
}

//Jagged Arrays ou Arrèi de Jegues
//Vetor de Vetores

int [][] jaggedNumbers = new int [4][];
//Atribuindo Valores
jaggedNumbers[0] = new int [] {9, 5, -9};
jaggedNumbers[1] = new int [] {0, -3, 12, 51, -3};
jaggedNumbers[3]= new int [] {51};

//Declaração com Iniciailização

int [][] jaggedNumbers2 =
{
    new int [] {0, 1, 2 },
    new int [] {3, 4, 5, 6 },
    null ,
    new int [] {7, 8, 9, 10 },
    };
//Para Acessar uma posição especifica
int n = jaggedNumbers[1][2];
Console.WriteLine("n = " + n);
Console.WriteLine("jaggedNumbers[1][2] = " + jaggedNumbers[1][2]);

