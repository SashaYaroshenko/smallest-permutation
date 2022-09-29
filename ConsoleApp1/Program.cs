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
            Kata.MinPermutation(1012379);
        }
    }

    
    
        public static class Kata
        {
            public static int MinPermutation(int n)
            {
                string n1 = n.ToString();
                int result = 0;
                string res = ""; 
                List<int> list = new List<int>();
                if(n < 0)
                {
                    n1 = n1.Replace("-", "");
                }
            if (n1[0]=='0' || n1[n1.Length-1]=='0' )
                {
                    result = n;
                }
                else
                {
                    char[]chars = n1.ToCharArray();
                    
                    
                        for(int c = 0; c < chars.Length; c++)
                        {
                            list.Add(Convert.ToInt32(chars[c].ToString()));
                        }
                    
                    list.Sort();
                    for (int i = 0; i < list.Count; i++)
                    {
                        res += list[i].ToString();
                    }
                    result = Convert.ToInt32(res);
                    if(n<0)
                    {
                        result = result * -1;
                    }
                }
                return result;
            }
        }
    }

