namespace PackIT.Infrastructure.EF.Models;

internal class LocalizationReadModel
{
    public string City { get; set; }
    public string Country { get; set; }
    public static LocalizationReadModel Create(string value)
    {
        var splitLocalitzation = value.Split(',');
        return new LocalizationReadModel
        {
            City = splitLocalitzation.First(),
            Country = splitLocalitzation.Last()
        };
    }
    public override string ToString()
        => $"{City},{Country}";
}
