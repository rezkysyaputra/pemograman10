using System;
namespace pemrog10
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
           
            Console.WriteLine("Pilih Printer:");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.Write("Nomor Printer[1...3]:");

            int nomorPrinter = Convert.ToInt32(Console.ReadLine());
            printer.jenis = nomorPrinter;

            IPrinterWindows? show = null, print = null;

            if(printer.jenis == 1)
            {
                show = new Epson();
                print = new Epson();
            }else if(printer.jenis == 2)
            {
                show = new Canon();
                print = new Canon();
            }else if(printer.jenis == 3)
            {
                show = new LasetJet();
                print = new LasetJet();
            }
            else
            {
                Console.WriteLine("INPUTAN SALAH!");
            }

            show?.Show(printer);
            print?.Print(printer);
            Console.ReadKey();
        }
    }
}