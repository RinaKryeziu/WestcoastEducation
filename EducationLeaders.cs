namespace WestcoastEducation;

public class EducationLeaders : Teachers, IManage
{
    /* PROPERTIES */
    public DateTime EmploymentDate { get; set; } 
    public List<EducationLeaders> educationLeaders  = [];

    /* METHODS */
    public void Add(EducationLeaders educationLeader)
    {
        educationLeaders.Add(educationLeader);
    }

    public override void ListAll()
    {
        foreach(var educationLeader in educationLeaders )
        {
            Console.WriteLine(educationLeader.ToString());
        }
    }
  
    public override void Find(string socialSecurityNumber)
    {
          if (socialSecurityNumber == "19780304-9242")
        {
            SocialSecurityNumber = "19780304-9242";
            Name = "Miranda";
            LastName = "Axelsson";
            Phone = "076-3355320";
            Address = "Vasavägen 22";
            PostalCode = "411 22";
            City = "Göteborg";
            SubjectArea = "Utbildningsledare";
            EmploymentDate = DateTime.Now.AddYears(-4).AddMonths(-5).AddDays(7);
        }
        else if (socialSecurityNumber == "19800522-5262")
        {
            SocialSecurityNumber = "19800522-5262";
            Name = "Caroline";
            LastName = "Johansson";
            Phone = "073-5552550";
            Address = "Trevägen 3";
            PostalCode = "444 77";
            City = "Göteborg";
            SubjectArea = "Utbildningsledare";
            EmploymentDate = DateTime.Now.AddYears(-2).AddMonths(-1);
        }
        else 
        {
            Console.WriteLine("Utbildningsledaren finns inte med i listan.");
        }
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nAnställningsdatum: {EmploymentDate}";
    }
}
