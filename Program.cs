// En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500, realizar un programa que lea los sueldos que 
// cobra cada empleado e informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más de $300. Además el programa 
// deberá informar el importe que gasta la empresa en sueldos al personal.

using System;
using System.Security.Cryptography.X509Certificates;

namespace n_empleados
{
    class Program
    {
        static void Main(string[] args)
        {
            int sueldo=0, total_sueldos=0, x=1, cant_menos300=0, cant_mayor300=0;


            while (x == 1)
            {
                Console.Write("Ingrese el sueldo: ");
                sueldo = int.Parse(Console.ReadLine());
                total_sueldos = total_sueldos + sueldo;
                if (sueldo > 300)
                {
                    cant_mayor300 = cant_mayor300 + 1;
                }
                else
                {
                    cant_menos300 = cant_menos300 + 1;
                }
                Console.Write("Seguir ingresando sueldos(si=1, no=0): ");
                x = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine($"La cantidad de personas que cobran menos de 300 es: {cant_menos300}");
            Console.WriteLine($"La cant de personas que cobra mas de 300 es: {cant_mayor300}");
            Console.ReadKey();
        }
    }
}