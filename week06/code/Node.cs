public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value == Data) return;
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (value == Data) return true;
        if (value < Data) {
            return Left?. Contains(value) ?? false;
        }
        else{
            return Right?. Contains(value) ?? false;
        }
    }

    public void TraverseBackward(List<int> values) {
        if (Right != null) {
            Right.TraverseBackward(values);
        }
        values.Add(Data);
        if (Left != null) {
            Left.TraverseBackward(values);
        }
    }

    public int GetHeight() {
        // TODO Start Problem 4
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;
        return  1 + Math.Max(leftHeight, rightHeight); // Replace this line with the correct return statement(s)
    }


public class BinarySearchTree {
    private Node? root;

    public void Insert(int value) {
        if (root == null)
            root = new Node(value);
        else
            root.Insert(value);
    }

    public bool Contains(int value) {
        return root?.Contains(value) ?? false;
    }

    // Use TraverseBackward to implement Reverse
    public IEnumerable<int> Reverse() {
        var values = new List<int>();
        root?.TraverseBackward(values);
        return values;
    }

    public int GetHeight() {
        return root?.GetHeight() ?? 0;
    }

    public override string ToString() {
        return string.Join(", ", Reverse().Reverse());
    }
}
}