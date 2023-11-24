public class CalculatorService
{
    public int Calculate(int x, int y, string operation)
    {
        switch (operation)
        {
            case "+":
                return x + y;
            case "-":
                return x - y;
            case "*":
                return x * y;
            case "/":
                if (y != 0)
                    return x / y;
                else
                    throw new ArgumentException("Cannot divide by zero.");
            default:
                throw new ArgumentException("Invalid operator.");
        }
    }
}
