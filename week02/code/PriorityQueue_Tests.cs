using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Will add all valtes in order by priority.
    // Expected Result: Value2, Value1, Value3
    // Defect(s) Found: Repeats value2.
    public void TestAddsAll()
    {
        var priority1 = new PriorityItem("Value1", 2);
        var priority2 = new PriorityItem("Value2", 3);
        var priority3 = new PriorityItem("Value3", 1);

        PriorityItem[] expectedResult = [priority2, priority1, priority3];

        var priority = new PriorityQueue();
        priority.Enqueue(priority1.Value, priority1.Priority);
        priority.Enqueue(priority2.Value, priority2.Priority);
        priority.Enqueue(priority3.Value, priority3.Priority);

        for (int i = 0; i < 10; i++)
        {
        var value = priority.Dequeue();
        Assert.AreEqual(expectedResult[i].Value, value);
        }
       
    }

    [TestMethod]
    // Scenario: Will try to get the next value from an empty queue
    // Expected Result: Exception should be thrown with appropriate error message.
    // Defect(s) Found: None.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }

    // Add more test cases as needed below.
}