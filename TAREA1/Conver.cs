using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA1.TAREA1
{
    public class CONVER
    {
        public void Rad()
        {
            string GV;
            float Grad;
            double Radia;

            Console.WriteLine("Digite el grado a convertir: ");
            GV= Console.ReadLine();
            Grad = Convert.ToSingle(GV);

         Radia = (double)Grad * Math.PI / 180;

            Console.WriteLine("{0} convertido a radianes es: {1}", Grad, Radia);
        }

        public void CelsusAFarenhei()
        {
            string Cant;
            float Cel;
            double Faren;

            Console.WriteLine("Escriba  la temperatura: ");
            Cant = Console.ReadLine();
            Cel = Convert.ToSingle(Cant);
            Faren = (Cel * 9 / 5) + 32;

            Console.WriteLine("La cantidad convertida a Farenheit es :{0}", Faren);
        }

        public void ConverDolarAEuro()
        {
            float Us;
            double Euros;
            string Cant;

            Console.WriteLine("Escriba la cantidad en USD: ");
            Cant = Console.ReadLine();
            Us = Convert.ToSingle(Cant);

            Euros = Us * 0.90;

            Console.WriteLine("Cantidad Convertida: {0}", Euros);
        }
        public void MostrarDia()
        {
            string Val;
            int i;

            Console.WriteLine("Escriba un numero (1 - 7): ");
            Val = Console.ReadLine();
            i = Convert.ToInt32(Val);

            switch (i)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Lunes");
                    break;
                case 3:
                    Console.WriteLine("Martes");
                    break;
                case 4:
                    Console.WriteLine("Miercoles");
                    break;
                case 5:
                    Console.WriteLine("Jueves");
                    break;
                case 6:
                    Console.WriteLine("Viernes");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;
                default:
                    Console.WriteLine("Opcion No Valida!!");
                    break;
            }
        }
    }
}


  
