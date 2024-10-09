namespace WestcoastEducation;
using System.Text.Encodings.Web;
using System.Text.Json;

public class Json
{
    private static JsonSerializerOptions _options = new JsonSerializerOptions()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };
    
    public static void WriteJson (string path, List<Courses>courseList) 
    {
        var json = JsonSerializer.Serialize(courseList, _options);
        File.WriteAllText(path, json);
    }

    public static List<Courses>ReadJson(string path)
    {
        _options = new JsonSerializerOptions 
        {
            PropertyNameCaseInsensitive = true
        };

        var json = File.ReadAllText(path);
        var courses = JsonSerializer.Deserialize<List<Courses>>(json, _options);
        return courses!;  
    }

    

   



    /* private static JsonSerializerOptions _options = new JsonSerializerOptions()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };

    //1. Skapa en static metod för att spara ner objekt till json
    public static void WriteJson (string path, List<Courses>courseList) 
    {
        var json = JsonSerializer.Serialize(courseList, _options);
        File.WriteAllText(path, json);
    }

    public static List<Courses>ReadJson(string path)
    {
        _options = new JsonSerializerOptions 
        {
            PropertyNameCaseInsensitive = true
        };

        var json = File.ReadAllText(path);
        var courses = JsonSerializer.Deserialize<List<Courses>>(json, _options);
        return courses!;  
    }


var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            WriteIndented = true
        };
        var json = JsonSerializer.Serialize(courseList, options);

        var path = string.Concat(Environment.CurrentDirectory + "/Data/course.json");
        File.WriteAllText(path, json); */


}
