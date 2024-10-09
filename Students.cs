
namespace WestcoastEducation;

public class Students : PersonalInfo, IManage
{
    public List <Students> students = [];
    
    /* METHODS */
    public void Add(Students student)
    {
        students.Add(student);
    }
 
    public void ListAll ()
    {
        foreach (var student in students)
        {
            Console.WriteLine(student.ToString());
        }
    }
    public void Find (string socialSecurityNumber){
        if (socialSecurityNumber == "19990325-4521")
        {
            SocialSecurityNumber = "19990325-4521";
            Name = "Sara";
            LastName = "Svensson";
            Phone = "073-2489340";
            Address = "Helvägen 10";
            PostalCode = "312 45";
            City = "Helsingborg";
        }
        else if (socialSecurityNumber == "19950920-8131")
        {
            SocialSecurityNumber = "19950920-8131";
            Name = "Arvid";
            LastName = "Lindén";
            Phone = "076-3587255";
            Address = "Järnvägen 5";
            PostalCode = "415 22";
            City = "Göteborg";
        }
        else if (socialSecurityNumber == "20010117-5255")
        {
            SocialSecurityNumber = "20010117-5255";
            Name = "Ali";
            LastName = "Kassem";
            Phone = "073-4533577";
            Address = "Götevägen 20";
            PostalCode = "420 11";
            City = "Göteborg";
        }
        else if (socialSecurityNumber == "19911004-5061")
        {
            SocialSecurityNumber = "19911004-5061";
            Name = "Daniella";
            LastName = "Dani";
            Phone = "076-2266322";
            Address = "Amiralsgatan 3";
            PostalCode = "217 22";
            City = "Malmö";
        }
        else
        {
            Console.WriteLine("Studenten finns inte med i listan.");
        }
    }
      public override string ToString()
    {
        return $"{base.ToString()}";
    }
    
}
