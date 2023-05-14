using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsGeneratorLib
{
    public class ExceptionGeneratorClass
    {
        public void ExceptionGeneratorMethod1()
        {
            try
            {
                Console.WriteLine($"ExceptionGeneratorMethod1 in dll library function started");
                // create an error
                double[] myArray = null;
                if (myArray == null)
                    throw new Exception("*** Tablica in lib nie moze byc null ***");
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
