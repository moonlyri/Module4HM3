using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Module4HM3;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory());
        builder.AddJsonFile("myjson.json");
        var config = builder.Build();
        var connectionstring = config.GetConnectionString("DefaultConnection");

        var optionsbuilder = new DbContextOptionsBuilder<ApplicationContext>();
        var options = optionsbuilder
            .UseSqlServer(connectionstring)
            .Options;
        
        using (var db = new ApplicationContext(options){}

        Console.Read();
    }
}