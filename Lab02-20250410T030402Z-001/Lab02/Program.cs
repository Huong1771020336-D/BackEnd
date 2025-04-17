using System;
namespace Lab02
{
    class Program
    {
        public static void Nhapmang( int[] a, int n)
        {
            for ( int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        public static int TinhTong(int[] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += a[i];
            }
            return tong;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Khai bao bien n
            int n;
            //Nhap gia tri cho bien n;
            Console.Write("Nhap n : ");
            n = int.Parse(Console.ReadLine());
            // Khai bao va khoi tao mang so nguyen co n phan tu
            int[] a = new int[n];
            // Goi ham nhap mang
            Nhapmang(a, n);
            //Goi ham tinh tong cac phan tu trong mang va hien thi ket qua ra man hinh
            Console.WriteLine($"Tong = {TinhTong(a, n)}");

        }
    }
}