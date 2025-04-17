using System;
namespace lab2btap6
{
    class Program
    {
        public static void Nhapmang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]:  ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void Sapxepmang(int[] a, int n)
        {
            for( int i = 0; i < n - 1; i++)
            {
                for( int j = 0; j < n - 1; j++)
                {
                    if(a[j] > a[j + 1])
                    {
                        // Hoan doi phan tu
                        int temp = a[j];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Nhapmang(a, n);
            Console.WriteLine($"Sap xep = {Sapxepmang(a, n)} ");
        }
    }
}