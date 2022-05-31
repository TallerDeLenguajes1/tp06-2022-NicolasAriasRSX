namespace Punto1
{
    
    public enum cargos
    {Auxiliar,
    Administrativo, 
    Ingeniero, 
    Especialista, 
    Investigador
    };
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private char genero;
        private DateTime fechaIngreso;
        private double sueldobasico;
        private cargos cargo;
        public Empleado(string nom, string ape, DateTime fechaNac, char estCivil, char gen, DateTime fechaIng, double sueldoBac, cargos carg)
        {
            nombre= nom;
            apellido= ape;
            fechaNacimiento= fechaNac;
            estadoCivil= estCivil;
            genero= gen;
            fechaIngreso= fechaIng;
            sueldobasico= sueldoBac;
            cargo= carg;
        }
        public int Antiguedad()
        {
            DateTime fechaActual= DateTime.Now;
            int antig= fechaActual.Year - fechaIngreso.Year;
            if(fechaIngreso.Month >= fechaActual.Month && fechaIngreso.Day >= fechaActual.Day)
            {
                return antig;
            }
            else
            {
                antig--;
                return antig;
            }
        }
        public int Edad()
        {
            DateTime fechaActual= DateTime.Now;
            int cantidadAnios= fechaActual.Year - fechaNacimiento.Year;
            if(fechaActual.Month >= fechaNacimiento.Month && fechaActual.Day >= fechaNacimiento.Day)
            {
                return cantidadAnios;
            }
            else
            {
                cantidadAnios--;
                return cantidadAnios;
            }
        }
        public double Salario()
        {
            double adicional= 0;
            if(Antiguedad() <= 20)
            {
                adicional+= sueldobasico * Antiguedad() * 0.1f;
            }
            else
            {
                adicional += sueldobasico * 0.25f;
            }

            if(estadoCivil == 'C')
            {
                adicional += 15000;
            }
            return sueldobasico + adicional;
        }
        public int Jubilacion()
        {
            int edadJubilacion;
            int seJubila;
            if(genero == 'F')
            {
                edadJubilacion= 60;
            }else
            {
                edadJubilacion= 65;
            }
            seJubila= edadJubilacion - Edad();
            return seJubila;
        }
        public void MostrarInfo()
        {
            System.Console.WriteLine("Nombre: " + nombre);
            System.Console.WriteLine("Apellido: " + apellido);
            System.Console.WriteLine("Fecha de nacimiento: {0:d}", fechaNacimiento);
            System.Console.WriteLine("Estado civil: " + estadoCivil);
            System.Console.WriteLine("Genero: " + genero);
            System.Console.WriteLine("Fecha de ingreso: {0:d}", fechaIngreso);
            System.Console.WriteLine("Sueldo: {0:N2}", Salario());
            System.Console.WriteLine("Cargo: " + cargo.ToString());
            System.Console.WriteLine("Edad: " + Edad());
            System.Console.WriteLine("Años para jubilacion: " + Jubilacion());
            System.Console.WriteLine("-------------------------------------------");
        }
    }

}