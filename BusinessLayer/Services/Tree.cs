namespace YakimGames.BackOffice.Server.Business.Services;

public class Tree<T>
{
    public List<TreeNode<T>> Roots { get; set; }

    public Tree()
    {
        Roots = new List<TreeNode<T>>();
    }

    public void AddNode(T value, T parentValue)
    {
        TreeNode<T> nodeToAdd = new TreeNode<T>(value);

        if (EqualityComparer<T>.Default.Equals(parentValue, default(T)))
        {
            // If parent value is default, add new node as root node
            Roots.Add(nodeToAdd);
        }
        else
        {
            // Otherwise, find the parent node and add the new node as its child
            AddNodeRecursive(nodeToAdd, Roots, parentValue);
        }
    }
    
    private void AddNodeRecursive(TreeNode<T> nodeToAdd, List<TreeNode<T>> nodes, T parentValue)
    {
        foreach (var node in nodes)
        {
            if (EqualityComparer<T>.Default.Equals(node.Value, parentValue))
            {
                // Found the parent node, so add the new node as its child
                node.Children.Add(nodeToAdd);
                return;
            }
            else if (node.Children.Count > 0)
            {
                // Recursively search for the parent node in the children of the current node
                AddNodeRecursive(nodeToAdd, node.Children, parentValue);
            }
        }
    }
}