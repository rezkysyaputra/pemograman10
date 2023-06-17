using System;
namespace pemrog10
{
	public class Epson : IPrinterWindows
	{
		public Epson()
		{
		}

        public void Print(Printer jenis)
        {
            Console.WriteLine("Printer Epson printing...");
        }

        public void Show(Printer jenis)
        {
            Console.WriteLine("Dimensi dislay Epson: 10*11");
        }
    }
}

