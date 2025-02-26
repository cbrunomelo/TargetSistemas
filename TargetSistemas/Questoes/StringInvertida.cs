using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetSistemas.Questoes
{
    internal class StringInvertida
    {
        public static string Inverter(string input)
        {
            char[] array = input.ToCharArray();
            for (int i = 0, j = array.Length - 1; i < j; i++, j--)
            {
                (array[i], array[j]) = (array[j], array[i]);
            }
            return new string(array);
        }
    }
}
