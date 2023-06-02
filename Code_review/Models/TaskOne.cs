using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class TaskOne
    {
        static public string Numbering(int number)
        {
            var result = new StringBuilder(number);

            for (int i = 1; i <= number; i++)
                result.Append(i + (i == number ? "." : ", "));

            return result.ToString();
        }

    }
}
