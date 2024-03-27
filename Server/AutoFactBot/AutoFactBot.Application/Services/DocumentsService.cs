using AutoFactBot.Core.Abstractions;
using AutoFactBot.Core.Models;

namespace AutoFactBot.Application.Services
{
    public class DocumentsService : IDocumentsService
    {
        private readonly IDocumentsRepository _repository;

        public DocumentsService(IDocumentsRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<DocumentModel>> GetAllDocuments()
        {
            return await _repository.GetAllDocuments();
        }

        public async Task<Guid> CreateDocument(DocumentModel document)
        {
            return await _repository.CreateDocument(document);
        }

        public async Task<Guid> UpdateDocument(Guid id, string title, string description)
        {
            return await _repository.UpdateDocument(id, title, description);
        }

        public async Task<Guid> DeleteDocument(Guid id)
        {
            return await _repository.DeleteDocument(id);
        }
    }
}
