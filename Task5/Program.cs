using Task5;

public class Program
{
    public static void Main()
    {
        Calculator calculator = new Calculator();

        while (true)
        {
            try
            {
                Console.WriteLine("Введіть перше число (або 'q' для виходу): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "q")
                {
                    break;
                }
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Введіть друге число (або 'q' для виходу): ");
                if (input.ToLower() == "q")
                {
                    break;
                }
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Виберіть операцію (+, -, *, /) або 'q' для виходу: ");
                if (input.ToLower() == "q")
                {
                    break;
                }
                string operation = Console.ReadLine();

                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = calculator.Add(num1, num2);
                        break;
                    case "-":
                        result = calculator.Sub(num1, num2);
                        break;
                    case "*":
                        result = calculator.Mul(num1, num2);
                        break;
                    case "/":
                        result = calculator.Div(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Невідома операція.");
                        return;
                }

                Console.WriteLine($"Результат: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: введено некоректне число.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Невідома помилка: {ex.Message}");
            }
        }
        Console.WriteLine("Програму завершено.");
    }
}