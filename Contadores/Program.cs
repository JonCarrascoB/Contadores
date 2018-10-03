using System;

namespace Contadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int option, countLimit, cardValue;
            const int NORMAL_COUNT = 1, NASA_COUNT = 2, STUDENT_COUNT = 3, SESAME_STREET_COUNT = 4, MAILMAN_COUNT = 5, EXIT = 6;
            do
            {
                Console.WriteLine("Pulsa 1 para contar normalmente.");
                Console.WriteLine("Pulsa 2 para contar como un ingeniero de la NASA.");
                Console.WriteLine("Pulsa 3 para contar como un estudiante universitario.");
                Console.WriteLine("Pulsa 4 para contar como en barrio sesamo.");
                Console.WriteLine("Pulsa 5 para contar como un cartero.");
                Console.WriteLine("Pulsa 6 para salir.");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                

                switch (option)
                {
                    // Contar normalmente
                    case NORMAL_COUNT:
                        do
                        {
                            Console.WriteLine("¿Hasta qué número quieres contar (número mayor que 1)?");
                            countLimit = Convert.ToInt32(Console.ReadLine());
                        } while (countLimit <= 0);
                        Console.WriteLine();

                        for (int i = 1; i <= countLimit; i++)
                        {
                            Console.WriteLine(i);
                        }
                        break;

                    // Contar como un ingeniero de la NASA.
                    case NASA_COUNT:
                        do
                        {
                            Console.WriteLine("¿Hasta qué número quieres contar (número mayor que 1)?");
                            countLimit = Convert.ToInt32(Console.ReadLine());
                        } while (countLimit <= 0);
                        Console.WriteLine();

                        for (int i = countLimit; i >= 0; i--)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine("¡¡¡Ignición!!!");
                        break;

                    // Contar como un estudiante universitario
                    case STUDENT_COUNT:
                        do
                        {
                            Console.WriteLine("¿Hasta qué número quieres contar (número mayor que 1)?");
                            countLimit = Convert.ToInt32(Console.ReadLine());
                        } while (countLimit <= 0);
                        Console.WriteLine();

                        for (int i = 1; i <= countLimit; i++)
                        {
                            // Hacemos módulo 10 para usar el dígito de las unidades,
                            // por lo tanto sólo tendremos de 0 a 9 en cardValue.
                            // Si es un 1 escribimos Ás, un 8 Sota, un 9 Caballo y
                            // un 0 Rey. El resto de valores (de 2 a 7) mostramos
                            // el valor de cardValue.
                            cardValue = i % 10;
                            if (cardValue == 1)
                            {
                                Console.WriteLine("Ás");
                            }
                            else if (cardValue == 8)
                            {
                                Console.WriteLine("Sota");
                            }
                            else if (cardValue == 9)
                            {
                                Console.WriteLine("Caballo");
                            }
                            else if (cardValue == 0)
                            {
                                Console.WriteLine("Rey");
                            }
                            else
                            {
                                Console.WriteLine(cardValue);
                            }
                        }
                        break;

                    // Contar como en barrio sesamo
                    case SESAME_STREET_COUNT:
                        do
                        {
                            Console.WriteLine("¿Hasta qué número quieres contar (número mayor que 1)?");
                            countLimit = Convert.ToInt32(Console.ReadLine());
                        } while (countLimit <= 0);
                        Console.WriteLine();

                        for (int i = 1; i <= countLimit; i++)
                        {
                            Console.WriteLine("¡¡¡¡¡¡¡ " + i + " !!!!!!!");
                        }
                        break;

                    // Contar como un cartero
                    case MAILMAN_COUNT:
                        do
                        {
                            Console.WriteLine("¿Hasta qué número quieres contar (número mayor que 1)?");
                            countLimit = Convert.ToInt32(Console.ReadLine());
                        } while (countLimit <= 0);
                        Console.WriteLine();

                        for (int i = 1; i <= countLimit; i+=2)
                        {
                            Console.WriteLine(i);
                        }
                        for (int i = 2; i <= countLimit; i += 2)
                        {
                            Console.WriteLine(i);
                        }
                        break;

                    // 6 es opción de salir del programa así que no hacemos nada
                    // ya que el bucle do while se va a acabar
                    case EXIT:
                        break;

                    // Número de opción incorrecta
                    default:
                        Console.WriteLine("Esa opción no existe.");
                        Console.WriteLine();
                        break;
                }
                Console.WriteLine();

            } while (option != EXIT);

            Console.WriteLine("Pulsa cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
