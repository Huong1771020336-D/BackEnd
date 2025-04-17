using System;
namespace lab2btap1
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
        public static int TinhTongSoChan(int[] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    tong += a[i];
                }
                
            }return tong;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Nhapmang(a, n);
            Console.WriteLine($"Tong = {TinhTongSoChan(a, n)} ");
        }
    }
}