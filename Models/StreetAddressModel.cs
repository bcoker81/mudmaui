namespace AspNetCoreBlazorStateManagement.Models;

public class StreetAddressModel
{
    public int Id { get; set; }
    public string? HighwayClassSelection { get; set; }
    public string? HouseNumber { get; set; }
    public string? Street { get; set; }
    public string? UnitNumber { get; set; }
    public string? CitySelection { get; set; }
    public string? CountrySelection { get; set; }
    public string? StateSelection { get; set; }
    public int Zip { get; set; }
    public int Zip4 { get; set; }
    public string? CountySelection { get; set; }
}