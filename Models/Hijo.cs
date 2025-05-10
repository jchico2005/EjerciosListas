namespace EjerciosListas.Models;

public class Hijo: Persona
{
    public string NombreEscuela { get; set; } = string.Empty;
    public string ActividadEscolar { get; set; } = string.Empty;
    public List<string> NombreProfesores { get; set; } = new();

}

