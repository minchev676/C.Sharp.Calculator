Console.WriteLine("Write numbers and arithmetic sigh after every number!");
double answer = 0;
var complex = 0;
string sign = "";
while (true)
{
    if (complex == 1)
    {
        sign = Console.ReadLine();
    }
    var num1 = double.Parse(Console.ReadLine());
    if (sign == "+")
    {
        answer += num1;
    }
    if (sign == "-")
    {
        answer -= num1;
    }
    if (sign == "*")
    {
        answer *= num1;
    }
    if (sign == "/")
    {
        answer /= num1;
    }
    if (complex == 1)
    {
        Console.Clear();
        Console.WriteLine(answer);
    }
    string sign1 = Console.ReadLine();
    var num2 = double.Parse(Console.ReadLine());
    if (complex == 1)
    {
        if (sign1 == "+")
        {
            answer += num2;
        }
        if (sign1 == "-")
        {
            answer -= num2;
        }
        if (sign1 == "*")
        {
            answer *= num2;
        }
        if (sign1 == "/")
        {
            answer /= num2;
        }
    }
    else
    {
        if (sign1 == "+")
        {
            answer = num1 + num2;
        }
        if (sign1 == "-")
        {
            answer = num1 - num2;
        }
        if (sign1 == "*")
        {
            answer = num1 * num2;
        }
        if (sign1 == "/")
        {
            answer = num1 / num2;
        }
    }
    complex = 1;
    Console.Clear();
    Console.WriteLine(answer);
}
