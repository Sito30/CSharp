using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace TrueFalse
{
    public class Tools
    {
        public static void SetUpInputStream(string sample)
        {
            if (sample == null)
            {
                Console.SetIn(new StreamReader("true.txt"));
            }
        }
    }
}