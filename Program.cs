namespace newTask._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Massivin uzunlugu:");
            int n = int.Parse(Console.ReadLine());
            double[] mass = new double[n];

            
            for (int i = 0; i < n; i++)
            {
                mass[i] = int.Parse(Console.ReadLine());
            }

            for ( int i = n - 1; i >= 0; i--)
            {
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine();
        }
    }
}