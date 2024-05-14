public class Racional
{
    private int _numerador;
    private int _denominador;
    public Racional(int numerador, int denominador)
    {
        _numerador = numerador;
        _denominador = denominador;
    }

    public Racional Sumar(Racional sumando)
    {
        return new Racional(_numerador * sumando._denominador + sumando._numerador * _denominador, _denominador * sumando._denominador);
    }

    public static Racional operator +(Racional a, Racional b)
    {
        return new Racional(a._numerador * b._denominador + b._numerador * a._denominador, a._denominador * b._denominador);
    }

    public static Racional operator +(Racional a, int b)
    {
        return new Racional(a._numerador + b * a._denominador, a._denominador);
    }
    public Racional Multiplicar(Racional multiplicando)
    {
        return new Racional(_numerador * multiplicando._numerador, _denominador * multiplicando._denominador);
    }
    public static Racional operator *(Racional a, Racional b)
    {
        return new Racional(a._numerador * b._numerador, a._denominador * b._denominador);
    }
    public Racional Dividir(Racional dividiendo)
    {
        try
        {
            if (dividiendo._numerador == 0)
            {
                throw new DivideByZeroException();
            }
            return new Racional(_numerador * dividiendo._denominador, _denominador * dividiendo._numerador);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("No está permitida la división por 0");
            return new Racional(0, 0);
        }
        finally
        {
        }
    }
    public static Racional operator /(Racional a, Racional b)
    {
        try
        {
            if (b._numerador == 0)
            {
                throw new DivideByZeroException();
            }
            return new Racional(a._numerador * b._denominador, a._denominador * b._numerador);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("No está permitida la división por 0");
            return new Racional(0, 0);
        }
        finally
        {
            Console.WriteLine("Fin de la división");
        }
    }
}