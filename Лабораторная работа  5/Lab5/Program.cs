using System;

class ListNode<T>
{
    public T data;
    public ListNode<T> next;

    public ListNode(T data)
    {
        this.data = data;
        this.next = null;
    }
}

class List<T>
{
    private ListNode<T> head;
    private int count;

    public List()
    {
        head = null;
        count = 0;
    }

    public void Add(T data)
    {
        ListNode<T> newNode = new ListNode<T>(data);
        newNode.next = head;
        head = newNode;
        count++;
    }

    public int GetCount()
    {
        return count;
    }

    public void PrintList()
    {
        ListNode<T> current = head;
        while (current != null)
        {
            Console.Write(current.data + " ");
            current = current.next;
        }
        Console.WriteLine();
    }

    // Добавьте здесь другие операции, такие как поиск, вставка, удаление и т.д.
}

class Program
{
    static void Main(string[] args)
    {
        List<int> intList = new List<int>();

        // Добавление элементов в список
        intList.Add(5);
        intList.Add(10);
        intList.Add(15);

        // Вывод списка
        Console.WriteLine("Список содержит следующие элементы:");
        intList.PrintList();

        // Получение числа элементов списка
        Console.WriteLine($"Число элементов в списке: {intList.GetCount()}");

        // Здесь вы можете продолжить с другими тестами и операциями для анализа трудоемкости операций.
    }
}
