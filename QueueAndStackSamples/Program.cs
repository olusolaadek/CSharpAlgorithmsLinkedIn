
// Stack
//Stack<string> stack = new Stack<string>();
//Console.WriteLine("Start Main");
//stack.Push("Main");
//Console.WriteLine("Start ResponseBuilder");
//stack.Push("ResponseBuilder");
//Console.WriteLine("Start CallExternalService");
//stack.Push("CallExternalService");
//Console.WriteLine("END " + stack.Pop());
//Console.WriteLine("Start ParseExternalData");
//stack.Push("ParseExternalData");
//Console.WriteLine("END " + stack.Pop());
//Console.WriteLine("END " + stack.Pop());
//Console.WriteLine("END " + stack.Pop());

//string item;
//Console.WriteLine(stack.TryPop(out item));

// Print the next greater element for 
// every element in the array

int[] arr = { 15, 8, 4, 10 };
// PrintNextGreaterElement(arr);
Console.WriteLine(HasMatchingParentheses("((hello))"));
Console.WriteLine(HasMatchingParentheses("((hello())"));
// Using tracker variable
Console.WriteLine(HasMatchingParentheses2("((hello))"));
Console.WriteLine(HasMatchingParentheses2("((hello())"));
Console.WriteLine(HasMatchingParentheses2("((hello()))"));

bool HasMatchingParentheses2(string s)
{
    int symbolTracker = 0;


    for (int i = 0; i < s.Length; i++)
    {
        char current = s[i];
        if (current == '(')
        {
            symbolTracker++;
            continue;
        }
        if (current == ')')
        {
            if (symbolTracker > 0)
            {
                symbolTracker--; ;
            }
            else
            {
                return false;
            }

        }
    }

    return symbolTracker == 0;
}

bool HasMatchingParentheses(string s)
{
    Stack<char> stack = new Stack<char>();

    for (int i = 0; i < s.Length; i++)
    {
        char current = s[i];
        if (current == '(')
        {
            stack.Push(current);
            continue;
        }
        if (current == ')')
        {
            if (stack.Count > 0)
            {
                stack.Pop();
            }
            else
            {
                return false;
            }

        }
    }

    return stack.Count == 0;
}

void PrintNextGreaterElement(int[] arr)
{
    if (arr.Length <= 0)
    {
        Console.WriteLine();
        return;
    }
    Stack<int> stack = new Stack<int>();

    stack.Push(arr[0]);

    for (int i = 1; i < arr.Length; i++)
    {
        int next = arr[i];
        if (stack.Count > 0)
        {
            int popped = stack.Pop();
            while (popped < next)
            {
                Console.WriteLine(popped + "-->" + next);
                if (stack.Count == 0)
                {
                    break;
                }
                popped = stack.Pop();
            }
            if (popped > next)
            {
                stack.Push(popped);
            }
        }
        stack.Push(next);
    }
    while (stack.Count > 0)
    {
        Console.WriteLine(stack.Pop() + "-->" + -1);
    }

}

//Queue<int> queue = new Queue<int>();
//queue.Enqueue(1);
//queue.Enqueue(8);
//queue.Enqueue(20);
//queue.Enqueue(23);
//PrintQueue();
//void PrintQueue()
//{
//    foreach (int q in queue)
//    {
//        Console.Write(q + "<-");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//int removedItem = queue.Dequeue();
//Console.WriteLine(removedItem + " removed from the queue");
//PrintQueue();
//Console.WriteLine(queue.Dequeue());
//// TryDequeue

//int current;
//while (queue.TryDequeue(out current))
//{
//    Console.WriteLine(current);
//}
//PrintBinary(5);
//PrintBinary(-2);
//PrintBinary(0);
//PrintBinary(2);
//PrintBinary(8);

//void PrintBase4(int n)
//{
//    if (n <= 0)
//    {
//        return;
//    }
//    // use Queue
//    Queue<int> queue = new Queue<int>();
//    queue.Enqueue(1);
//    int multi = 1;
//    for (int i = 0; i < n; i++)
//    {
//        int current = queue.Dequeue();
//        Console.WriteLine(current);
//        queue.Enqueue(current + 1);
//        queue.Enqueue(current + 2);

//    }
//}

void PrintBinary(int n)
{
    if (n <= 0)
    {
        return;
    }

    Queue<int> q = new Queue<int>();
    q.Enqueue(1);
    for (int i = 0; i < n; i++)
    {
        int current = q.Dequeue();
        Console.WriteLine(current); ;
        q.Enqueue(current * 10); ;
        q.Enqueue(current * 10 + 1);
    }
    Console.WriteLine();


}

