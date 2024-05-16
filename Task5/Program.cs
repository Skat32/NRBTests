public class Node(Node? next)
{
    public Node? Next = next;
}

public class Program
{
    public static void Main()
    {
        // Создание "замкнутого" списка
        var head = new Node(null);
        head.Next = new Node(new Node(head));

        // Проверка на "замкнутость"
        var isClosed = IsLinkedListClosed(head);

        // Вывод результата
        Console.WriteLine("Список " + (isClosed ? "замкнут" : "не замкнут"));
    }

    private static bool IsLinkedListClosed(Node? head)
    {
        if (head == null)
            return false;

        var slow = head;
        var fast = head;

        while (fast is { Next: not null })
        {
            slow = slow?.Next;
            fast = fast.Next.Next;

            if (slow == fast)
                return true;
        }

        return false;
    }
}