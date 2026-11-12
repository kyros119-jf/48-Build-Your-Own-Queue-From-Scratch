
public class SimpleQueue
{
    private string[] items = new string[10];
    private int count = 0;

    public void Enqueue(string item)
    {
        if (count < items.Length)
        {
            items[count] = item;
            count++;
        }
        else
        {
            Console.WriteLine("Queue is full!");
        }
    }

    public string Dequeue()
    {
        if (count == 0)
        {
            return "Queue is empty!";
        }

        string firstItem = items[0];

        for (int i = 0; i < count - 1; i++)
        {
            items[i] = items[i + 1];
        }

        count--;
        items[count] = null!;

        return firstItem;
    }
}
