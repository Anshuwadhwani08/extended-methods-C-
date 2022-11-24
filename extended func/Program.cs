using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using extension_method;

namespace extended_func
{
    public static class ExtendedMethods
    {
        public static string Tocurrency(this Class1 strclass, string str)
        {
            string num = strclass.Demo(str);

            if (num.All(Char.IsDigit) )
            {
                string res = "$" + num;
                return res;
                //Console.WriteLine(res);
                //Console.ReadKey();
            }
            else
            {
                throw new ArgumentException("string should be a number");
                
            }
            
            
        }
    }
    public class Program
    {
        
    static void Main(string[] args)
        {

            string s = "abc";
            Class1 class1 = new Class1();
            try
            {
                Console.WriteLine(class1.Tocurrency(s));
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
            
        }
    }
}
