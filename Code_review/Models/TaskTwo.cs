using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class TaskTwo
    {
        public static string BuildSquare(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Вы ввели четное N.");
                return null;
            }

            StringBuilder sbSquare = new StringBuilder();
            int cen = (int)Math.Ceiling(num / 2.0);

            for (int row = 1; row <= num; row++)
            {
                for (int col = 1; col <= num; col++)
                {
                    if (cen == row && cen == col)
                        sbSquare.Append(" ");
                    else
                        sbSquare.Append("#");
                }
                sbSquare.Append("\r\n");
            }
            return sbSquare.ToString();
        }
    }
}
