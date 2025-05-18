namespace EjerciosListas.Models;

public class Hijo: Persona
{
    public string NombreEscuela { get; set; } = string.Empty;
    public string ActividadEscolar { get; set; } = string.Empty;
    public List<string> NombreProfesores { get; set; } = new();

    public Hijo()
    {
        
    }

    public Hijo(string nombre, string sexo, int edad,  string nombreEscuela, string actividadEscolar, List<string> nombreProfesores)
    {
        Nombre = nombre;
        Sexo = sexo;
        Edad = edad;
        NombreEscuela = nombreEscuela;
        ActividadEscolar = actividadEscolar;
        NombreProfesores = nombreProfesores;
    }

}

