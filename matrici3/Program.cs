namespace matrici3
{
    internal class Program
    {
        static int[,] Riempimento(int[,] m)
        {
            Random r = new Random();
            
            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < m.GetLength(1); j++)
                {
                    int rand = r.Next(0, 2);
                    m[i, j] = rand;
                    Console.WriteLine(m[i, j]);
                }
            }
            return m;
        }
        static bool Verifica(int[,] m)
        {
            int ver1 = 0, ver2 = 0;
            bool verifica = true;
            for(int i = 1; i < m.GetLength(0); i++)
            {
                ver2 = 0;
                ver1 = 0;
               
                for(int j = 0; j < m.GetLength(1); j++)
                {
                    if(m[i, j] != 0)
                    {
                        ver1++;
                    }
                    if(m[i-1, j] != 0)
                    {
                        ver2++;
                    }
                    
                }
                if(ver1 != ver2)
                {
                    verifica = false;
                    return verifica;
                }
            }
            return verifica;
        }
        static void Main(string[] args)
        {
            int[,] m = new int[8, 8];
            
            Riempimento(m);
            
            if(Verifica(m) == true)
            {
                Console.WriteLine("Le righe hanno tutte gli stessi uno");
            }
            else
            {
                Console.WriteLine("Le righe non hanno tutte gli stessi uno");
            }
        }
    }
}
