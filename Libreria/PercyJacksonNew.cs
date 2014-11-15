using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class PercyJacksonNew
    {

        private List<int> LibrosA = new List<int>();
        private List<int> LibrosB = new List<int>();
        private List<int> LibrosC = new List<int>();
        private List<int> LibrosD = new List<int>();
        private List<int> LibrosE = new List<int>();

        double suma = 0;

        public double SumaPrecioTotalNew(int A, int B, int C, int D, int E)
        {
            //* Precios
            //* 1->	$.8
            //* 2->	$.15,2
            //* 3->	$.21,6
            //* 4->	$.25,6
            //* 5->	$.30 

            int numeromayor = 0;

            List<int> numeros = new List<int>() {A,B,C,D,E};

            //  A	B	C	D	E
            //  {5	4	4	3	0}

            for (int i = 0; i < 5; i++)
            {
                if (numeros[i] > numeromayor)
                {
                    numeromayor = numeros[i];
                }
            }

            // Numero Mayor = 5

            //***********************************************************************//
            
            for (int i = 0; i < numeromayor; i++) { LibrosA.Insert(i, 0); }
            for (int i = 0; i < numeromayor; i++) { LibrosB.Insert(i, 0); }
            for (int i = 0; i < numeromayor; i++) { LibrosC.Insert(i, 0); }
            for (int i = 0; i < numeromayor; i++) { LibrosD.Insert(i, 0); }
            for (int i = 0; i < numeromayor; i++) { LibrosE.Insert(i, 0); }

            //  A	B	C	D	E
            //  5	4	4	3	0

            //A->	0	0	0	0	0
            //B->	0	0	0	0	0
            //C->	0	0	0	0	0
            //D->	0	0	0	0	0
            //E->	0	0	0	0	0    -----> Porque si no sale Nullos


            //***********************************************************************//
            for (int i = 0; i < A; i++) { LibrosA.Insert(i, 1); }
            for (int i = 0; i < B; i++) { LibrosB.Insert(i, 1); }
            for (int i = 0; i < C; i++) { LibrosC.Insert(i, 1); }
            for (int i = 0; i < D; i++) { LibrosD.Insert(i, 1); }
            for (int i = 0; i < E; i++) { LibrosE.Insert(i, 1); }

            //  A	B	C	D	E
            //  5	4	4	3	0

            //A->	1	1	1	1	1
            //B->	1	1	1	1	0
            //C->	1	1	1	1	0
            //D->	1	1	1	0	0
            //E->	0	0	0	0	0    -----> Ahora LLenamos con dígitos de numero 1

            //***********************************************************************//


            for (int i = 0; i < numeromayor; i++)
            {
                if ((LibrosA[i] + LibrosB[i] + LibrosC[i] + LibrosD[i] + LibrosE[i]) == 1)
                {
                    suma += 8;
                }

                if ((LibrosA[i] + LibrosB[i] + LibrosC[i] + LibrosD[i] + LibrosE[i]) == 2)
                {
                    suma += 15.2;
                }

                if ((LibrosA[i] + LibrosB[i] + LibrosC[i] + LibrosD[i] + LibrosE[i]) == 3)
                {
                    suma += 21.6;
                }

                if ((LibrosA[i] + LibrosB[i] + LibrosC[i] + LibrosD[i] + LibrosE[i]) == 4)
                {
                    suma += 25.6;
                }

                if ((LibrosA[i] + LibrosB[i] + LibrosC[i] + LibrosD[i] + LibrosE[i]) == 5)
                {
                    suma += 30;
                }
            }



            //  A	B	C	D	E
            //  5	4	4	3	0
            //   -----> Ahora Insertamos con dígitos de numero 1

            //A->	1	    1	    1    	1	    1
            //B->	1	    1	    1	    1	    0
            //C->	1	    1	    1	    1	    0
            //D->	1	    1	    1	    0    	0
            //E->	0	    0	    0    	0    	0 
            //      ↓       ↓       ↓       ↓       ↓
            //     25.6  + 25.6  + 25.6  + 21.6  +  8 = 106.4

            //***********************************************************************//

            return suma;

        }
    }
}