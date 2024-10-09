namespace WestcoastEducation;

class Program
{
    static void Main()
    {
        Courses courses = new Courses();
        var courseList = new List<Courses>();

        Courses course1 = new Courses();
        course1.Find ("PRO110");
        courses.Add(course1);
        courseList.Add(course1);

        Courses course2 = new Courses();
        course2.Find ("DAT101");
        courses.Add(course2);
        courseList.Add(course2);

        Courses course3 = new Courses();
        course3.Find ("PRO202");
        courses.Add(course3);
        courseList.Add(course3);

        Courses course4 = new Courses();
        course4.Find ("LED332");
        courses.Add(course4);
        courseList.Add(course4);

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Kurser: ");
        Console.WriteLine("...................................................");
        Console.ResetColor();

        courses.ListAll();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("...................................................");
        Console.ResetColor();

        //JSON
        var path = string.Concat(Environment.CurrentDirectory + "/Data/course.json");

        Json.WriteJson(path, courseList);

        var coursesFromFile = Json.ReadJson(path);

        Console.WriteLine("");
        Console.WriteLine("Json - Kurser:");

        foreach (var jsonCourses in coursesFromFile)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine(jsonCourses);
        }
        Console.ResetColor();
        Console.WriteLine("...................................................");

        //Studenter
        Students student = new Students();

        Students student1 = new Students();
        student1.Find ("19990325-4521");
        student.Add(student1);

        Students student2 = new Students();
        student2.Find("19950920-8131");
        student.Add(student2);

        Students student3 = new Students();
        student3.Find ("20010117-5255");
        student.Add(student3);

        Students student4 = new Students();
        student4.Find ("19911004-5061");
        student.Add(student4);

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Studenter: ");
        Console.WriteLine("...................................................");
        Console.ResetColor();

        student.ListAll();

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("...................................................");
        Console.ResetColor();

        //Lärare
        Teachers teachers = new Teachers();

        Teachers teacher1 = new Teachers();
        teacher1.Find ("19680412-1291");
        teachers.Add(teacher1);

        Teachers teacher2 = new Teachers();
        teacher2.Find ("19791104-3022");
        teachers.Add(teacher2);

        teacher1.AddResponsibleCourses(course1);
        teacher1.AddResponsibleCourses(course2);
        teacher2.AddResponsibleCourses(course3);
        teacher2.AddResponsibleCourses(course4);
      
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Lärare: ");
        Console.WriteLine("...................................................");
        Console.ResetColor();

        teachers.ListAll();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("...................................................");
        Console.ResetColor();

        //Utbildningsledare
        EducationLeaders educationLeaders = new EducationLeaders();

        EducationLeaders educationLeader1 = new EducationLeaders();
        educationLeader1.Find ("19780304-9242");
        educationLeaders.Add(educationLeader1);

        EducationLeaders educationLeader2 = new EducationLeaders();
        educationLeader2.Find ("19800522-5262");
        educationLeaders.Add(educationLeader2);

        educationLeader1.AddResponsibleCourses(course1);
        educationLeader1.AddResponsibleCourses(course2);
        educationLeader2.AddResponsibleCourses(course3);
        educationLeader2.AddResponsibleCourses(course4);
      
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Utbildningsledare ");
        Console.WriteLine("...................................................");
        Console.ResetColor();

        educationLeaders.ListAll();

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("...................................................");
        Console.ResetColor();
        
        //Administratörer
        Administrators administrator = new Administrators();
        administrator.Find ("19801222-7232");
        administrator.Add(administrator);

        administrator.AddResponsibleCourses(course1);
        administrator.AddResponsibleCourses(course2);
        administrator.AddResponsibleCourses(course3);
        administrator.AddResponsibleCourses(course4);

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Administratörer");
        Console.WriteLine("...................................................");
        Console.ResetColor();

        administrator.ListAll();

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("...................................................");
        Console.ResetColor();
      
      
        
    }
}
    
