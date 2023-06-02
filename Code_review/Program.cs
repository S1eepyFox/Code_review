using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N для нумерации чисел:");
            bool NumConvertStatus = int.TryParse(Console.ReadLine(), out int NumUserValue);
            if (NumConvertStatus)
            {
                string numbering = TaskOne.Numbering(NumUserValue);
                Console.WriteLine(numbering);
            }
            else
                Console.WriteLine("Error: Invalid data");


            Console.WriteLine("Введите нечетное число N для построения квадрата:");
            bool SqConvertStatus = int.TryParse(Console.ReadLine(), out int SqUserValue);
            if (SqConvertStatus)
            {
                string buildSquare = TaskTwo.BuildSquare(SqUserValue);
                Console.WriteLine(buildSquare);
            }
            else
                Console.WriteLine("Error: Invalid data");

            Console.ReadLine();
        }
    }
}
