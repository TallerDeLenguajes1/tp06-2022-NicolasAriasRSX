namespace Punto1;
static class Program
{
    public static int Main(string[] args)
    {
        System.Console.WriteLine("Ingrese el punto que desea ver");
        int respuesta= Convert.ToInt32(Console.ReadLine());
        switch (respuesta)
        {
            case 1:
            PuntoUno();
            break;
            case 2:
            PuntoDos();
            break;
            default:
            System.Console.WriteLine("Error al seleccionar el punto");
            break;
        }
        //PuntoUno();
        void PuntoUno(){

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
            
        }
        void PuntoDos()
        {
            Empleado empleado1 = new Empleado("Juan", "Diaz", new DateTime(1989,2,16), 'S', 'M', new DateTime(2023,3,2), 24000, cargos.Especialista);
            Empleado empleado2 = new Empleado("Pepe", "Romario", new DateTime(1974,2,9), 'C', 'M', new DateTime(2011,7,12), 14000, cargos.Administrativo);
            Empleado empleado3 = new Empleado("Maria", "Burgos", new DateTime(1981,11,23), 'C', 'F', new DateTime(2007,4,23), 34000,cargos.Ingeniero);
             
            empleado1.MostrarInfo();
            empleado2.MostrarInfo();
            empleado3.MostrarInfo();
            System.Console.WriteLine("Monto salarial total: {0:N2}", TotalSalarios());
            SeJubila();
        }
        double TotalSalarios()
        {
            Empleado empleado1 = new Empleado("Juan", "Diaz", new DateTime(1989,2,16), 'S', 'M', new DateTime(2023,3,2), 24000, cargos.Especialista);
            Empleado empleado2 = new Empleado("Pepe", "Romario", new DateTime(1974,2,9), 'C', 'M', new DateTime(2011,7,12), 14000, cargos.Administrativo);
            Empleado empleado3 = new Empleado("Maria", "Burgos", new DateTime(1981,11,23), 'C', 'F', new DateTime(2007,4,23), 34000,cargos.Ingeniero);
            double total= 0;
            total= empleado1.Salario() + empleado2.Salario() + empleado3.Salario();
            return total;
        }
        void SeJubila()
        {
            Empleado empleado1 = new Empleado("Juan", "Diaz", new DateTime(1989,2,16), 'S', 'M', new DateTime(2023,3,2), 24000, cargos.Especialista);
            Empleado empleado2 = new Empleado("Pepe", "Romario", new DateTime(1974,2,9), 'C', 'M', new DateTime(2011,7,12), 14000, cargos.Administrativo);
            Empleado empleado3 = new Empleado("Maria", "Burgos", new DateTime(1981,11,23), 'C', 'F', new DateTime(2007,4,23), 34000,cargos.Ingeniero);
            if(empleado1.Edad() >= empleado2.Edad() && empleado1.Edad() >= empleado3.Edad())
            {
                empleado1.MostrarInfo();
            }
              if(empleado2.Edad() >= empleado1.Edad() && empleado2.Edad() >= empleado3.Edad())
            {
                empleado2.MostrarInfo();
            }
              if(empleado3.Edad() >= empleado1.Edad() && empleado3.Edad() >= empleado2.Edad())
            {
                empleado3.MostrarInfo();
            }
        }
        return 0;
    }
}