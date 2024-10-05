using System;

namespace Apostas
{
    internal class ChaveEuro
    {
        static void Main()
        {
            int[] chave= new int[5];
            int value;
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    value = rand.Next(1,51);
                } while (Generate(chave, value,5));
                chave[i] = value;
            }
            int[] stars = new int[2];
            for (int i = 0; i < 2; i++)
            {
                do
                {
                    value = rand.Next(1,13);
                } while (Generate(stars, value,2));
                stars[i]= value;
            }
            Console.WriteLine("Chave: "+string.Join(", ", chave));
            Console.WriteLine("Estrelas: "+ string.Join(", ", stars));
        }
        public static bool Generate(int[] chave, int value, int max)
        {
            for (int i = 0; i < max; i++)
            {
                if (chave[i]==value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}