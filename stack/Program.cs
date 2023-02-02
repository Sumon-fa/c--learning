namespace stack;
class Program
{
    static void Main(string[] args)
    {
        Stack<int> myStack = new Stack<int>();
        /*   myStack.Push(1);
             Console.WriteLine(myStack.Peek());
             myStack.Push(2);
             Console.WriteLine(myStack.Peek());
             myStack.Push(3);
             Console.WriteLine(myStack.Peek());*/

        for (int i = 0; i < 10; i++)
        {
            myStack.Push(i);
        }
        foreach (int item in myStack)
        {
            Console.WriteLine(item);
        }
        // Console.WriteLine(myStack.Peek());
        while (myStack.Count > 0)
        {
            Console.WriteLine(myStack.Pop());
        }


    }
}
