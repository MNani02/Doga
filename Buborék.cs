using System;
using System.Collections.Generic;
using System.Text;

namespace Doga_MD
{
    public class Rand 
    {
        public static int randnum;
        public Rand()
        {
            Random R = new Random();
            randnum = R.Next(-101, 101);
        }
    }
    public class Buborék : Program
    {
        public static void Rendezés()
        {

            for (int j = n - 1; j > 0; j--)
            {
                for (int k = 0; k < j; k++)
                {
                    if (tömb[k] > tömb[k + 1])
                    {
                        int temp = tömb[k + 1];
                        tömb[k + 1] = tömb[k];
                        tömb[k] = temp;
                    }
                }
            }
        }
    }
}
