using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPP2
{
    public class SimplePrinter : DeviceBase, IPrinter
    {
        public void Print(Document document)
        {
            CheckDocument(document); 
            DisplayDocumentInfo("Imprimiendo", document); 
        }
    }
}