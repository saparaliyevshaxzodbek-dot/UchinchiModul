namespace _3_11_Dars;

public class NodeService
{
    public static Node CreateNode(int length)
    {
        Random random = new Random();
        Node headNode = new Node(random.Next(2, 9));
        Node currentNode = headNode;

        for (int i = 1; i < length; i++)
        {
            Node newNode = new Node(random.Next(2, 9));
            currentNode.Next = newNode;
            currentNode = currentNode.Next;
        }

        return headNode;

    }

    public int SummaValue(Node head)
    {

        var sum = 0;

        Node currentNode = head;
        while (currentNode != null)
        {
            sum += currentNode.Value;
            currentNode = currentNode.Next;
        }
        return sum;

    }

    public Node MaxNode(Node head)
    {
        Node max = default;

        Node currentNode = head;

        while (currentNode != null)
        {
            if(currentNode.Value > max.Value)
            {
                max = currentNode;
                currentNode = currentNode.Next;
            }
        }

        return max;
        

    }



}
