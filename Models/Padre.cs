namespace EjerciosListas.Models;

public class Padre : Persona
{
    public string DireccionTreabajo { get; set; } = string.Empty;
    public int Telefono { get; set; }
    public string Cargo { get; set; } = string.Empty;
    public string ColorOjos { get; set; } = string.Empty;
    public List<string> DireccioTrabajo { get; set; } = new();

    // Constructor sin parámetros
    public Padre()
    {
    }

    // Constructor con parámetros
    public Padre(string nombre, string sexo, int edad, List<string> pasatiempos, string direccionTreabajo, int telefono, string cargo, string colorOjos, List<string> direccioTrabajo)
    {
        Nombre = nombre;
        Sexo = sexo;
        Edad = edad;
        Pasatiempos = pasatiempos;
        DireccionTreabajo = direccionTreabajo;
        Telefono = telefono;
        Cargo = cargo;
        ColorOjos = colorOjos;
        DireccioTrabajo = direccioTrabajo;
    }
}
