using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using TaskFlow.Models;

namespace TaskFlow.Services;

public class FileManager
{
    private readonly string _filePath = "tasks.json";

    public bool JsonExist()
    {
        return File.Exists(_filePath);
    }

    public void CreateJson()
    {
        if (!JsonExist())
        {
            // Inicializar con un arreglo JSON vacío
            File.WriteAllText(_filePath, "[]");
        }
    }

    public List<TaskItem> ReadJson()
    {
        CreateJson(); // Asegurarnos de que el archivo existe antes de leer
        string json = File.ReadAllText(_filePath);
        return JsonSerializer.Deserialize<List<TaskItem>>(json) ?? new List<TaskItem>();
    }

    public void WriteJson(List<TaskItem> tasks)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(tasks, options);
        File.WriteAllText(_filePath, json);
    }
}
