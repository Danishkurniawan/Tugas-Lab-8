using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) - Polymorphsim, Inheritance, Abstraction & Collection";

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "123-233-500";
            karyawanTetap.Nama = "Surya Adit";
            karyawanTetap.GajiBulanan = 4500000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "123-361-786";
            karyawanHarian.Nama = "Dani wardana";
            karyawanHarian.JumlahJamKerja = 8;
            karyawanHarian.UpahPerJam = 73000;

            Sales sales = new Sales();
            sales.Nik = "123-870-947";
            sales.Nama = "Tipan suryar";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 95000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                noUrut++;
            }
            Console.ReadKey();
        }
    }
}
