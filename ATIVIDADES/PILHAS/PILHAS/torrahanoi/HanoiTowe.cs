namespace TorreHanoi{

public class HanoiTower
{
    public int DisksCount { get; private set; }
    public int MovesCount { get; private set; }
    public Stack<int> From { get; private set; }
    public Stack<int> To { get; private set; } // são pilhas
    public Stack<int> Auxiliary { get; private set; }
    public event EventHandler<EventArgs> MoveCompleted; //um evento que é disparado quando um movimento é realizado

    public HanoiTower (int discs)
    {
        DisksCount = discs;
        From = new Stack<int>();
        To = new Stack<int>();
        Auxiliary = new Stack<int>(); // Faz a carga da pilha from com os discos
        for (int i = 1; i <= discs; i++)
        {
            int size = discs -i +1;
            From.Push(size);
        }
    
    } // isso é um parametro para quando criar a torre de hanoi ter que dizer a quantidade de discos

public void Start()
    {
    Move(DisksCount, From, To, Auxiliary);        
    }
    public void Move(int discs, Stack<int> from, Stack<int> to, Stack<int> auxiliary ) // isso tudo como "from" to entre outras coisas devem estar em pascalCase
    //vale dizer que isso são parametros.
    {
        if(discs >0)
        {
            Move(discs -1, from, auxiliary, to);
            to.Push(from.Pop());
            MovesCount++;
            MoveCompleted?.Invoke(this, EventArgs.Empty); //diz que ouve um movimento mas não passa nada como argumento.
            Move(discs - 1, auxiliary, to, from );
        }
        
    }
}
}
//os atributos são caracteristicas e os metodos as ações que a classe pode realizar. A classe é um molde para criar objetos, e os objetos são instâncias da classe.
