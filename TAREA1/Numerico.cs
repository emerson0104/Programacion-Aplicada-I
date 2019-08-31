using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA1.TAREA1{

public class Numericos
{
        public void ParOImpar()
        {
            int Num;

            Console.WriteLine("Digite un numero: ");
            Num = Convert.ToInt32(Console.ReadLine());

            if( Num% 2== 0)
                Console.WriteLine("Es par");
            else
                Console.WriteLine("Es Impar");

        }
        public void Potencia()
        {
            int Num, Pot;
            double Res;

            Console.WriteLine("Escriba el Numero");
                Num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el Exponente");
                Pot= Convert.ToInt32(Console.ReadLine());

            Res = Math.Pow(Num, Pot);

            Console.WriteLine("La Potencia es: {0}", Res);
        }
    }
}