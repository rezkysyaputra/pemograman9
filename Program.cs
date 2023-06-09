using System;
using pemrorg9;

namespace pemrog9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows? printer = null; // Deklarasi variabel printer dengan tipe PrinterWindows dan diinisialisasi dengan null
            Console.WriteLine("Pilih Printer:");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.WriteLine("Nomor Printer[1...3]:");

            int nomorPrinter = Convert.ToInt32(Console.ReadLine()); // Membaca input dari pengguna dan mengonversinya menjadi tipe int

            if (nomorPrinter == 1) // Jika nomorPrinter sama dengan 1
            {
                printer = new Epson(); // Membuat objek Epson dan menyimpannya ke variabel printer
            }
            else if (nomorPrinter == 2) // Jika nomorPrinter sama dengan 2
            {
                printer = new Canon(); // Membuat objek Canon dan menyimpannya ke variabel printer
            }
            else if (nomorPrinter == 3) // Jika nomorPrinter sama dengan 3
            {
                printer = new LaserJet(); // Membuat objek LaserJet dan menyimpannya ke variabel printer
            }
            else // Jika nomorPrinter tidak sama dengan 1, 2, atau 3
            {
                Console.WriteLine("Anda salah memasukkan pilihan>_<\n"); // Menampilkan pesan kesalahan
            }

            if (printer != null) // Jika printer tidak null (objek printer berhasil dibuat)
            {
                printer.Show(); // Memanggil metode Show() dari objek printer
                printer.Print(); // Memanggil metode Print() dari objek printer
            }

            Console.ReadKey(); // Menunggu pengguna menekan tombol sebelum menutup aplikasi
        }
    }
}
