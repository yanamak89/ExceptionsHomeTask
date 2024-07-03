namespace Task2;

public struct Worker : IComparable<Worker>
{
    public string LastName { get; set; }
    public string Initials { get; set; }
    public string Position { get; set; }
    public int StartYear { get; set; }

    public int CompareTo(Worker other)
    {
        return string.Compare(this.LastName, other.LastName, 
            StringComparison.Ordinal);
    }

    public int WorkExperience(int currentYear)
    {
        return currentYear - this.StartYear;
    }

    
}