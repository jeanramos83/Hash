namespace Exercicio1Hash
{
    internal class ProgramBase1
    {

        public static int Main
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