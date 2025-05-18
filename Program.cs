using EjerciosListas.Models;

Console.WriteLine("ingrese los siguiente datos al padre de familia");

Console.WriteLine("ingreso tu  nombre");
string nombre = Console.ReadLine();
Console.WriteLine("ingreso tu  sexo");
string sexo = Console.ReadLine();
Console.WriteLine("ingreso tu  edad");
int edad = int.Parse(Console.ReadLine());
////string sexo = "masculino";
//int edad = 48;

Console.WriteLine("ingreso tu numero  pasatiempo");
string cantidad = Console.ReadLine();
int cantidadparciada = 0;

//int valor = int.tryparse(Console.ReadLine());
if (int.TryParse(cantidad, out int respuesta))
{
    cantidadparciada = respuesta;
}

List<string> listapasatiempo = new();
//listapasatiempo.add("canto");
//listapasatiempo.add("bailar");
//listapasatiempo.add("cocinar");

for (int i = 0; i < cantidadparciada; i++)
{
    Console.WriteLine("ingreso tu pasatiempo ❤" + i);

    listapasatiempo.Add(Console.ReadLine());
}

Persona nuevpersona = new();
nuevpersona.Nombre = nombre;
nuevpersona.Sexo = sexo;
nuevpersona.Edad = edad;

nuevpersona.Pasatiempos = listapasatiempo;
Console.WriteLine(nuevpersona.Nombre);
Console.WriteLine(nuevpersona.Sexo);
Console.WriteLine(nuevpersona.Edad);
Console.WriteLine(nuevpersona.Pasatiempos);
foreach (var item in nuevpersona.Pasatiempos)
{
    Console.WriteLine(item);
}


Console.WriteLine("ingrese los siguiente datos del hijo");
Console.WriteLine("ingreso el   nombre");
string nombrehijo = Console.ReadLine();
Console.WriteLine("ingreso el  sexo");
string sexohijo = Console.ReadLine();
Console.WriteLine("ingreso la  edad");
int edadhijo = int.Parse(Console.ReadLine());

Console.WriteLine("ingreso el numero  de maestro de tu grado");
string cantidadmaestro = Console.ReadLine();
int carmestro = 0;

if (int.TryParse(cantidadmaestro, out int respuestamaestro))
{
    carmestro = respuestamaestro;
}
List<string> listamaestro = new();
for (int i = 0; i < carmestro; i++)
{
    Console.WriteLine("ingreso el nombre del maestro" + i);
    listamaestro.Add(Console.ReadLine());
}
Hijo nuevhijo = new();
nuevhijo.NombreProfesores = listamaestro;

foreach (var item in nuevhijo.NombreProfesores)
{
    Console.WriteLine(item);
}