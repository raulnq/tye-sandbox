namespace frontend;

public class Statistics
{
    public string? Country { get; set; }
    public decimal Population { get; set; }
    public decimal Area { get; set; }
    public decimal Density { get { return Population / Area; } }
}
