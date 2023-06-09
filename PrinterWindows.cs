using System;
namespace pemrorg9
{
    // Class dasar atau utama
    public class PrinterWindows
    {
        // Metode virtual untuk menampilkan dimensi tampilan PrinterWindows
        public virtual void Show()
        {
            Console.WriteLine("Dimensi display PrinterWindows: 9.5*12");
        }

        // Metode virtual untuk mencetak pada PrinterWindows
        public virtual void Print()
        {
            Console.WriteLine("PrinterWindows printing...");
        }
    }

    // Class Turunan
    public class Epson : PrinterWindows
    {
        // Melakukan override pada metode Show() dari kelas dasar
        public override void Show()
        {
            Console.WriteLine("Dimensi dislay Epson: 10*11");
        }

        // Melakukan override pada metode Print() dari kelas dasar
        public override void Print()
        {
            Console.WriteLine("Printer Epson printing...");
        }
    }

    // Class Turunan
    public class Canon : PrinterWindows
    {
        // Melakukan override pada metode Show() dari kelas dasar
        public override void Show()
        {
            Console.WriteLine("Dimensi Display Printer Canon: 9.5*12");
        }

        // Melakukan override pada metode Print() dari kelas dasar
        public override void Print()
        {
            Console.WriteLine("Printer Canon printing...");
        }
    }

    // Class Turunan
    public class LaserJet : PrinterWindows
    {
        // Melakukan override pada metode Show() dari kelas dasar
        public override void Show()
        {
            Console.WriteLine("Dimensi display Printer LaserJet: 12*12");
        }
        // Melakukan override pada metode Print() dari kelas dasar
        public override void Print()
        {
            Console.WriteLine("Printer LaserJet printing...");
        }
    }
}