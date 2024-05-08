public class Matematica
{
    public int Sumar(int a, int b)
    {
        Console.WriteLine("Sumando enteros");
        return a + b;
    }

    public double Sumar(double a, double b)
    {
        Console.WriteLine("Sumando flotantes");
        return a + b;
    }

    public double Sumar(string a, string b)
    {
        Console.WriteLine("Sumando cadenas");
        return Convert.ToDouble(a) + Convert.ToDouble(b);
    }
    /* public double Dividir(int a, int b)
    {
        using (StreamReader reader = )
        /*
        var doble = 0.0;
        try
        {
            doble = a / b;
            Console.WriteLine("El resultado es {0}", doble);
            return doble;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("No está permitida la division por 0");
            return 0.0;
        }
        finally
        {
            Console.WriteLine("Fin de la división");
        }
        */
    }