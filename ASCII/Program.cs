// программа выводит все символы ASCII с десятичными кодами
using System;

namespace ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[96];
            int code = 32;
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)code;
                Console.WriteLine("char {0} code {1}", chars[i], code++);
            }
            Console.WriteLine("\nДля продолжения нажмите любую клавишу . . .");
            Console.ReadKey();
        }
    }
}
