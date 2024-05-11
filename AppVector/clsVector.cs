using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppVector
{
    class clsVector
    {
        // Propiedades del Vector
        //Especificar tipo de datos
        private int[] vector;
        private int lg;

        //Constructor -> Inicializar las propiedades
        public clsVector()
        {
            lg = 0;
            vector = new int[100];
        }

        //Metodos ( VOID->procedimientos o funciones)
        public void adicionar(int e)
        {

            vector[lg] = e;
            lg = lg + 1;

        }

        // obtener el valor en la posicion p
        public int obtenerValor(int pos)
        {
            return vector[pos];
        }

        // Longitud del vector
        public int longitud()
        {
            return lg;
        }

        //Eliminar ultimo elemento del vector
        public void eliminarUlt()
        {
            vector[lg] = 0;
            lg = lg - 1;
        }




        //Obtener un elemento en la posicion
        public int obtenerElemento(int p)
        {
            return vector[p];
        }

        //Invertir los elementos del vector
        public void invertir()
        {
            int fin = lg - 1;
            int mitad = lg / 2;
            int i = 0;
            int aux = 0;
            while (i < mitad)
            {
                aux = vector[fin - i];
                vector[fin - i] = vector[i];
                vector[i] = aux;
                i++;
            }
        }
        //Cantidad elementos pares
        public int cantPares()
        {
            int cont = 0;
            for (int i = 0; i < lg; i++)
            {
                if (vector[i] % 2 == 0)
                    cont++;
            }
            return cont;
        }
        //Ordenar los elementos del vector de menor a mayor
        public void OrdenarMenorMayor()
        {
            int aux = 0;
            for (int i = 0; i < lg; i++)
            {
                for (int j = i; j < lg; j++)
                {
                    if (vector[i] > vector[j])
                    {
                        aux = vector[j];
                        vector[j] = vector[i];
                        vector[i] = aux;
                    }
                }
            }
        }


        //Eliminar elemento en la posición
        public void eliminarElementoPos(int p)
        {
            lg = vector.Length;
            for (int i = p - 1; i < lg; i++)
            {
                vector[i] = vector[i + 1];
            }
            lg = lg - 1;
        }

        public void InvertCadaElementVector()
        {
            int fin = lg - 1;
            int mitad = lg / 2;
            int i = 0;
            int aux = 0;
            while (i < mitad)
            {
                aux = vector[fin - i];
                vector[fin - i] = vector[i];
                vector[i] = aux;
                i++;
            }
            for (var j = lg; j < lg; j++)
            {
                string num = vector[j].ToString(); // Convertir en cadena
                char[] numV = num.ToCharArray(); // cadena ev vector
                Array.Reverse(numV); // Invierte orden
                string revNum = new string(numV); // Convierte vector invertido en una cadena
                vector[j] = int.Parse(revNum); // Convierte la cadena invertida nuevamente en un número y lo asigna al vector
            }
        }

        public int CantElemCapicua()
        {
            int capicua = 0;

            for (int i = 0; i < lg; i++)
            {
                int num = vector[i];
                int ac = 0;
                int aux = num;

                while (num > 0)
                {
                    int r = num % 10;
                    ac = (ac * 10) + r;
                    num = num / 10;
                }

                if (ac == aux)
                {
                    capicua++;
                }
            }

            return capicua;
        }

        public int CantNumeroPrimo()
        {
            int cantidadPrimos = 0;

            for (int i = 0; i < lg; i++)
            {
                int num = vector[i];
                int c = 0;

                for (int j = 1; j <= num; j++)
                {
                    if (num % j == 0)
                    {
                        c++;
                    }
                }

                if (c == 2)
                {
                    cantidadPrimos++;
                }
            }

            return cantidadPrimos;
        }

    }
}

    
