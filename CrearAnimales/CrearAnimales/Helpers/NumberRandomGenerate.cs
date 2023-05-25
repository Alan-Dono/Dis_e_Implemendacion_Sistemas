using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearAnimales.Helpers
{
    internal class NumberRandomGenerate
    {
        private static Random _random = new Random();

        public static int GenerateRandomNumber(int minValue, int maxValue)
        {
            return _random.Next(minValue, maxValue + 1);
        }
    }

}

