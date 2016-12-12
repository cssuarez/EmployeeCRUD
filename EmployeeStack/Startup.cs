using System.Threading.Tasks;

public class Startup
{
    public async Task<object> Invoke(object input)
    {
        return new Person(){
            Name="Carlos",
            Occupation="Full Stack Developer",
            Salary=30000,
            City="Cordoba"
        };
    }
}

public class Person{
    public string Name { get; set; }
    public string Occupation { get; set; }
    public double Salary { get; set; }
    public string City { get; set; }
}
