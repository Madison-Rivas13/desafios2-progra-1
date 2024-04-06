using System;

namespace CalculadoraDescuento
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[,] compras = {
                {50, 150, 300, 500, 1200},
                {1000, 2000, 1500, 800, 900},
                {90, 80, 70, 60, 50},
                {300, 250, 200, 150, 100},
                {1100, 1200, 1300, 1400, 1500}
            };

            AplicarDescuentos(compras);
        }

        static void AplicarDescuentos(int[,] compras)
        {
            for (int cliente = 0; cliente < compras.GetLength(0); cliente++)
            {
                double totalCompras = 0;

                
                for (int compra = 0; compra < compras.GetLength(1); compra++)
                {
                    totalCompras += compras[cliente, compra];
                }

                double descuento = CalcularDescuento(totalCompras);
                double totalConDescuento = totalCompras - descuento;

                Console.WriteLine("Cliente " + (cliente + 1) + ":");
                Console.WriteLine("Total de compras: $" + totalCompras);
                Console.WriteLine("Descuento aplicado: $" + descuento);
                Console.WriteLine("Total con descuento: $" + totalConDescuento);
                Console.WriteLine();
            }
        }

        static double CalcularDescuento(double totalCompras)
        {
            if (totalCompras >= 0 && totalCompras < 100)
            {
                return 0;
            }
            else if (totalCompras >= 100 && totalCompras <= 1000)
            {
                return totalCompras * 0.10;
            }
            else
            {
                return totalCompras * 0.20;
            }
        }
    }
}
