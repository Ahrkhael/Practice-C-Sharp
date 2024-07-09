using System;
namespace Buscaminas
{
    class Program
    {
        static string[,] CrearTableroVacio (int filas, int columnas)
        {
            //Creamos la malla que hará de "tablero"

            string[,] malla = new string[filas, columnas];
            
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    malla[i, j] = " ";
                }
            }
            return malla;
        }

        static string[,] LlenarTablero (string [,] tableroVacio, int minas)
        {
            //Creamos la malla que hará de "tablero"
            string[,] malla = tableroVacio;
            Random random = new Random();
            int minasTablero = 0;
            int filaMina;
            int columnaMina;
            while (minasTablero < minas)
            {
                filaMina = random.Next(0, malla.GetLength(0));
                columnaMina = random.Next(0, malla.GetLength(1));
                if ( malla[filaMina, columnaMina] != "X")
                {
                    malla[filaMina, columnaMina] = "X";
                    minasTablero++;
                }
            }

            for (int i = 0; i < malla.GetLength(0); i++)
            {
                for (int j = 0; j < malla.GetLength(1); j++)
                {
                    if (malla[i,j] == " ")
                    {
                        malla[i, j] = Convert.ToString(MinasVecinas(malla,i,j));
                    }
                }
            }
            return malla;
        }

        static void MostrarTablero(string [,] malla, bool [,] visible)
        {
            string tablero = "";
            for (int i = 0; i < malla.GetLength(0); i++)
            {
                for (int j = 0; j < malla.GetLength(1); j++)
                {
                    if (visible[i, j])
                    {
                        tablero += malla[i, j];
                    }
                    else
                    {
                        tablero += "·";
                    }
                }
                tablero += "\n";
            }
            Console.WriteLine(tablero);
        }
        static void MostrarTableroDerrota(string[,] malla)
        {
            string tablero = "";
            for (int i = 0; i < malla.GetLength(0); i++)
            {
                for (int j = 0; j < malla.GetLength(1); j++)
                {
                    tablero += malla[i, j];
                }
                tablero += "\n";
            }
            Console.WriteLine(tablero);
            Console.WriteLine("Has perdido el juego");
        }

        static int MinasVecinas(string [,] malla, int fila, int columna)
        {
            int numeroMinas = 0;
            try
            {
                if (malla[fila - 1, columna - 1] == "X")
                {
                    numeroMinas++;
                }                   
            }
            catch
            {

            }
            try
            {
                if (malla[fila, columna - 1] == "X")
                {
                    numeroMinas++;
                }
            }
            catch
            {

            }
            try
            {
                if (malla[fila + 1, columna - 1] == "X")
                {
                    numeroMinas++;
                }
            }
            catch
            {

            }
            try
            {
                if (malla[fila - 1, columna] == "X")
                {
                    numeroMinas++;
                }
            }
            catch
            {

            }
            try
            {
                if (malla[fila + 1, columna] == "X")
                {
                    numeroMinas++;
                }
            }
            catch
            {

            }
            try
            {
                if (malla[fila - 1, columna + 1] == "X")
                {
                    numeroMinas++;
                }
            }
            catch
            {

            }
            try
            {
                if (malla[fila, columna + 1] == "X")
                {
                    numeroMinas++;
                }
            }
            catch
            {

            }
            try
            {
                if (malla[fila + 1, columna + 1] == "X")
                {
                    numeroMinas++;
                }
            }
            catch
            {

            }
            return numeroMinas;
        }
        static bool RevelarCasilla(int fila, int columna, string[,] malla, ref bool[,] visible)
        {
            if (visible[fila, columna])
            {
                return true;
            }
            if (malla[fila, columna] == "X")
            {
                return false;
            }
            else
            {
                visible[fila, columna] = true;
                if (malla[fila, columna] == "0")
                {
                    try
                    {
                        if (RevelarCasilla(fila - 1, columna - 1, malla, ref visible))
                        {
                            visible[fila - 1, columna - 1] = true;
                        }
                    }
                    catch
                    {

                    }
                    try
                    {
                        if (RevelarCasilla(fila, columna - 1, malla, ref visible))
                        {
                            visible[fila, columna - 1] = true;
                        }
                    }
                    catch
                    {

                    }
                    try
                    {
                        if (RevelarCasilla(fila + 1, columna - 1, malla, ref visible))
                        {
                            visible[fila + 1, columna - 1] = true;
                        }
                    }
                    catch
                    {

                    }
                    try
                    {
                        if (RevelarCasilla(fila - 1, columna, malla, ref visible))
                        {
                            visible[fila - 1, columna] = true;
                        }
                    }
                    catch
                    {

                    }
                    try
                    {
                        if (RevelarCasilla(fila + 1, columna, malla, ref visible))
                        {
                            visible[fila + 1, columna] = true;
                        }
                    }
                    catch
                    {

                    }
                    try
                    {
                        if (RevelarCasilla(fila - 1, columna + 1, malla, ref visible))
                        {
                            visible[fila - 1, columna + 1] = true;
                        }
                    }
                    catch
                    {

                    }
                    try
                    {
                        if (RevelarCasilla(fila, columna + 1, malla, ref visible))
                        {
                            visible[fila, columna + 1] = true;
                        }
                    }
                    catch
                    {

                    }
                    try
                    {
                        if (RevelarCasilla(fila + 1, columna + 1, malla, ref visible))
                        {
                            visible[fila + 1, columna + 1] = true;
                        }
                    }
                    catch
                    {

                    }
                }
                return true;
            }
        }
        static int casillasPorRevelar(bool[,] visible)
        {
            int casillas = 0;
            for (int i = 0; i < visible.GetLength(0); i++)
            {
                for (int j = 0; j < visible.GetLength(1); j++)
                {
                    if (visible[i, j] == false)
                    {
                        casillas++;
                    }
                }
            }
            return casillas;
        }
        static bool Victoria(int minas, int casillasPorRevelar, string[,] tablero, bool [,] mallaVisible)
        {
            if (minas != casillasPorRevelar)
            {
                return false;
            }
            else
            {
                Console.Clear();
                MostrarTablero(tablero, mallaVisible);
                Console.WriteLine("Enhorabuena, has ganado la partida");
                return true;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca las dimensiones de la malla del juego del buscaminas: (separar con comas) ");
            string malla = Console.ReadLine();
            malla = malla.Replace(" ", "");
            string[] array = malla.Split(',');
            int fila = Convert.ToInt32(array[0]);
            int columna = Convert.ToInt32(array[1]);
            string[,] tableroVacio = CrearTableroVacio(fila, columna);
            Console.WriteLine("¿Cuántas minas desea? ");
            int nMinas = Convert.ToInt32(Console.ReadLine());
            string[,] tablero = LlenarTablero(tableroVacio, nMinas);
            bool [,] mallaVisible = new bool [fila, columna];
            do
            {
                Console.Clear();
                MostrarTablero(tablero, mallaVisible);
                Console.WriteLine("¿En qué posición crees que no hay bomba?");
                string malla2 = Console.ReadLine();
                malla2 = malla2.Replace(" ", "");
                string[] array2 = malla2.Split(',');
                int fila2 = Convert.ToInt32(array2[0]) - 1;
                int columna2 = Convert.ToInt32(array2[1]) - 1;
                if (RevelarCasilla(fila2, columna2, tablero, ref mallaVisible) == false)
                {
                    MostrarTableroDerrota(tablero);
                    break;
                }
            }
            while (Victoria(nMinas, casillasPorRevelar(mallaVisible), tablero, mallaVisible) == false);
        }
    }
}