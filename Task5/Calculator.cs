namespace Task5;

public class Calculator
{
    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }
    
    public double Sub(double num1, double num2)
    {
        return num1 - num2;
    }
    
    public double Mul(double num1, double num2)
    {
        return num1 * num2;
    }

    public double Div(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Ділення на 0 неможливе.");
        }

        return num1 / num2;
    }
}