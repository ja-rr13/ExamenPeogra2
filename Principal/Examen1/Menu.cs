using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Menu
    {
        public static void MenuPrincipal()
        {
            int opcion = 0;
            do
            {

                Console.WriteLine("1.Inicializar los arreglos");
                Console.WriteLine("2.Agregar empledos");
                Console.WriteLine("3.Consultar empleados");
                Console.WriteLine("4.Modificar empleados");
                Console.WriteLine("5.Borrar empleado");
                Console.WriteLine("6.Reporte");
                Console.WriteLine("7.Salir");
                Console.WriteLine("Digite una opcion");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: Empleados.InicializarArreglos(); break;
                    case 2: Empleados.AgregarEmpleado(); break;
                    case 3: Empleados.ConsultarEmpleado(); break;
                    case 4: Empleados.ModificarEmpleado(); break;
                    case 5: Empleados.BorrarEmpleado(); break;
                    case 6: Empleados.Reportes(); break;
                    case 7: break;
                    default: Console.WriteLine("Opcion incorrecta"); break;
                }
            } while (opcion != 7);


        }
    }
}
