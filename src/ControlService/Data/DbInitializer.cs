using System.Text.Json;
using MongoDB.Driver;
using MongoDB.Entities;

namespace ControlService.Entities;

public class DbInitializer
{
    public static async Task InitDb(WebApplication app)
    {
        await DB.InitAsync("ControlDb", MongoClientSettings
            .FromConnectionString(app.Configuration
            .GetConnectionString("MongoDbConnection")));

        await DB.Index<Control>()
           .Key(c => c.Name, KeyType.Ascending) // Definiert das Feld, für das der Index erstellt werden soll
           .Option(o => o.Unique = true) // Stellt sicher, dass der Index einzigartig ist
           .CreateAsync();

        await DB.Index<Tenant>()
           .Key(c => c.TenantId, KeyType.Ascending) // Definiert das Feld, für das der Index erstellt werden soll
           .Option(o => o.Unique = true) // Stellt sicher, dass der Index einzigartig ist
           .CreateAsync();

        var count = await DB.CountAsync<Control>();

        if (count == 0)
        {
            Console.WriteLine("No controls data - will attempt to seed");

            //Controls seeden
            var itemData = await File.ReadAllTextAsync("Data/controls.json");

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var items = JsonSerializer.Deserialize<List<Control>>(itemData, options);

            await DB.SaveAsync(items);
        }


        count = await DB.CountAsync<Tenant>();

        if (count == 0)
        {
            Console.WriteLine("No tenants data - will attempt to seed");

            //Tenants seeden
            var itemData = await File.ReadAllTextAsync("Data/tenants.json");

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var items = JsonSerializer.Deserialize<List<Tenant>>(itemData, options);

            await DB.SaveAsync(items);
        }
    }
}
