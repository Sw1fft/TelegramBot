using AutoFactBot.Core.Abstractions;
using AutoFactBot.Core.Models;

namespace AutoFactBot.Data.Repositories
{
    public class DocumentsRepository : IDocumentsRepository
    {
        public static long UserId { get; set; } = 0;

        private readonly string path = @$"D:\AppDocumentsData\AutoFactBot\Users\{UserId}";

        public async Task<List<DocumentModel>> GetAllDocuments()
        {
            throw new NotImplementedException();

            //var documents = Directory.GetFiles(path);


        }

        public async Task<Guid> CreateDocument(DocumentModel document)
        {
            throw new NotImplementedException();
            //return document.Id;
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
            if (!File.Exists(path))
                Directory.CreateDirectory(path);
        }
    }
}
