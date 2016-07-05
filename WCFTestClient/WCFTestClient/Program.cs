using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WCFTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var methods = new Methods();

            try
            {
                Console.WriteLine("Enter value");
                int val = int.Parse(Console.ReadLine());
                var response = methods.GetValue(val);
                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
            
            Console.ReadLine();
        }
    }
}
