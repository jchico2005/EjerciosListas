using EjerciosListas.Models;

Console.WriteLine("Ingrese Los siguiente Datos Al PAdre de Familia");

Console.WriteLine("Ingreso tu  Nombre");
string nombre = Console.ReadLine();
Console.WriteLine("Ingreso tu  Sexo");
string sexo = Console.ReadLine();
Console.WriteLine("Ingreso tu  Edad");
int edad = int.Parse(Console.ReadLine());
////string sexo = "Masculino";
//int edad = 48;

Console.WriteLine("Ingreso tu numero  Pasatiempo");
string cantidad = Console.ReadLine();
int cantidadParciada = 0;

//int valor = int.TryParse(Console.ReadLine());
if (int.TryParse(cantidad, out int respuesta))
{
    cantidadParciada = respuesta;
}

List<string> listaPasatiempo = new();
//listaPasatiempo.Add("Canto");
//listaPasatiempo.Add("Bailar");
//listaPasatiempo.Add("Cocinar");

for (int i = 0; i < cantidadParciada; i++)
{
    Console.WriteLine("Ingreso tu Pasatiempo ❤" + i);

    listaPasatiempo.Add(Console.ReadLine());
}

Persona nuevPersona = new();
nuevPersona.Nombre = nombre;
nuevPersona.Sexo = sexo;
nuevPersona.Edad = edad;

nuevPersona.Pasatiempos = listaPasatiempo;
Console.WriteLine(nuevPersona.Nombre);
Console.WriteLine(nuevPersona.Sexo);
Console.WriteLine(nuevPersona.Edad);
Console.WriteLine(nuevPersona.Pasatiempos);
foreach (var item in nuevPersona.Pasatiempos)
{
    Console.WriteLine(item);
}


