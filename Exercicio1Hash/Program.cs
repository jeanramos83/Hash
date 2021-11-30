using System;
using System.Collections;

namespace Exercicio1Hash
{
    public class Program
    {
       
        public int Main
            (
            int x,
            int y,
            params int[] vals
            )
        {
            int hash = x;
            foreach (int i in vals)
            {
                hash = (hash * y) + i;
            }
            return hash;
        }
    }
}
