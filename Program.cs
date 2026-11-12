
SimpleQueue queue = new SimpleQueue();

queue.Enqueue("Knight");
queue.Enqueue("Mage");
queue.Enqueue("Archer");

Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
