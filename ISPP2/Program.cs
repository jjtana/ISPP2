using System;
using System.Drawing;
using System.Reflection;

namespace ISPP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Document docToPrint = new Document("Test de Impresión", "Descripción del documento para impresión.");
            Document docToScan = new Document("Test de Escaneo", "Descripción del documento para escaneo.");

            IPrinter basicPrinter = new SimplePrinter();
            basicPrinter.Print(docToPrint);

            IPrinter multiFunctionPrinterPrint = new MultiFunctionDevice();
            IScanner multiFunctionPrinterScan = new MultiFunctionDevice();

            multiFunctionPrinterPrint.Print(docToPrint);
            multiFunctionPrinterScan.Scan(docToScan);
        }
    }
}
