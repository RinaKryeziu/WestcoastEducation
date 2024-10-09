namespace WestcoastEducation;

public class Employees : PersonalInfo, IManage
{
    /* PROPERTIES */
    public string? SubjectArea { get; set; } 
    public List<Courses> ResponsibleCourses = [];
    

    /* METHODS */
    
    public void AddResponsibleCourses(Courses course)
    {
        ResponsibleCourses.Add(course);
    }

    public virtual void Find(string socialSecurityNumber){}

    public virtual void ListAll(){}

    public override string ToString()
    {
        string responsibleCourses = " ";
        foreach (var course in ResponsibleCourses)
        {
            if(responsibleCourses != " "){
                responsibleCourses += ", ";
            } 
            responsibleCourses += course.Title;                                                     

        }
        return $"{base.ToString()}Kunskapsområde: {SubjectArea}\nAnsvarig för kurserna: {responsibleCourses}";
    }

}
