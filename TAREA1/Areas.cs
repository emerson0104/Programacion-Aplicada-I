using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA1.TAREA1
{
    public class Areasp
    {
        int Lad;
        double Per, Ar;
        float Long, Apo;

        public void CalcularArea()
        {
            Console.WriteLine("Escriba la cantida de lados:");
            Lad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el apotema:");
          Long = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Escriba la longitud de lados:");
          Apo = Convert.ToSingle(Console.ReadLine());
            Per = Lad * Long;
            Ar = Per * Apo;
            Console.WriteLine("EL area es: {0}", Ar);


        }

        public void Perimetro()
        {
          //  float longitud, perimetro;

            Console.WriteLine("Escriba la cantidad de lados del poligono: ");
              Lad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba  la longitud de uno de los lados del poligono: ");
               Long = Convert.ToSingle(Console.ReadLine());

              Per = Lad * Long;
            Console.WriteLine("El perimetro de este poligono es: {0}", Per);
        }
    }
}
