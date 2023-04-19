using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Регулярные_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new string[]
            {
                "0",
                "-6",
                "-0",
                "+2",
                "-0.5",
                "001",
                "0.(35)1",
                "0.(345)",
                "0.0(64)",
                "0.0",
                "-3,750",
                "-4.750"
            };

            //improve code style in Program.cs
            //А это весёлый комментарий, который я добавил просто так
            //А это ещё один коммент, но уже отправленный через VS


            Regex reg = new Regex("^(([-]?((([0]|([1-9][0-9]*))[.](([0-9]+[1-9])|((([0-9]*)([(][0-9]+[)])?)))|([1-9]+))))|[0])$");

            for (int i = 0; i < data.Length; i++)
            {
                if (reg.IsMatch(data[i]))
                {
                    Console.WriteLine(data[i]);
                }
            }
        }
    }
}
