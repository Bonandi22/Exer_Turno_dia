using System;

namespace Exer_Turno_dia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int hour, minutes;

            Console.Write(" Indique que horas são:");
            hour = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Indique que minutos são:");
            minutes = Convert.ToInt32(Console.ReadLine());


            if (hour <= 12 && hour >= 7)
            {
                Console.WriteLine("É de manhã");
            }
            else
            {
                if (hour > 21 || (hour == 20 && minutes > 30) || hour < 7)
                {
                    Console.WriteLine(" É de noite");
                }
                else
                {
                    Console.WriteLine("É de tarde");
                }

            }

            //If e Else If

            if (hour >= 7 && hour < 12)
            {
                Console.WriteLine("É de manhã");
            }
            else if (hour >= 12 && hour < 21)

            {
                Console.WriteLine("É de tarde");
            }
            else
            {
                Console.WriteLine("É de Noite");
            }


        }

    }
}
