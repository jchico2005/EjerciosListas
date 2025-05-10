namespace EjerciosListas.Models;

public class Persona
{
    public string Nombre { get; set; }= string .Empty;
    public string Sexo { get; set; } = string.Empty;
    public int Edad { get; set; }
    public List<string> Pasatiempos { get; set; } = new();   
}
