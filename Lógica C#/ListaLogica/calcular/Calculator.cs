using System;

public class Calculator
{
    public int Calculate(string op, int a, int b)
    {
        if (op == "+")
        {
            return a+b;
        }
        else if (op == "-")
        {
            return a-b;
        }
        else if (op == "*")
        {
            return a*b;
        }
        else if (op == "/")
        {
            return a/b;
        }
        return 1;
    }
}    
