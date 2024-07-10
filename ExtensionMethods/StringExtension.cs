using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtension
    {
        public static string Shorten(this String str, int numberofwords)
        {
            if(numberofwords < 0)
            {
                throw new ArgumentOutOfRangeException("number of words should be gerater than and equal to 0");
            }

            if(numberofwords == 0)
                return "";

            var words = str.Split(' ');

            if(words.Length <= numberofwords )
            {
                return str;
            }

            return string.Join(" ", words.Take(numberofwords)) + "..." ;
        }
    }
}
