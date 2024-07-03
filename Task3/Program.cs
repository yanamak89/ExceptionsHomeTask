using Task3;

public class Program
{
    public static void Main()
    {
        Price[] prices = new Price[2];
        Console.WriteLine("Введіть дані для двох товарів:");
        for (int i = 0; i < prices.Length; i++)
        {
            prices[i] = InputPriceData();
        }
        Array.Sort(prices);
        
        Console.Write("Введіть назву магазину для пошуку товарів: ");
        string searchStoreName = Console.ReadLine();
        bool storeFound = false;

        foreach (var price in prices)
        {
            if (price.StoreName.Equals(searchStoreName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Товар: {price.ProductName}, Магазин: {price.StoreName}, Вартість: {price.ProductPrice} грн.");
                storeFound = true;
            }
        }

        if (!storeFound)
        {
            Console.WriteLine("Магазин не знайдено.");
        }
    }

    public static Price InputPriceData()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Введіть назву товару: ");
                string productName = Console.ReadLine();
                
                Console.WriteLine("Введіть назву магазину:");
                string storeName = Console.ReadLine();
                
                Console.Write("Введіть вартість товару у гривнях: ");
                double productPrice = double.Parse(Console.ReadLine());

                return new Price { ProductName = productName, StoreName = storeName, ProductPrice = productPrice };

            }
            catch (FormatException)
            {
                Console.WriteLine("Невірний формат вартості. Спробуйте ще раз.");
            }
        }
    }
    

}