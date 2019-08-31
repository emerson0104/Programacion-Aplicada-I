using System;
namespace TAREA1.TAREA1
{


    public class Imprimir
    {
        public void escribir()
        {

            Console.WriteLine("Mi Nombre es Emerson Del orbe Candelario");
            Console.WriteLine(" Hola!!");
        }
        public void Tabla()
        {
            int Num, Res;

            Console.WriteLine("Escriba el numero  a Multiplicar: ");
            Num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Res = Num * i;
                Console.WriteLine(" " + Num + " * " + i + " = " + Res + "\n");
            }
        }
    }
}