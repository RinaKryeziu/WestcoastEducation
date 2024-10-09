namespace WestcoastEducation;

public class Administrators : EducationLeaders, IManage
{
    public List<Administrators> administrators = [];


    /* METHODS */
    public void Add(Administrators administrator)
    {
        administrators.Add(administrator);
    } 

    public override void ListAll()
    {
        foreach(var administrator in administrators )
        {
            Console.WriteLine(administrator.ToString());
        }
    }

    public override void Find(string socialSecurityNumber)
    {

        if (socialSecurityNumber == "19801222-7232")
        {
            SocialSecurityNumber = "19801222-7232";
            Name = "Peter";
            LastName = "Karlsson";
            Phone = "073-9944333";
            Address = "Helgonavägen 3";
            PostalCode = "432 11";
            City = "Göteborg";
            SubjectArea = "Administratör";
            EmploymentDate = DateTime.Now.AddYears(-7).AddMonths(-9).AddDays(-3);
        }
        else 
        {
            Console.WriteLine("Administratorn finns inte med i listan.");
        }
    }

    public override string ToString()
    {
        return $"{base.ToString()}";
    }
}
