
SimpleQueue queue = new SimpleQueue();

queue.Enqueue("Knight");
queue.Enqueue("Mage");
queue.Enqueue("Archer");

Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());



// Reflection Questions:

// 1. What does FIFO mean?
// FIFO means First In, First Out. The first item added
// to the queue is the first item removed.

// 2. What real-world systems use queues?
// Lines at stores, printer jobs, and customer service
// systems use queues to process things in order.

// 3. Why might shifting the array be inefficient for very large queues?
// Shifting can be slow because every remaining item
// has to move forward whenever an item is removed.