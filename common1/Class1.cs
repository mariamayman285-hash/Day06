using System;

namespace common1
{
    #region Problem 2
    public class Class1
    {
        int F;
        internal int G;
        public int H;

        public void print()
        {
            Console.WriteLine(F);
            Console.WriteLine(G);
            Console.WriteLine(H);
        }
        /*
          Private: can only be accessed inside the same class
          Internal: can be accessed from anywhere within the same project
          Public: can be accessed from anywhere
         */ 
        #endregion

    }
}
