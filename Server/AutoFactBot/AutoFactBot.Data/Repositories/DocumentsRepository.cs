using AutoFactBot.Core.Abstractions;
using Microsoft.EntityFrameworkCore;
using AutoFactBot.Data.Entities;
using AutoFactBot.Data.Context;
using AutoFactBot.Core.Models;

namespace AutoFactBot.Data.Repositories
{
    public class DocumentsRepository : IDocumentsRepository
    {
        private readonly DocumentDbContext _dbContext;
        private readonly long _userId;

        public DocumentsRepository(DocumentDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<List<DocumentModel>> GetAllDocuments()
        {
            var documentEntity = await _dbContext.Documents
                .AsNoTracking()
                .ToListAsync();

            var documents = documentEntity.Select(
                s => DocumentModel.Create(
                    s.Id,
                    s.Title,
                    s.CarModel,
                    s.VinNumber,
                    s.EngineNumber,
                    s.Mileage,
                    s.Owner,
                    s.CountOwners,
                    s.Year,
                    s.GearBox,
                    s.Color,
                    s.CountKeys,
                    s.Interior).Item1).ToList();

            return documents;
        }

        public async Task<Guid> CreateDocument(DocumentModel document)
        {
            var userExists = _dbContext.Users.FirstOrDefault(u => u.Id == _userId);

            if (userExists == null)
            {
                var userEntity = new UserEntity()
                {
                    Id = _userId,
                };

                await _dbContext.AddAsync(userEntity);
            }

            var documentEntity = new DocumentEntity()
            {
                Id              = document.Id,
                Title           = document.Title,
                CarModel        = document.CarModel,
                VinNumber       = document.VinNumber,
                EngineNumber    = document.EngineNumber,
                Mileage         = document.Mileage,
                Owner           = document.Owner,
                CountOwners     = document.CountOwners,
                Year            = document.Year,
                GearBox         = document.GearBox,
                Color           = document.Color,
                CountKeys       = document.CountKeys,
                Interior        = document.Interior,
                UserId          = _userId
            };

            await _dbContext.AddAsync(documentEntity);
            await _dbContext.SaveChangesAsync();

            return documentEntity.Id;
        }

        public Task<Guid> UpdateDocument(Guid id, string title, string description)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> DeleteDocument(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
