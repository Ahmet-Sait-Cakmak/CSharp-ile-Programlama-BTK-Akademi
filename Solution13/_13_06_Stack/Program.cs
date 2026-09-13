Console.WriteLine(IsBalanced("{ [ (a + b) * c ] - 5 }")); // true
Console.WriteLine(IsBalanced("{ [ (a + b) * c ]")); // false

bool IsBalanced(string input)
{
    const string openBrackets = "([{";
    const string closeBrackets = ")]}";

    var stack = new Stack<char>();

    foreach (char c in input) 
    {
        int openIndex = openBrackets.IndexOf(c);

        if (openIndex >= 0) 
        {
            stack.Push(c);

            continue;
        }

        int closeIndex = closeBrackets.IndexOf(c);

        if (closeIndex >= 0)
        {
            // stack'in bos olma durumu
            if (stack.Count == 0)
                return false;

            char lastOpen = stack.Pop();

            if (lastOpen != openBrackets[closeIndex])
                return false;
        }
    }

    return stack.Count == 0;
}


Console.ReadKey();