using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppgaji2
{
    class Program
    {
        public static void Main(string[] args)
        {
            

            Karyawan k1 = new Karyawan("1121011", "Jayadi Saputra", 1000000);
            Karyawan k2 = new Karyawan("1121012", "Aji Pamungkas", -250000);

            Hasil(k1, k2);

            Console.ReadKey();
        }
        public static void Hasil(Karyawan k1, Karyawan k2)
        {
            Console.WriteLine("NIK         Nama           Gaji");
            Console.WriteLine("{0}     {1}         {2}", k1.nik, k1.nama, k1.gaji);
            Console.WriteLine("{0}     {1}         {2}", k2.nik, k2.nama, k2.gaji);

            Console.WriteLine("==================================");
            Console.WriteLine("Yay, dapet bonus 10% dari stupidboss!");
            Console.WriteLine("==================================");

            double bonus1 = (0.10 * k1.gaji) + k1.gaji;
            double bonus2 = (0.10 * k2.gaji) + k2.gaji;

            Console.WriteLine("NIK         Nama           Gaji");
            Console.WriteLine("{0}     {1}         {2}", k1.nik, k1.nama, bonus1);
            Console.WriteLine("{0}     {1}         {2}", k2.nik, k2.nama, bonus2);
        }
    }
}
