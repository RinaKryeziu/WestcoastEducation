using System.Security.Cryptography.X509Certificates;

namespace WestcoastEducation;

public class Teachers : Employees, IManage    
{
    /* PROPERTIES */
    public List<Teachers> teachers  = [];

    /* METHODS */
    public void Add(Teachers teacher)
    {
        teachers.Add(teacher);
    } 

    public override void ListAll()
    {
        foreach(var teacher in teachers )
        {
            Console.WriteLine(teacher.ToString());
        }
    }

    public override void Find(string socialSecurityNumber)
    {
        if (socialSecurityNumber == "19680412-1291")
        {
            SocialSecurityNumber = "19680412-1291";
            Name = "Jonas";
            LastName = "Lindmark";
            Phone = "072-6644210";
            Address = "Rönnegatan 3";
            PostalCode = "217 66";
            City = "Malmö";
            SubjectArea = "Objektorienterad programmering";
        }
        else if (socialSecurityNumber == "19791104-3022")
        {
            SocialSecurityNumber = "19791104-3022";
            Name = "Linda";
            LastName = "Nilsson";
            Phone = "073-1152110";
            Address = "Övägen 33";
            PostalCode = "422 33";
            City = "Göteborg";
            SubjectArea = "Ledarskap";
        }
        else 
        {
            Console.WriteLine("Läraren finns inte med i listan.");
        }
    }
  
    public override string ToString()
    {
        return $"{base.ToString()}";
    }
}
