namespace ISPP2
{
    public class Document
    {
        public string Title { get; set; }
        public string Summary { get; set; }

        public Document(string title, string summary)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title), "El título del documento no puede ser nulo.");
            Summary = summary;
        }
    }
}