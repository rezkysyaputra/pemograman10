using System;
namespace pemrog10
{
	public class LasetJet : IPrinterWindows
	{
		public LasetJet()
		{
		}

        public void Print(Printer jenis)
        {
            Console.WriteLine("Printer LaserJet printing...");
        }

        public void Show(Printer jenis)
        {
            Console.WriteLine("Dimensi display Printer LaserJet: 12*12");
        }
    }
}

