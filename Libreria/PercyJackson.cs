using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class PercyJackson
    {
        private List<int> Libros = new List<int>();

        double suma = 0;

        public double SumaPrecioTotal(int A, int B,  int C,  int D,  int E)
        {
            /*
             * Mi Lógica
             * Precio por cada Libro
             * 1->	$.8
             * 2->	$.15,2
             * 3->	$.21,6
             * 4->	$.25,6
             * 5->	$.30 
             
             * { A , B , C , D , E }
             * { 4 , 5 , 2 , 3 , 1 } Restamos 1 a cada posición, suma = 30
             * { 3 , 4 , 1 , 2 , 0 } 30 + 25.6 = 55.6
             * { 2 , 3 , 0 , 1 , 0 } 55.6 + 21.6 = 77.2
             * { 1 , 2 , 0 , 0 , 0 } 77.2 + 15.2 = 92.4
             * { 0 , 1 , 0 , 0 , 0 } 92.4 + 8 = 100.4

             */

            Libros.Add(A);
            Libros.Add(B);
            Libros.Add(C);
            Libros.Add(D);
            Libros.Add(E);

            do
            {
                CincoLibros();
                CuatroLibros();
                TresLibros();
                DosLibros();
                UnLibro();
            }

            while ((Libros[0] > 0) || (Libros[1] > 0) || (Libros[2] > 0) || (Libros[3] > 0) || (Libros[4] > 0));

            return suma;

        }


        private void Disminuir()
        {
            Libros[0] = Libros[0] - 1;
            Libros[1] = Libros[1] - 1;
            Libros[2] = Libros[2] - 1;
            Libros[3] = Libros[3] - 1;
            Libros[4] = Libros[4] - 1;
        }

        private void UnLibro()
        {
            //0,0,0,0,1 = 1
            if ((Libros[0] <= 0) && (Libros[1] <= 0) && (Libros[2] <= 0) && (Libros[3] <= 0) && (Libros[4] > 0))
            {
                suma += 8;
                Disminuir();
            }

            //0,0,0,1,0 = 2
            if ((Libros[0] <= 0) && (Libros[1] <= 0) && (Libros[2] <= 0) && (Libros[3] >= 0) && (Libros[4] <= 0))
            {
                suma += 8;
                Disminuir();
            }


            //0,0,1,0,0 = 4
            if ((Libros[0] <= 0) && (Libros[1] <= 0) && (Libros[2] > 0) && (Libros[3] <= 0) && (Libros[4] <= 0))
            {
                suma += 8;
                Disminuir();
            }


            //0,1,0,0,0 = 8
            if ((Libros[0] <= 0) && (Libros[1] > 0) && (Libros[2] <= 0) && (Libros[3] <= 0) && (Libros[4] <= 0))
            {
                suma += 8;
                Disminuir();
            }


            //1,0,0,0,0 = 8
            if ((Libros[0] > 0) && (Libros[1] <= 0) && (Libros[2] <= 0) && (Libros[3] <= 0) && (Libros[4] <= 0))
            {
                suma += 8;
                Disminuir();
            }
        }

        private void DosLibros()
        {
            //0,0,0,1,1 = 3
            if ((Libros[0] <= 0) && (Libros[1] <= 0) && (Libros[2] <= 0) && (Libros[3] > 0) && (Libros[4] > 0))
            {
                suma += 15.2;
                Disminuir();
            }

            //0,0,1,0,1 = 5
            if ((Libros[0] <= 0) && (Libros[1] <= 0) && (Libros[2] > 0) && (Libros[3] <= 0) && (Libros[4] > 0))
            {
                suma += 15.2;
                Disminuir();
            }

            //0,0,1,1,0 = 6
            if ((Libros[0] <= 0) && (Libros[1] <= 0) && (Libros[2] > 0) && (Libros[3] > 0) && (Libros[4] <= 0))
            {
                suma += 15.2;
                Disminuir();
            }


            //0,0,1,1,0 = 6
            if ((Libros[0] <= 0) && (Libros[1] <= 0) && (Libros[2] > 0) && (Libros[3] > 0) && (Libros[4] <= 0))
            {
                suma += 15.2;
                Disminuir();
            }

            //0,1,0,0,1 = 9
            if ((Libros[0] <= 0) && (Libros[1] > 0) && (Libros[2] <= 0) && (Libros[3] <= 0) && (Libros[4] > 0))
            {
                suma += 15.2;
                Disminuir();
            }

            //0,1,0,1,0 = 10
            if ((Libros[0] <= 0) && (Libros[1] > 0) && (Libros[2] <= 0) && (Libros[3] > 0) && (Libros[4] <= 0))
            {
                suma += 15.2;
                Disminuir();
            }

            //0,1,1,0,0 = 12
            if ((Libros[0] <= 0) && (Libros[1] > 0) && (Libros[2] > 0) && (Libros[3] <= 0) && (Libros[4] <= 0))
            {
                suma += 15.2;
                Disminuir();
            }

            //1,0,0,0,1 = 17
            if ((Libros[0] > 0) && (Libros[1] <= 0) && (Libros[2] <= 0) && (Libros[3] <= 0) && (Libros[4] > 0))
            {
                suma += 15.2;
                Disminuir();
            }

            //1,0,1,0,0 = 20
            if ((Libros[0] > 0) && (Libros[1] <= 0) && (Libros[2] > 0) && (Libros[3] <= 0) && (Libros[4] <= 0))
            {
                suma += 15.2;
                Disminuir();
            }

            //1,1,0,0,0 = 24
            if ((Libros[0] > 0) && (Libros[1] > 0) && (Libros[2] <= 0) && (Libros[3] <= 0) && (Libros[4] <= 0))
            {
                suma += 15.2;
                Disminuir();
            }
        }

        private void TresLibros()
        {
            //0,0,1,1,1
            if ((Libros[0] <= 0) && (Libros[1] <= 0) && (Libros[2] > 0) && (Libros[3] > 0) && (Libros[4] > 0))
            {
                suma += 21.6;
                Disminuir();
            }

            //1,0,0,1,1
            if ((Libros[0] > 0) && (Libros[1] <= 0) && (Libros[2] <= 0) && (Libros[3] > 0) && (Libros[4] > 0))
            {
                suma += 21.6;
                Disminuir();
            }

            //1,1,0,0,1
            if ((Libros[0] > 0) && (Libros[1] > 0) && (Libros[2] <= 0) && (Libros[3] <= 0) && (Libros[4] > 0))
            {
                suma += 21.6;
                Disminuir();
            }

            //1,1,1,0,0
            if ((Libros[0] > 0) && (Libros[1] > 0) && (Libros[2] > 0) && (Libros[3] <= 0) && (Libros[4] <= 0))
            {
                suma += 21.6;
                Disminuir();
            }

            //0,1,1,1,0
            if ((Libros[0] <= 0) && (Libros[1] > 0) && (Libros[2] > 0) && (Libros[3] > 0) && (Libros[4] <= 0))
            {
                suma += 21.6;
                Disminuir();
            }

            //1,0,1,0,1
            if ((Libros[0] > 0) && (Libros[1] <= 0) && (Libros[2] > 0) && (Libros[3] <= 0) && (Libros[4] > 0))
            {
                suma += 21.6;
                Disminuir();
            }

            //0,1,0,1,1
            if ((Libros[0] <= 0) && (Libros[1] > 0) && (Libros[2] <= 0) && (Libros[3] > 0) && (Libros[4] > 0))
            {
                suma += 21.6;
                Disminuir();
            }

            //1,1,0,1,0
            if ((Libros[0] > 0) && (Libros[1] > 0) && (Libros[2] <= 0) && (Libros[3] > 0) && (Libros[4] <= 0))
            {
                suma += 21.6;
                Disminuir();
            }

            //0,1,1,0,1
            if ((Libros[0] <= 0) && (Libros[1] > 0) && (Libros[2] > 0) && (Libros[3] <= 0) && (Libros[4] > 0))
            {
                suma += 21.6;
                Disminuir();
            }

            //1,0,1,1,0
            if ((Libros[0] > 0) && (Libros[1] <= 0) && (Libros[2] > 0) && (Libros[3] > 0) && (Libros[4] <= 0))
            {
                suma += 21.6;
                Disminuir();
            }
        }

        private void CuatroLibros()
        {
            if ((Libros[0] <= 0) && (Libros[1] > 0) && (Libros[2] > 0) && (Libros[3] > 0) && (Libros[4] > 0))
            {
                suma += 25.6;
                Disminuir();
            }

            //1,0,1,1,1
            if ((Libros[0] > 0) && (Libros[1] <= 0) && (Libros[2] > 0) && (Libros[3] > 0) && (Libros[4] > 0))
            {
                suma += 25.6;
                Disminuir();
            }

            if ((Libros[0] > 0) && (Libros[1] > 0) && (Libros[2] <= 0) && (Libros[3] > 0) && (Libros[4] > 0))
            {
                suma += 25.6;
                Disminuir();
            }

            if ((Libros[0] > 0) && (Libros[1] > 0) && (Libros[2] > 0) && (Libros[3] <= 0) && (Libros[4] > 0))
            {
                suma += 25.6;
                Disminuir();
            }

            if ((Libros[0] > 0) && (Libros[1] > 0) && (Libros[2] > 0) && (Libros[3] > 0) && (Libros[4] <= 0))
            {
                suma += 25.6;
                Disminuir();
            }
        }

        private void CincoLibros()
        {
            if ((Libros[0] > 0) && (Libros[1] > 0) && (Libros[2] > 0) && (Libros[3] > 0) && (Libros[4] > 0))
            {
                suma += 30;
                Disminuir();
            }
        }

    }
}
