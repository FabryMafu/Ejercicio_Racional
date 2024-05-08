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
        return new Racional(_numerador * dividiendo._denominador, _denominador * dividiendo._numerador);
    }
        public static Racional operator /(Racional a, Racional b)
    {
        return new Racional(a._numerador * b._denominador, a._denominador * b._numerador);
    }
}