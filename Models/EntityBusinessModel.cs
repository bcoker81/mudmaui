namespace AspNetCoreBlazorStateManagement.Models;

public class EntityBusinessModel
{
    public bool IdentityKnown { get; set; }
    public bool Finterprinted { get; set; }
    public bool ProvidedFirstAid { get; set; }
    public bool PhotoProvided { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? MiddleName { get; set; }
    public string? GenSuffix { get; set; }
    public bool? DateOfBirthKnown { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public int Age { get; set; }
    public string? Units { get; set; }
    public string? Race { get; set; }
    public string? Ethnicity { get; set; }
    public string? Sex { get; set; }
    public int HeightFt { get; set; }
    public int HeighIn { get; set; }
    public int Weight { get; set; }
    public string? EyeColor { get; set; }
    public string? HairColor { get; set; }
    public string? HairColor2 { get; set; }
    public string? SSN { get; set; }
}