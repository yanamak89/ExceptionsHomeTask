using Task2;

public class Program
{
    public static void Main()
    {
        Worker[] workers = new Worker[5];

        Console.WriteLine("Введіть дані для п'яти працівників:");
        for (int i = 0; i < workers.Length; i++)
        {
            workers[i] = InputWorkerData();
        }

        Array.Sort(workers);

        int experienceThreshold;
        while (true)
        {
            try
            {
                Console.Write("Введіть мінімальний стаж роботи: ");
                experienceThreshold = int.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Стаж має бути цілим числом.");
            }
        }

        int currentYear = DateTime.Now.Year;
        Console.WriteLine($"\nПрацівники зі стажем роботи більше ніж {experienceThreshold} років:");
        foreach (var worker in workers)
        {
            if (worker.WorkExperience(currentYear) > experienceThreshold)
            {
                Console.WriteLine($"{worker.LastName} {worker.Initials}, посада: {worker.Position}, стаж: {worker.WorkExperience(currentYear)} років");
            }
        }
    }

    public static Worker InputWorkerData()
    {
        while (true)
        {
            try
            {
                Console.Write("Введіть прізвище: ");
                string lastName = Console.ReadLine();

                Console.Write("Введіть ініціали: ");
                string initials = Console.ReadLine();

                Console.Write("Введіть назву посади: ");
                string position = Console.ReadLine();

                Console.Write("Введіть рік початку працюваті: ");
                int startYear = int.Parse(Console.ReadLine());

                if (startYear < 1900 || startYear > DateTime.Now.Year)
                {
                    throw new FormatException("Невірний формат року. Введіть рік у форматі ЧЧЧЧ.");
                }

                return new Worker { LastName = lastName, Initials = initials, Position = position, StartYear = startYear };
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}