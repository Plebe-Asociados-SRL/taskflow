using System;

namespace TaskFlow.Services;

public static class ValidacionesService
{
    public static void ValidarTarea(string title, string responsible)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("El título de la tarea no puede estar vacío.");
            
        if (string.IsNullOrWhiteSpace(responsible))
            throw new ArgumentException("El responsable de la tarea no puede estar vacío.");
    }

    public static string ValidarEntradaTexto(string input, string nombreCampo)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentException($"El {nombreCampo} no puede estar vacío.");
        }
        return input;
    }

    public static bool ValidarId(string input, out int id)
    {
        return int.TryParse(input, out id) && id > 0;
    }
}
