using AutoFactBot.Core.Models;

namespace AutoFactBot.Core.Abstractions
{
    public interface IDocumentsRepository
    {
        Task<List<DocumentModel>> GetAllDocuments();
        Task<Guid> CreateDocument(DocumentModel document);
        Task<Guid> UpdateDocument(Guid id, string title, string description);
        Task<Guid> DeleteDocument(Guid id);
    }
}
