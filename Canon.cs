using System;
namespace pemrog10
{
	public class Canon : IPrinterWindows
	{
		public Canon()
		{
		}

        public void Print(Printer jenis)
        {
            Console.WriteLine("Printer Canon printing...");
        }

        public void Show(Printer jenis)
        {
            Console.WriteLine("Dimensi Display Printer Canon: 9.5*12");
        }
    }
}

