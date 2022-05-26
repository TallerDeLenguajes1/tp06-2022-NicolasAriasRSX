namespace Punto1;
static class Program
{
    public static int Main(string[] args)
    {
        double inicial, entrada;
        int operacion;

        Console.WriteLine("Bienvenidos a la calculadora circular acumuladora\nIngrese un numero inicial ->  ");
        inicial= Convert.ToDouble(Console.ReadLine());
        Calculadora calcula = new Calculadora(inicial);
        do
        {
            Console.WriteLine("Que operacion desea hacer:\nSumar -> 1\nRestar -> 2\nMultiplicar -> 3\nDividir -> 4\nLimpiar -> 5");
            operacion= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            entrada= Convert.ToDouble(Console.ReadLine());
            switch (operacion)
            {
                case 1:
                    Console.WriteLine("resultado= " + calcula.Sumar(entrada));
                    break;
                case 2:
                    Console.WriteLine("resultado= " + calcula.Restar(entrada));
                    break;
                case 3:
                    Console.WriteLine("resultado= " + calcula.Multiplicar(entrada));
                    break;
                case 4:
                    if (entrada != 0)
                    {
                        Console.WriteLine("resultado= " + calcula.Dividir(entrada));
                    }else{
                        Console.WriteLine("No es posible realizar esta operacion, dividir en 0 no esta definido.");
                    }
                    break;
                case 5:
                    calcula.Limpiar();
                    Console.WriteLine("Se limpio el resultado.");
                    break;
                default:
                    Console.WriteLine("Error de selección.");
                    break;
            }
            Console.WriteLine("Desea realizar otrea operacion?\n1 -> SI\n2 ->NO\nSeleccion ->");
            operacion= Convert.ToInt32(Console.ReadLine());
        } while (operacion == 1);
        
        return 0;
    }
}