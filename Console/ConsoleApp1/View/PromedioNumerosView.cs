using ConsoleApp1.Model;
using ConsoleApp1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1.View
{
    abstract class PromedioNumerosView
    {
        public static void doRun(OperacionesNumerosViewModel viewModel)
        {
            bool exit = false;
            Numbers numbersInput = new Numbers();

            do
            {

                Console.WriteLine();
                Console.WriteLine("\t******Menu Opción 1******");
                Console.WriteLine();
                Console.WriteLine("\tOpcion 1: Ingresar números manualmente.");
                Console.WriteLine("\tOpcion 2: Generar numeros aleatoriamente.");
                Console.WriteLine();
                Console.Write("\tSeleccione opción: ");

                String opcion = Console.ReadLine();

                if (Regex.IsMatch(opcion, "^[\\d]+$"))
                {
                    switch (int.Parse(opcion))
                    {
                        case 1:
                            String[] numbers= { "0","0","0"};
                            int count = 0;

                            while (count < 3)
                            {
                                Console.WriteLine();
                                Console.Write("\tIngrese número "+(count+1)+": ");
                                numbers[count] = Console.ReadLine();

                                count++;
                            }

                            numbersInput.numbersInput = numbers.Select(float.Parse).ToList();

                            Console.WriteLine();
                            Console.WriteLine("\tPROMEDIO TOTAL: "+viewModel.promedioNumeros(numbersInput));

                            exit = true;
                            break;
                        case 2:


                            Console.WriteLine();

                            float[] randomNumbers = { (float)(new Random().NextDouble() * 100), (float)(new Random().NextDouble() * 100), (float)(new Random().NextDouble() * 100) };

                            Console.WriteLine("\tNúmeros generados:");
                            foreach(float number in randomNumbers)
                            {
                                Console.WriteLine("\t" +number);
                            }

                            numbersInput.numbersInput=randomNumbers.ToList();

                            Console.WriteLine();
                            Console.WriteLine("\tPROMEDIO TOTAL: " + viewModel.promedioNumeros(numbersInput));

                            exit = true;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("no es numero");
                }

            } while (!exit);

        }
    }
}
