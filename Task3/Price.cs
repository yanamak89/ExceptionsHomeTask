namespace Task3;

/*Потрібно описати структуру з іменем Price, що містить такі поля:
    • назва товару;
    • назва магазину, де продається товар;
    • вартість товару у гривнях.
*/
public struct Price : IComparable<Price>
{
    public string ProductName { get; set; }
    public string StoreName { get; set; }
    public double ProductPrice { get; set; }

    public int CompareTo(Price other)
    {
        return string.Compare(this.StoreName, other.StoreName, StringComparison.Ordinal);
    }
}