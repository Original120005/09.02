using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DZ_09._02._2023
{
    internal class Program
    {
        static void Compare(int a, int b, string symbol)
        {
            string[] mas = new string[] { "<", ">", ">=", "<=", "==", "!=" }; int count = 0;
            try
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    if (symbol == mas[i])
                    {
                        count++;
                    }
                }
                if (count != 1)
                {
                    throw new Exception("It's uncorrect sign!");
                }
                switch (symbol)
                {
                    case "<":
                        if (a < b == true) { Console.WriteLine($"{a} {symbol} {b}"); }
                        else { throw new Exception("It's uncorrect!"); }
                        break;

                    case ">":
                        if (a > b == true) { Console.WriteLine($"{a} {symbol} {b}"); }
                        else { throw new Exception("It's uncorrect!"); }
                        break;

                    case ">=":
                        if (a >= b == true) { Console.WriteLine($"{a} {symbol} {b}"); }
                        else { throw new Exception("It's uncorrect!"); }
                        break;

                    case "<=":
                        if (a <= b == true) { Console.WriteLine($"{a} {symbol} {b}"); }
                        else { throw new Exception("It's uncorrect!"); }
                        break;

                    case "==":
                        if (a == b == true) { Console.WriteLine($"{a} {symbol} {b}"); }
                        else { throw new Exception("It's uncorrect!"); }
                        break;

                    case "!=":
                        if (a != b == true) { Console.WriteLine($"{a} {symbol} {b}"); }
                        else { throw new Exception("It's uncorrect!"); }
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void Main(string[] args)
        {
            
            Console.Write("Enter boolean expression: ");
            string str = Console.ReadLine();
            string[] textArray = str.Split(new char[] { ' ' });
            int a = Convert.ToInt32(textArray[0]);
            int b = Convert.ToInt32(textArray[2]);
            string symbol = null;

            string[] mas = new string[] { "<", ">", "=", "!" };
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < mas.Length; j++)
                {
                    if (Convert.ToString(str[i]) == mas[j])
                    {
                        symbol = Convert.ToString(str[i]);
                        if (str[i + 1] == '=') { symbol += str[i + 1]; i = str.Length; j = mas.Length; }
                    }
                }
            }
            Compare(a, b, symbol);


        }
    }
}