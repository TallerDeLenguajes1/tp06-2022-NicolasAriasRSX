namespace Punto1;

public class Calculadora
{
    private double resultado;

    public Calculadora(double numInicial)//Constructor, inicia con el valor ingresado.
    {
        resultado= numInicial;
    }
    public double Sumar(double termino)
    {
        resultado += termino;
        return resultado;
    }
    public double Restar(double termino)
    {
        resultado -= termino;
        return resultado;
    }
    public double Multiplicar(double termino)
    {
        resultado *= termino;
        return resultado;
    }
    public double Dividir(double termino)
    {
        resultado /= termino;
        return resultado;
    }
    public void Limpiar()
    {
        resultado= 0;
    }
    // public double MostrarResultado()
    // {
    //     return resultado;
    // }
}