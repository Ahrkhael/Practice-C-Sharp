using System;
using System.Threading;

namespace Cornway
{
    class Program
    {

        static int [,] ContarVecinosVivosCelda(string[,] malla)
        {
            int [,] contador = new int [malla.GetLength(0), malla.GetLength(1)];
            int fila = contador.GetLength(0) - 1;
            int columna = contador.GetLength(1) - 1;
            for (int i = 0; i <= fila; i++)
            {
                for (int j = 0; j <= columna; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        if (malla[i + 1, j] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i, j + 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i + 1, j + 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                    }
                    else if (i == 0 && j == columna)
                    {
                        if (malla[i + 1, j] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i, j - 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i + 1, j - 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                    }
                    else if (i == 0 && j != 0 && j != columna)
                    {
                        if (malla[i + 1, j] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i, j - 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i, j + 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i + 1, j - 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i + 1, j + 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                    }
                    else if (i == fila && j == 0)
                    {
                        if (malla[i - 1, j] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i, j + 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i - 1, j + 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                    }
                    else if (i == fila && j == columna)
                    {
                        if (malla[i - 1, j] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i, j - 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i - 1, j - 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                    }
                    else if (i == fila && j != 0 && j != columna)
                    {
                        if (malla[i - 1, j] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i, j - 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i, j + 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i - 1, j - 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i - 1, j + 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                    }
                    else if (i != 0 && i != fila && j == 0)
                    {
                        if (malla[i - 1, j] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i - 1, j + 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i, j + 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i + 1, j] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i + 1, j + 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                    }
                    else if (i != 0 && i != fila && j == columna)
                    {
                        if (malla[i - 1, j] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i - 1, j - 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i, j - 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i + 1, j] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i + 1, j - 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                    }
                    else
                    {
                        if (malla[i - 1, j - 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i - 1, j] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i - 1, j + 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i, j - 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i, j + 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i + 1, j -1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i + 1, j] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                        if (malla[i + 1, j + 1] == " * ")
                        {
                            contador[i, j] += 1;
                        }
                    }
                    
                }
            }

            return contador;
        }

        static void Cornway(int filas, int columnas, int final)
        {

            //Creamos la malla que hará de "tablero"

            string[,] malla = new string[filas,columnas];
            string tablero = "";
            int[,] vecinosVivos;
            Random random = new Random();
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    int estado = random.Next(0, 2);
                    if (estado == 1)
                    {
                        //La célula está viva
                        malla[i, j] = " * ";
                    }
                    else
                    {
                        malla[i, j] = "   ";
                    }
                    
                }
                
            }
            for (int k = 0; k < final; k++)
            {
                vecinosVivos = ContarVecinosVivosCelda(malla);
                for (int i = 0; i < malla.GetLength(0); i++)
                {
                    for (int j = 0; j < malla.GetLength(1); j++)
                    {
                        if (malla[i,j] == "   ")
                        {
                            if (vecinosVivos[i,j] == 3)
                            {
                                malla[i, j] = " * ";
                            }
                        }
                        else
                        {
                            if (vecinosVivos[i,j] != 2 && vecinosVivos[i,j] != 3)
                            {
                                malla[i, j] = "   ";
                            }
                        }
                    }
                }
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        tablero += malla[i, j];
                    }
                    tablero += "\n";
                }
                Console.Clear();
                Console.WriteLine(tablero);
                Thread.Sleep(500);
                tablero = "";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca las dimensiones de la malla del juego de la vida: (separar con comas) ");
            string posicion = Console.ReadLine();
            posicion = posicion.Replace(" ", "");
            string[] array = posicion.Split(',');
            int fila = Convert.ToInt32(array[0]);
            int columna = Convert.ToInt32(array[1]);
            Console.WriteLine("¿Cuántas iteraciones desea? ");
            int turnos = Convert.ToInt32(Console.ReadLine());
            Cornway(fila, columna, turnos);

        }
    }
}
