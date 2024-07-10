using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be long long long long text";

            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);


            //

            IEnumerable<int> numbers = new List<int>() { 1, 4, 7, 2, 3 };
            var max = numbers.Max();
            Console.WriteLine("Max number : " + max);


        }
    }
}
