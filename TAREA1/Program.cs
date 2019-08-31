using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAREA1.TAREA1;

namespace TAREA1
{

    class PRINCIPAL
    { public static void Menus()
        {
            Console.Clear();
            Console.WriteLine("Escriba la Opcion que desees segun los Sigtes Numeros: ");
            Console.WriteLine("     1. Escribir Nombre y Imprime por pantalla");
            Console.WriteLine("     2. Convertir USD a EURO");
            Console.WriteLine("     3. Convertir Grados a Radianes");
            Console.WriteLine("     4. Convertir Celsius a Farenheit");
            Console.WriteLine("     5. Determinar si un numero es par o impar");
            Console.WriteLine("     6. Imprimir la tabla de multiplicar de un numero");
            Console.WriteLine("     7. Sacar la potencia a un numero Dado");
            Console.WriteLine("     8. Determinar el area de un poligono regular");
            Console.WriteLine("     9. Determinar el perimetro de un poligono regular");
            Console.WriteLine("     10. Imprimir el dia de la semana segun su numero");
            Console.WriteLine("     11. Determinar cual es la edad mayor, menor y su  promedio de 10 edades");
            Console.WriteLine("     12. Salir");
        }
        static void Main(string[] args)
        {
         // CONVER


            int Op;
            do
            {
                Menus();

                Op = Convert.ToInt32(Console.ReadLine());

                switch (Op)
                {
                    case 1:
                        Console.Clear();
                        Imprimir i = new Imprimir();
                        i.escribir();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                     CONVER d = new CONVER();
                   d.ConverDolarAEuro();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                       CONVER t= new CONVER();
                        t.Rad();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        CONVER r = new CONVER();
                       r.CelsusAFarenhei();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Numericos par = new Numericos();
                      par.ParOImpar();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                     Imprimir l = new Imprimir();
                        l.Tabla();
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                      Numericos p = new Numericos();
                             p.Potencia();
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                      Areasp n= new Areasp();
                      n.CalcularArea();
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                      n = new Areasp();
                       n.Perimetro();
                        Console.ReadKey();
                        break;
                    case 10:
                        Console.Clear();
                      CONVER dia = new CONVER();
                     dia.MostrarDia();
                        Console.ReadKey();
                        break;
                    case 11:
                        Console.Clear();
                       PromedioEdad   pr = new PromedioEdad();
                        pr.Edades();
                        Console.ReadKey();
                        break;
                    case 12:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                     // Console.WriteLine(" Opcion Invalida!!");
                        Console.ReadKey();
                        break;
                }
            } while (Op != 11);
        }




    }
}