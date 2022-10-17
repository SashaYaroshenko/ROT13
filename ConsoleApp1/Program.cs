using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static string Rot13(string input)
        {
            string res = "";
            foreach(char i in input)
            {
                if(Char.IsLetter(i))
                {
                    if(i > 64 && i < 78 || i > 96 && i < 110)
                    {
                        res += Convert.ToString(Convert.ToChar(i + 13));
                    }
                    else
                    {
                        res += Convert.ToString(Convert.ToChar(i - 13));
                    }
                }
                else
                {
                    res += i.ToString();
                }
            }
            return res;
        }
    }
}
