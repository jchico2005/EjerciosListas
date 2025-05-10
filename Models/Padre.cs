namespace EjerciosListas.Models;

public class Padre : Persona
{
    public string DireccionTreabajo { get; set; } = string.Empty;
    public int Telefono { get; set; }
    public string Cargo { get; set; } = string.Empty;
    public string ColorOjos { get; set; } = string.Empty;
    public List<string> DireccioTrabajo { get; set; } = new();
}
