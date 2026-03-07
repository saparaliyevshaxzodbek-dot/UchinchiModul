namespace _3_11_Dars;

internal class Program
{
    static void Main(string[] args)
    {
        Node node = NodeService.CreateNode(4);
        var res = GetLengthOfNode(node);
        Console.WriteLine(res);
    }

    static int GetLengthOfNode(Node node)
    {
        var counter = 0;
        while (true)
        {
            if (node != null)
            {
                ++counter;
            }
            if (node.Next == null)
            {
                break;
            }
            node = node.Next;
        }

        return counter;


    }
}
