using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5_pag_85
{
    class Program
    {
        static void Main(string[] args)
        {
            short shortResult, shortVal = 4;
            int integerVal = 67;
            long longResult;
            float floatVal = 10.5F;
            double doubleResult, doubleVal = 99.999;
            string stringResult, stringVal = "17";
            bool boolVal = true;
            Console.WriteLine("Variable Conversion Examples\n");
            doubleResult = floatVal * shortVal;
            Console.WriteLine("implicit, -> double: {0} * {1} -> {2}", floatVal,
                shortVal, doubleResult);
            shortResult = (short)floatVal;
            Console.WriteLine("explicit, -> short: {0} -> {1}", floatVal,
                shortResult);
            stringResult = Convert.ToString(boolVal) +
                Convert.ToString(doubleVal);
                Console.WriteLine("Explicit, -> string: \"{0}\" +\"{1}\" -> {2}",
                boolVal, doubleVal, stringResult);
            longResult = integerVal + Convert.ToInt64(stringVal);
            Console.WriteLine("Mixed, -> long: {0} + {1} -> {2}",
                integerVal, stringVal, longResult);
            Console.ReadKey();
        }
    }
}
