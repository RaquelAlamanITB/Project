using System;

namespace MyProjects
{
    public class Projecte {
        public static void Main() {
            int num;
            const string Msg = "Introdueix un numero natural (més gran que 0): ";
            do {
                Console.WriteLine(Msg);
                num = Convert.ToInt32(Console.ReadLine());
            }  while (!IsPositive(num));
        }

        public static bool IsPositive(int num) { return num > 0; }
    }
}
