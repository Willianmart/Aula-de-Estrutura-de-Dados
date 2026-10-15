using Arvores;

Console.WriteLine("Agora com Arvores");

Tree <int> tree = new Tree <int> ();

//Atribuição inline
tree.Root = new TreeNode<int>() {Data = 100};
/*TreeNode<int> root = new TreeNode<int> ();
root.Data = 100;

tree.Root = root;
*/
tree.Root.Children = new List<TreeNode<int>>
{
    new TreeNode<int> {Data = 50, Parent = tree.Root},
    new TreeNode<int> {Data = 1, Parent = tree.Root},
    new TreeNode<int> {Data = 150, Parent = tree.Root}
};

tree.Root.Children[2].Children = new List<TreeNode<int>>
{
    new TreeNode<int>() {Data = 30, Parent = tree.Root.Children[2]},
};