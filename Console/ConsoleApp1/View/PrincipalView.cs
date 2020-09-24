using ConsoleApp1.Model;
using ConsoleApp1.View;
using ConsoleApp1.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1.Utils
{
    abstract class PrincipalView
    {
        public static void doRun()
        {
            OperacionesNumerosViewModel viewModel = new OperacionesNumerosViewModel();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("================= Prueba Técnica =================");
                Console.WriteLine();
                Console.WriteLine("------ Menu ------");
                Console.WriteLine();
                Console.WriteLine("Opcion 1: Calcular promedio de 3 números.");
                Console.WriteLine("Opcion 2: Calcular la suma de los numeros del 1 al 10.");
                Console.WriteLine("Opcion 3: Leer valores números de lineas de texto de un archivo.");
                Console.WriteLine("Opcion 4: Ejecutar proyecto de formularios.");
                Console.WriteLine();
                Console.Write("Seleccione una opcion: ");
                String opcion = Console.ReadLine();

                if (Regex.IsMatch(opcion, "^[\\d]+$"))
                {
                    switch (int.Parse(opcion))
                    {
                        case 1:
                            PromedioNumerosView.doRun(viewModel);
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.WriteLine("Números generados: ");
                            List<float> numbers = new List<float>();

                            for(int count = 1; count <= 10; count++)
                            {
                                Console.WriteLine(count);
                                numbers.Add(count);
                            }

                            Numbers numbers1 = new Numbers();
                            numbers1.numbersInput = numbers;

                            Console.WriteLine("TOTAL SUMATORIA: "+viewModel.sumatoriaNumeros(numbers1));

                            break;
                        case 3:
                            Console.WriteLine();

                            foreach(float number in viewModel.getNumerosFromText())
                            {
                                Console.WriteLine(number);
                            }

                            break;
                        case 4:
                            try
                            {
                                Process.Start("..\\..\\..\\..\\..\\Binaries\\Desktop\\Evaluacion IM.exe");
                            }catch(Exception exc)
                            {
                                try
                                {
                                    Process.Start("..\\Desktop\\Evaluacion IM.exe");
                                }
                                catch(Exception exc2)
                                {
                                    Console.WriteLine("Vaya! parece que movieron todo el sistema de carpertas y no se encontró el .exe");
                                }
                            }
                            break;
                        default:
                            Console.WriteLine();
                            Console.WriteLine("Opción no encontrada.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("no es numero");
                }

                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
