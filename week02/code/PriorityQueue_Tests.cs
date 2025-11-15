using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three items: A(1), B(5), C(3). Then call Dequeue() once.
    // Expected Result: Dequeue should return "B", because it has the highest priority.
    // Defect(s) Found:  The loop that searches for the highest priority stops at index < Count - 1, so it never checks the last item.
    // The code returns the value but does NOT remove the dequeued item from the list.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: Enqueue A(10) and B(10), then Dequeue once. Both have equal priority.
    // Expected Result: FIFO should be respected. Dequeue should return "A", because A entered first.
    // Defect(s) Found: The comparison uses >= instead of >, causing later items with the same priority to incorrectly override earlier ones.
    // FIFO for equal-priority items is violated.
    // Dequeue still fails to remove the selected item from the queue.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
}