using ExceptionsGeneratorLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Main function started");
                InnerFunction1();
            }
            catch (Exception ex)
            {
                //if (!string.IsNullOrEmpty(ex.Message))
                    Console.WriteLine($"Error detected. Details: {ex.Message}");
            }

            Console.ReadLine();
        }

        private static void InnerFunction1()
        {
            try
            {
                Console.WriteLine($"InnerFunction1 function started");
                InnerFunction2();
            }
            catch (Exception ex)
            {
                if (ex.TargetSite.Name == System.Reflection.MethodBase.GetCurrentMethod().Name)
                    throw new Exception($"{ex.Message}, {ex.StackTrace}");
                else
                    throw;
                //if (!string.IsNullOrEmpty(ex.Message))
                //{
                //    Console.WriteLine($"Error message from InnerFunction1. Details: {ex.Message}");
                //}
                //throw new Exception(string.Empty);
            }
        }

        private static void InnerFunction2()
        {
            try
            {
                Console.WriteLine($"InnerFunction2 function started");

                //double[] myArray = null;
                //double a = myArray[0];

                InnerFunction3();
            }
            catch (Exception ex)
            {
                //string test1 = System.Reflection.MethodBase.GetCurrentMethod().Name;
                //string test2 = ex.TargetSite.Name;
                if (ex.TargetSite.Name == System.Reflection.MethodBase.GetCurrentMethod().Name)
                    throw new Exception($"{ex.Message}, {ex.StackTrace}");
                else
                    throw;

                //if (!string.IsNullOrEmpty(ex.Message))
                //{
                //    Console.WriteLine($"Error message from InnerFunction2. Details: {ex.Message}");
                //}
                //throw new Exception(string.Empty);
            }
        }

        private static void InnerFunction3()
        {
            try
            {
                Console.WriteLine($"InnerFunction3 function started");
                ExceptionGeneratorClass egc = new ExceptionGeneratorClass();
                egc.ExceptionGeneratorMethod1();
                // create an error
                double[] myArray = null;
                if (myArray == null)
                    throw new Exception("*** Tablica nie moze byc null ***");
                double a = myArray[0];
            }
            catch (Exception ex)
            {
                if (ex.TargetSite.Name == System.Reflection.MethodBase.GetCurrentMethod().Name)
                    throw new Exception($"{ex.Message}, {ex.StackTrace}");
                else
                    throw;
                //if (!string.IsNullOrEmpty(ex.Message))
                //{
                //    Console.WriteLine($"Error message from InnerFunction3. Details: {ex.Message}");
                //}
                //throw new Exception(string.Empty);
            }
        }
    }



}
