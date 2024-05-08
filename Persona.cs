public class Persona
{
    public string Nombre;
    public int Edad;
    public string EstadoCivil;
    public Persona(string nombre, int edad, string estadoCivil)
    {
        Nombre = nombre;
        Edad = edad;
        EstadoCivil = estadoCivil;
    }

    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
        EstadoCivil = "Soltero";
    }

    public Persona(string nombre)
    {
        Nombre = nombre;
        Edad = 0;
        EstadoCivil = "Soltero";
    }
}