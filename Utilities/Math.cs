using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class Math
    {
        public static Random seedRandom;
        public static int RandomNumberBetween(int low, int max)
        {
            // Thread.Sleep(1);//
            if (seedRandom == null)
            {
                seedRandom = new Random(DateTime.Now.Millisecond);
            }
            Random rng = new Random(seedRandom.Next(0, 100000));
            return rng.Next(low, max);
        }
    }
}
