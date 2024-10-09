using System.Security.Cryptography.X509Certificates;

namespace WestcoastEducation;

public class Courses : IManage
{

    /* PROPERTIES */
    public string CourseId{ get; set; } = " ";
    public int Length { get; set; }  
    public string Title { get; set; } = " ";
    public DateTime StartDate { get; set; } 
    public DateTime EndDate { get; set; }
    public bool Location { get; set; } 
    public string LocationInfo { get; set; } = " ";

    public List <Courses> courses = [];
    
    /* METHODS */
    public void Add(Courses course)
    {
        courses.Add(course);
    }

     public void Find(string courseId)
    { 
        if (courseId == "PRO110")
        {
            CourseId = "PRO110";
            Title = "Programmering med C#/.Net";
            Length = 56;
            StartDate = DateTime.Now;
            EndDate = StartDate.AddDays(Length);
            Location = true;
            
        }
        else if (courseId == "DAT101")
        {
            CourseId = "DAT101";
            Title = "Databasteknik";
            Length = 22;
            StartDate = DateTime.Now.AddDays(56);
            EndDate = StartDate.AddDays(Length);
            Location = true;
        }
        else if (courseId == "PRO202")
        {
            CourseId = "PRO202";
            Title = "Programmering med C#/.Net fortsättning";
            Length = 50;
            StartDate = DateTime.Now.AddDays(78);
            EndDate = StartDate.AddDays(Length);
            Location = true;
        }
        else if (courseId == "LED332")
        {
            CourseId = "LED332";
            Title = "Ledarskap och organisation fortsättning";
            Length = 14;
            StartDate = DateTime.Now.AddDays(128);
            EndDate = StartDate.AddDays(Length);
            Location = false;
        }
        else
        {
            Console.WriteLine("Kursen finns inte med i listan");
        }
    }

    public void ListAll ()
    {
        foreach (var course in courses)
        {
            Console.WriteLine(course.ToString());
        }
    }   

    public override string ToString()
    {
        if(Location == true){
            LocationInfo = "Klassrum";
        }
        else {
            LocationInfo = "Distans";
        }

        return $"\nKursnummer: {CourseId}\nTitel: {Title}\nStartdatum: {StartDate}\nSlutdatum: {EndDate}\nAntal dagar: {Length}\nPlats: {LocationInfo}\n";
    } 

}
