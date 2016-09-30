using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Övning 1
            var n = 0;
            while (n++ < 100) 
            {
                Console.WriteLine(n);
            }

            //Övning 2
            string lösenord = "";
            while (lösenord != "Anmol")
            {
                Console.WriteLine("Skriv in ett lösenord:");
                lösenord = Console.ReadLine();

                if (lösenord == "Anmol")
                {
                    Console.WriteLine("Välkommen");

                }
                else
                {
                    Console.WriteLine("Du skrev fel lösenord");
                }
            }

            // Övning 2.1
            int i = 1;
            while (i++ < 100)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //Övning 2.2
            int p= 10;
            while (p-->=1)
            {
                Console.WriteLine("p");
            }

            //Övning 2.3
            int o = 1;
            while (o == 1)
            {
                Console.WriteLine(o);
            }
            */
            
            //Övning 2.4
            Random rnd = new Random();
            int rand = rnd.Next(100);
            var rakna = 1;
            Console.WriteLine("Gissa ett tal mellan 0 och 100:");
            int tal = int.Parse(Console.ReadLine());
            while (tal!=rand)
            {
                if (tal<rand)
                {
                    Console.WriteLine("För Lågt!");

                }
                else
                {
                    Console.WriteLine("För Högt!");
                }
                Console.WriteLine("Gissa ett tal mellan 0 och 100:");
                tal = int.Parse(Console.ReadLine());
                rakna++;
            }
            Console.WriteLine("Grattis det tog  " + rakna  +  " gissningar!");

        }
    }
}





