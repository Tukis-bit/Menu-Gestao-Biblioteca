using System.Text.Json;
using Biblioteca.Modelos;

static class JsonStorage
{
    private static readonly string BaseDir = AppContext.BaseDirectory;
    private static readonly string ProjectDir = Path.GetFullPath(Path.Combine(BaseDir, "..", "..", ".."));
    private static readonly string Caminho = Path.Combine(ProjectDir, "data", "database.json");

    public static void Salvar(Database db)
    {
        var directory = Path.GetDirectoryName(Caminho);
        if (directory != null)
            Directory.CreateDirectory(directory);

        var json = JsonSerializer.Serialize(db, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText(Caminho, json);
    }

    public static Database Carregar()
    {
        if (!File.Exists(Caminho))
        {
            return new Database();
        }

        var json = File.ReadAllText(Caminho);

        var db = JsonSerializer.Deserialize<Database>(json);
        if (db == null)
            return new Database();

        return db;
    }
}
