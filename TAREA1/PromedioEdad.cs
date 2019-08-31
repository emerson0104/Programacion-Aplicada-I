using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA1.TAREA1

{ 
public class PromedioEdad
{
        int Mayor = 0, Menor = 0, Promedio = 0, Ac = 0;
        public void Edades()
        {
            int Edad;

         for (int i = 1; i <= 10; i++)
            {
             Console.Write("Escriba la Edad: ");
               Edad = Convert.ToInt32(Console.ReadLine());
                Ac += Edad;

                if (i == 1)
                {
                    Mayor = Edad;
                    Menor =Edad;
                }
                else
                {
                    if (Edad > Mayor)
                    {
                        Mayor = Edad;
                    }
                    if (Edad < Menor)
                    {
                        Menor = Edad;
                    }
                }
            }
            Promedio = Ac / 10;

            Resultado();
        }

        private void Resultado()
        {
            Console.Clear();
            Console.WriteLine("La Edad mayor tiene {0} años", Mayor);
            Console.WriteLine("La Edad menor tiene {0} años", Menor);
            Console.WriteLine("El promedio de edad  es de {0} años", Promedio);
        }

    }
}
