using Calculator;

try
{
    decimal number1,number2;
    char op;
    string n1, n2;
    decimal answer;

    // Loop for input number validation
    while (true)
    {
        try
        {
            Console.WriteLine("Enter number 1");
            n1 = Console.ReadLine();
            Console.WriteLine("Enter number 2");
            n2 = Console.ReadLine();
            if (!decimal.TryParse(n1,out number1) || !decimal.TryParse(n2,out number1))
            {
                throw new WrongNumberException();
            }
            else
            {
                break; // Breaking out of the loop if input is valid
            }
        }
        catch (WrongNumberException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    // Loop for input validation (operation)
    while (true)
    {
        try
        {
            Console.WriteLine("Choose operation: + , - , / or *");
            op = char.Parse(Console.ReadLine());
            if ((op == '+' || op == '-' || op == '*' || op == '/'))
            {
                break; // Breaking out of the loop if operation is valid
            }
            else
            {
                throw new WrongOperationException();
            }
        }
        catch(WrongOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    // Parsing input strings to decimals
    number1 = decimal.Parse(n1);
    number2 = decimal.Parse(n2);

    // Performing the arithmetic operation based on the selected operation
    if (op == '+')
    {
        answer = Operation.Sum(number1, number2);
    }
    else if (op == '-')
    {
        answer = Operation.Sub(number1, number2);
    }
    else if (op == '*')
    {
        answer = Operation.Mult(number1, number2);
    }
    else
    {
        if (number2 == 0)
        {
            throw new DivideBy0Exception();  // Throwing exception for division by zero
        }
        else
        {
            answer = Operation.Div(number1, number2);
        }
    }

    // Displaying the result of the arithmetic operation
    Console.WriteLine($"{number1} {op} {number2} = {answer}");
}
catch (DivideBy0Exception ex)
{
    Console.WriteLine(ex.Message);
}