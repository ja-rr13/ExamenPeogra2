using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Empleados
    {
        public static string[] cedula = new string[10];
        public static string[] nombre = new string[10];
        public static float[] salario = new float[10];
        public static string[] numero = new string[10];
        public static string[] direccion = new string[10];
        public static void InicializarArreglos()
        {
            for (int i = 0; i < cedula.Length; i++)
            {
                cedula[i] = "";
                nombre[i] = "";
                salario[i] = 0;
                numero[i] = "";
                direccion[i]="";
                

            }
            Console.WriteLine("Se inicializo correctamente");

        }

        public static void ModificarEmpleado()
        {
            string nuevo = "";
            Console.WriteLine("Digite el numero de cedula del empleado a modificar");
            nuevo = Console.ReadLine();
            for (int i = 0; i < cedula.Length; i++)
            {
                if (nuevo == cedula[i])
                {
                    Console.WriteLine("Digite el numero de cedula");
                    cedula[i] = Console.ReadLine();
                    Console.WriteLine("Digite el nombre del empleado");
                    nombre[i] = Console.ReadLine();
                    Console.WriteLine("Digite el salario del empleado");
                    salario[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el numero de telefono del empleado");
                    numero[i] = Console.ReadLine();
                    Console.WriteLine("Digite la direccion del empleado");
                    direccion[i] = Console.ReadLine();

                }

            }
        }
        public static void AgregarEmpleado()
        {
            for (int i = 0; i < cedula.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Digite el numero de cedula");
                cedula[i] = Console.ReadLine();
                Console.WriteLine("Digite el nombre del empleado");
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Digite el salario del empleado");
                salario[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite el numero de telefono del empleado");
                numero[i] = Console.ReadLine();
                Console.WriteLine("Digite la direccion del empleado");
                direccion[i] = Console.ReadLine();


            }

        }
        public static void BorrarEmpleado()
        {
            string borrar = "";
            Console.WriteLine("Digite el numero de cedula del empleado a borrar");
            borrar = Console.ReadLine();
          
            for (int i = 0; i < cedula.Length; i++)
            {
                if (borrar == cedula[i])
                {
                    cedula[i] = "";
                    nombre[i] = "";
                    salario[i] = 0;
                    numero[i] = "";
                    direccion[i] = "";

                }


            }

        }
        public static void Reportes()
        {
            int op = 0;
            Console.WriteLine("1.Lista de empleados");
            Console.WriteLine("2.Promedio de salarios");
            op = int.Parse(Console.ReadLine());
            if (op==1)
            {
                for (int i = 0; i < cedula.Length; i++)
                {
                    Console.WriteLine($"Cedula: {cedula[i]} Nombre: {nombre[i]} Salario: {salario[i]} Direccion {direccion[i]} Numero{numero[i]}");

                }
            }
            else if (op==2)
            {
                float suma = 0;
                float prom = 0;
                int n = 0;
                for (int i = 0; i < salario.Length; i++)
                {
                   Console.WriteLine("Salarios = "+salario[i]);
                }
                for (int i = 0; i < salario.Length; i++)
                {
                    if (salario[i] > 0)
                    {
                        suma += salario[i];
                        n++;
                    }
                        
                }
                prom = suma / n;
                Console.WriteLine($"El promedio de salarios es {prom}");


            }


        } 
        public static void ConsultarEmpleado()
        {
            string buscar = "";
            Console.WriteLine("Digite el numero de cedula del empleado a buscar");
            buscar = Console.ReadLine();
            for (int i = 0; i < cedula.Length; i++)
            {
                if (buscar == cedula[i])
                {
                    Console.WriteLine($"Cedula: {cedula[i]} Nombre: {nombre[i]} Salario: {salario[i]} Direccion {direccion[i]} Numero{numero[i]}");
                    break;

                }


            }

        }

    }
}
