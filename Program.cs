using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArrayGame
{
    internal class Program
    {
        private const char disponible = '_';
        private char[,] tablero =
        {
            {disponible, disponible, disponible},
            {disponible, disponible, disponible},
            {disponible, disponible, disponible}
        };

        public static void Main(string[] args)
        {
            Program p = new Program();
            bool fin = false;
            char jugadorActual = 'X';
            do
            {
                p.RealizarJugada(jugadorActual);
                p.MostrarTablero();

                fin = p.TableroLleno() || p.EsGanador(jugadorActual);
                jugadorActual = jugadorActual == 'X' ? 'O' : 'X';
            } while (!fin);

            Console.ReadKey();
        }

        private bool EsGanador(char jugadorActual)
        {
            for (int i = 0; i < 3; i++)
            {
                if (tablero[i, 0] == jugadorActual && tablero[i, 1] == jugadorActual && tablero[i, 2] == jugadorActual)
                {
                    Console.WriteLine("¡Felicidades jugador " + jugadorActual + "! Eres el Ganador!!!");
                    return true;
                }

                if (tablero[0, i] == jugadorActual && tablero[1, i] == jugadorActual && tablero[2, i] == jugadorActual)
                {
                    Console.WriteLine("¡Felicidades jugador " + jugadorActual + "! Eres el Ganador!!!");
                    return true;
                }
            }

            return false;
        }

        private bool TableroLleno()
        {
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (tablero[f, c] == disponible)
                    {
                        return false;
                    }
                }
            }

            Console.WriteLine("¡El juego ha terminado en empate!");
            return true;
        }

        private void RealizarJugada(char jugadorActual)
        {
            Console.WriteLine("Es el turno del jugador " + jugadorActual);
            bool valida = false;
            do
            {
                Console.WriteLine("Elija una fila");
                int fila = int.Parse(Console.ReadLine());
                Console.WriteLine("Elija una columna");
                int col = int.Parse(Console.ReadLine());
                if (fila >= 0 && fila < 3 && col >= 0 && col < 3 && tablero[fila, col] == disponible)
                {
                    tablero[fila, col] = jugadorActual;
                    valida = true;
                }
                else
                {
                    Console.WriteLine("Posición inválida. Por favor, intente de nuevo.");
                }
            } while (!valida);
        }

        public void MostrarTablero()
        {
            Console.Clear();
            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(tablero[fila, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
