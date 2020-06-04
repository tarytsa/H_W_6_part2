using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception1
{
    
    class Program
    {
        static bool ReadNumber(int start, int finish)
        {
            int a;
            try
            {
                if(start > finish || start == finish) throw new Exception("Invalid range");
                Console.Write("Input a number: ");

                a = Convert.ToInt32(Console.ReadLine());
                
                if (a > start && a < finish)
                {
                    return true;
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            return false;
        }
        static void Main(string[] args)
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("input start and finish: ");

                    if (ReadNumber(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())))
                    {
                        Console.WriteLine("This number is in this range");
                    }
                    else
                    {
                        Console.WriteLine("This number not in this range");
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
        }
    }
}
