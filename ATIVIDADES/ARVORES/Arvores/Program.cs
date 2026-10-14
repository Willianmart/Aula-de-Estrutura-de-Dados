using Arvores;

Console.WriteLine("Agora com Arvores");

Tree <int> tree = new Tree <int> ();

//Atribuição inline
tree.Root = new TreeNode<int>() {Data = 100};
/*TreeNode<int> root = new TreeNode<int> ();
root.Data = 100;

tree.Root = root;
*/