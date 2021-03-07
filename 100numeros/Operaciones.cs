using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100numeros
{
    class Operaciones
    {
        int numero;
        int cuarta = 0;
        int cubo = 0;


        public void presentacion()
        {
            Console.WriteLine("NUMEROS ELEVADOS AL CUBO Y LA CUARTA POTENCIA.");

        }

       


        public void operacionescc ()
        {
            for (int i = 0; i <=100 ; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Dame el numero {0}: ",i+1);
                numero = Convert.ToInt32(Console.ReadLine());


                cubo = numero * numero * numero;
                cuarta = numero * numero * numero * numero;


                Console.WriteLine(" ");

                
                Console.WriteLine("Este es el cubo del numero {0} : {1} ", i + 1, cubo);
                Console.WriteLine("Esta es la cuarta potencia del numero {0} : {1} ", i + 1, cuarta);
                Console.WriteLine(" ");
                Console.WriteLine("-------------------------------------------------------------------");
            }




        

        }



    
    }
}
