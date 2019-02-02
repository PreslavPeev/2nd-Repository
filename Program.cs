using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurki_s_chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            {
                for (var i = 1; i <= n; i++)
                {
                    var flagche = true;
                    var k = i;
                    for (var j = 1; j <= n; j++)
                    {
                        Console.Write(k);
                        if (k >= n)
                        {
                            flagche = false;
                        }
                        if (!flagche)
                        {
                            k--;
                        }
                        else
                        {
                            k++;
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
