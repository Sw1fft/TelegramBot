namespace AutoFactBot.Core.Models
{
    public class DocumentModel
    {
        public const int MAX_TITLE_LENGTH = 250;

        private DocumentModel(Guid id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }

        public Guid Id { get; }
        public string Title { get; } = string.Empty;
        public string Description { get; } = string.Empty;

        public static (DocumentModel, string Error) Create(Guid id, string title, string description)
        {
            var error = string.Empty;

            if (string.IsNullOrEmpty(title) || title.Length > MAX_TITLE_LENGTH)
                error = "Title can not be empty or longer then 250 symbols";

            var document = new DocumentModel(id, title, description);

            return (document, error);
        }
    }
}
