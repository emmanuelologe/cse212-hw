public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Enqueue items with different priorities and ensure Dequeue returns the item with the highest priority.
        // Expected Result: "Task2" should be dequeued as it has the highest priority (5).
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Task1", 1);
        priorityQueue.Enqueue("Task2", 5);
        priorityQueue.Enqueue("Task3", 3);
        Console.WriteLine("Test 1");
        var dequeuedItem = priorityQueue.Dequeue();
        // Expected Result: "Task2" should be dequeued as it has the highest priority (5).
        Console.WriteLine($"Expected: Task2, Actual: {dequeuedItem}");
        // Defect(s) Found: Check if the highest priority item is removed.
        Console.WriteLine("---------");
        

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Enqueue multiple items with the same priority and check if they are dequeued in FIFO order.
        // Expected Result: "Task4" should be dequeued before "Task5" as they have the same priority.
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("Task4", 2);
        priorityQueue.Enqueue("Task5", 2);
        Console.WriteLine("Test 2");
        var dequeuedItem1 = priorityQueue.Dequeue();
        var dequeuedItem2 = priorityQueue.Dequeue();
        // Expected Result: "Task4" should be dequeued before "Task5" as they have the same priority.
        Console.WriteLine($"Expected: Task4, Actual: {dequeuedItem1}");
        Console.WriteLine($"Expected: Task5, Actual: {dequeuedItem2}");
        // Defect(s) Found: Verify if items with the same priority are dequeued in the order they were enqueued.
        Console.WriteLine("---------");
        

        Console.WriteLine("---------");
        
        // Test 3: 
        // Scenario: Attempt to dequeue from an empty queue to verify the appropriate error message is displayed.
        // Expected Result: null should be returned, and an error message should be printed.
        var emptyQueue = new PriorityQueue();
        Console.WriteLine("Test 3");
        var dequeuedFromEmpty = emptyQueue.Dequeue();
        Console.WriteLine($"Expected: null, Actual: {dequeuedFromEmpty}");
        // Defect(s) Found: Check if the error message is displayed and null is returned.
        Console.WriteLine("---------");

        // Test 4: Single Item Queue
        // Scenario: Enqueue and dequeue a single item to ensure proper functionality.
        // Expected Result: "Task6" should be dequeued.
        var singleItemQueue = new PriorityQueue();
        singleItemQueue.Enqueue("Task6", 4);
        Console.WriteLine("Test 4");
        var dequeuedSingle = singleItemQueue.Dequeue();
        Console.WriteLine($"Expected: Task6, Actual: {dequeuedSingle}");
        // Defect(s) Found: Ensure single item is properly enqueued and dequeued.
        Console.WriteLine("---------");

        // Test 5: 
        // Scenario: Enqueue items where multiple have the highest priority and ensure the correct item is removed first.
        // Expected Result: "Task8" should be dequeued first, followed by "Task9".
        priorityQueue.Enqueue("Task7", 3);
        priorityQueue.Enqueue("Task8", 5);
        priorityQueue.Enqueue("Task9", 5);
        Console.WriteLine("Test 5");
        var dequeuedHigh1 = priorityQueue.Dequeue();
        var dequeuedHigh2 = priorityQueue.Dequeue();
        // Expected Result: "Task8" should be dequeued first, followed by "Task9".
        Console.WriteLine($"Expected: Task8, Actual: {dequeuedHigh1}");
        Console.WriteLine($"Expected: Task9, Actual: {dequeuedHigh2}");
        // Defect(s) Found: Verify that the first high priority item is removed first.
        Console.WriteLine("---------");
        
    }
}