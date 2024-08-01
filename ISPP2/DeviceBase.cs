using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPP2
{
    public abstract class DeviceBase
    {
        protected void CheckDocument(Document doc)
        {
            if (doc == null)
                throw new ArgumentNullException(nameof(doc), "El documento no puede ser nulo.");

            if (string.IsNullOrEmpty(doc.Title))
                throw new ArgumentException("El documento no puede tener título vacío o nulo.", nameof(doc.Title));
        }

        protected void DisplayDocumentInfo(string action, Document doc)
        {
            Console.WriteLine($"{action} documento: {doc.Title}");
            Console.WriteLine($"Proceso completado. Título: {doc.Title}, Resumen: {doc.Summary}");
        }
    }
}
