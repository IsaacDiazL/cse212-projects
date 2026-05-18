using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var bob = new PriorityItem("Bob", 1);
        var tim = new PriorityItem("Tim", 2);
        var sue = new PriorityItem("Sue", 3);

        PriorityItem[] expectedResult = [sue];

        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue(sue.Value, sue.Priority);

            var person = priorityQueue.Dequeue();
            Assert.Fail(expectedResult[0].Value, person);

    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
}