using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            PercorrendoArrayForEach();
        }

        static public void array()
        {
            var meuArray = new int[5];

            meuArray[0] = 12;

            Console.WriteLine(meuArray[0]);
        }


        static public void PercorrendoArray()
        {
            var meuArray = new int[5];

            meuArray[0] = 12;
            meuArray[1] = 11;
            meuArray[2] = 13;
            meuArray[3] = 14;
            meuArray[4] = 15;

            for (int i = 0; i < meuArray.Length; i++)
            {
                Console.WriteLine(meuArray[i]);
            }

        }

        static public void PercorrendoArrayForEach()
        {
            var meuArray = new int[5];

            meuArray[0] = 1;
            meuArray[1] = 2;
            meuArray[2] = 2;
            meuArray[3] = 3;
            meuArray[4] = 4;

            foreach (var item in meuArray)
                Console.WriteLine(item);
        }

        
    }
}
