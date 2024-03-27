using AutoFactBot.Core.Abstractions;
using AutoFactBot.Core.Models;

namespace AutoFactBot.Data.Repositories
{
    public class DocumentsRepository : IDocumentsRepository
    {
        public static long UserId { get; set; } = 0;

        private readonly string path = @"D:\AppDocumentsData\AutoFactBot\Users\";

        public Task<List<DocumentModel>> GetAllDocuments()
        {
            throw new NotImplementedException();
        }

        public async Task<Guid> CreateDocument(DocumentModel document)
        {
            CheckUserDirectory();

            //using var pdfDocument = new Document(new PdfDocument(new PdfWriter($"{document.Title}.pdf")));

            throw new NotImplementedException();
        }

        public Task<Guid> UpdateDocument(Guid id, string title, string description)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> DeleteDocument(Guid id)
        {
            throw new NotImplementedException();
        }

        private void CheckUserDirectory()
        {
            string userPath = path + $"{UserId}";

            if (!File.Exists(userPath))
                Directory.CreateDirectory(userPath);
        }
    }
}
