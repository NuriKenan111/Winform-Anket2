using System.Text.Json;

namespace Anket2;
public partial class Database
{
    List<Person> _person = new List<Person>();
    public List<Person> GetPerson() => _person;
    
    public Database()
    {
        LoadDataFromJson();
    }
    public void AddPerson(Person person)
    {
        ClearPersonJsonFile();
        _person.Add(person);
        UpdatePersonJsonFile();
    }
    
    public void LoadDataFromJson()
    {
        LoadDataFromFile("Person.json", out _person);
       
    }
    public void UpdatePersonJsonFile()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(_person, options);
        File.WriteAllText("Person.json", jsonString);
    }
   
    public void ClearPersonJsonFile() => File.WriteAllText("Person.json", string.Empty);
    

    private void LoadDataFromFile<T>(string fileName, out List<T> dataList)
    {
        dataList = new List<T>();
        if (File.Exists(fileName))
        {
            string jsonData = File.ReadAllText(fileName);
            try
            {
                if (!string.IsNullOrEmpty(jsonData))
                {
                    dataList = JsonSerializer.Deserialize<List<T>>(jsonData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("JSON Deserialize Error: " + ex.Message);
                Console.ReadLine();
            }
        }
    }
}