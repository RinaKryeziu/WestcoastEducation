namespace WestcoastEducation;

public class PersonalInfo
{
    /* PROPERTIES */
    public string? Name { get; set; } 
    public string? LastName { get; set; } 
    public string? Phone { get; set; } 
    public string? SocialSecurityNumber { get; set; } 
    public string? Address { get; set; } 
    public string? PostalCode { get; set; } 
    public string? City { get; set; } 

    /* METHODS */
       public override string ToString()
    {
        return $"\nNamn: {Name} {LastName}\nTelefon: {Phone}\nPersonnummer: {SocialSecurityNumber}\nAdress: {Address}, {PostalCode}, {City}\n";
    }
}
