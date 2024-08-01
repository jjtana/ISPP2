using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPP2
{
    public class MultiFunctionDevice : DeviceBase, IPrinter, IScanner
    {
        public void Print(Document doc)
        {
            CheckDocument(doc);
            DisplayDocumentInfo("Imprimiendo", doc);
        }

        public void Scan(Document doc)
        {
            CheckDocument(doc);
            DisplayDocumentInfo("Escaneando", doc);
        }
    }
}