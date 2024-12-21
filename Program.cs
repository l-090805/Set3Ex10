using System;
using System.Linq;
using System.Threading.Tasks.Dataflow;
namespace Set3Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vector: ");
            string input = Console.ReadLine();
            int[] v = Array.ConvertAll(input.Split(' '), int.Parse);
            Array.Sort(v);

            Console.Write("Un numar k a carui pozitie doriti sa o aflati: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Vectorul introdus ordonat crescator: " + String.Join(" ", v));
            int pozitie = BinarySearch(v, k);
            Console.WriteLine($"Pozitia pe care se afla numarul {k} este {pozitie}");
        }

        static int BinarySearch(int[] v, int k)
        {
            int low = 0;
            int high = v.Length - 1;

            while(low <= high)
            {
                int mid = low + (high - low) / 2;
                if (v[mid] == k)
                {
                    return mid;
                }
                else if (v[mid] > k)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }
    }
}
