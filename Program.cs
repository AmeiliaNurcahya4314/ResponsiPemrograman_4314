using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4314
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan(1003456, "Adit", 3000000);
            Karyawan karyawan2 = new Karyawan(1935678, "Aryo", 2000000);
            Karyawan karyawan3 = new Karyawan(1657832, "Paijo", -1000000);


            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji bulanan |");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1. | {0} {1} \t\t | {2}\t |", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2. | {0} {1} \t\t | {2}\t |", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.WriteLine("3. | {0} {1} \t\t | {2}\t\t |", karyawan3.NIK, karyawan3.Nama, karyawan3.GajiBulanan);

            Console.WriteLine("\n\nAsikkkkkkkk dapat kenaikan gaji 10% nichh !!!!\n");


            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji bulanan |");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1. | {0} {1} \t\t | {2}\t |", karyawan1.NIK, karyawan1.Nama, karyawan1.NaikGaji);
            Console.WriteLine("2. | {0} {1} \t\t | {2}\t |", karyawan2.NIK, karyawan2.Nama, karyawan2.NaikGaji);
            Console.WriteLine("3. | {0} {1} \t\t | {2}\t\t |", karyawan3.NIK, karyawan3.Nama, karyawan3.GajiBulanan);


            Console.ReadKey();
        }
    }
}
