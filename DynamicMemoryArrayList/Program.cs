using System;
using System.Collections;
using System.Collections.Generic;

class Program
    {
    static void Main(string[] args)
        {
        ArrayList listaCadenas = new ArrayList();

        Console.WriteLine("Introduce cadenas de texto. Presiona Enter para agregar una cadena o deja vacía y presiona Enter para entrar en el modo consulta.");

        while (true)
            {
            Console.Write("Cadena: ");
            string cadena = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(cadena))
                {
                // Entrar en modo consulta
                Console.WriteLine("Modo consulta activado.");
                while (true)
                    {
                    Console.Write("Introduce un número (0 para salir): ");
                    int indice;
                    if (int.TryParse(Console.ReadLine(), out indice))
                        {
                        if (indice == 0)
                            {
                            // Salir del programa
                            Console.WriteLine("Saliendo del programa.");
                            return;
                            }
                        else if (indice >= 1 && indice <= listaCadenas.Count)
                            {
                            // Mostrar la cadena en la posición indicada
                            string cadenaConsultada = (string)listaCadenas[indice - 1];
                            Console.WriteLine($"Cadena en la posición {indice}: {cadenaConsultada}");
                            }
                        else
                            {
                            Console.WriteLine("Número fuera de rango. Introduce un número válido.");
                            }
                        }
                    else
                        {
                        Console.WriteLine("Entrada no válida. Introduce un número válido.");
                        }
                    }
                }
            else
                {
                // Agregar la cadena al ArrayList
                listaCadenas.Add(cadena);
                }
            }
        }
    }