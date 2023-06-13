using ExercicioAluguelQuarto;
using System;
using System.Globalization;

namespace AlugueldeQuarto {
    class Project {
        static void Main(string[] args) {
            
            Console.Write("How many room will be rented? ");
            int n = int.Parse(Console.ReadLine());

            Booking[] vect = new Booking[10];

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Rent #"+i);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int numero = int.Parse(Console.ReadLine());
                vect[i] = new Booking (name,email);
            }
            Console.WriteLine("Busy Rooms: ");
            for (int i = 0; i <= n; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i +": " + vect[i]);
                }

            }

        }
    }
}
