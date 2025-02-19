public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        if (value == Data) {
            return;
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        //if value == data
        //return true
        if (value == Data) {
            return true;
        }
        //use Insert
        else {
            return false;
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        //int var is set
        var numb1 = 0;
        var numb2 = 0;
        if (Left is null)
            {
                numb1 = 0;
            }
        else {
            numb1 =+ 1;
        }
        if (Right is null)
            {
                numb2 = 0;
            }
        else {
            numb2 =+ 1;
        }
        Math.Max(numb1, numb2);
        //a check of each right and left is set to check for null/leaf
        //condition is true, process left side
        //if null, var is assigned 0
        //Math.max(value1, value2)- returns bigger value
        //
        return 0; // Replace this line with the correct return statement(s)
    }
}